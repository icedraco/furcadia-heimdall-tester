using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.Win32;

namespace Heimdall_Tester
{
    public class Settings
    {
        /*** Constants ***/
        const int MAX_HEIMDALL_AMOUNT = 10;

        /*** Members ***/
        public string Address = "lightbringer.furcadia.com";
        public ushort Port = 6500;
        public Dictionary<string,string> UserList = new Dictionary<string,string>();

        private int nHeimdalls = 6;
        private int nConnectionAttempts = 25;

        // Scrambling key...
        private byte[] key = new byte[] {
                0x48, 0x44, 0x43, 0x48, 0x4B, 0x55, 0x2D, 0x49,
                0x52, 0x13, 0x37, 0x54, 0x6F, 0x4F, 0x6D, 0x41,
                0x6E, 0x59, 0x73, 0x45, 0x63, 0x52, 0x65, 0x54,
                0x73, 0xA7, 0x28, 0x19, 0xCC, 0x8B, 0x3F, 0x20
            };

        /*** Properties ***/
        public int UserAmount { get { return UserList.Count; } }
        public int HeimdallAmount
        {
            get { return nHeimdalls; }
            set {
                // Make sure the value is in range. Adjust to fit if not.
                nHeimdalls = (value < 1) ? 1 : (value > MAX_HEIMDALL_AMOUNT) ? MAX_HEIMDALL_AMOUNT : value;

                // Correct connection attempts if heimdall amount if bigger
                // than the attempts count.
                if (nConnectionAttempts < nHeimdalls)
                    nConnectionAttempts = nHeimdalls;
            }
        }
        public int ConnectionAttempts
        {
            get { return nConnectionAttempts; }
            set { nConnectionAttempts = (value < nHeimdalls) ? nHeimdalls : value; }
        }

        /*** Static Functions ***/
        public static bool CanLoad()
        {
            return Registry.CurrentUser.OpenSubKey(@"Software\IceRealm\HeimdallCheck") != null;
        }
        public static Settings LoadSettings()
        {
            Settings sets = new Settings();
            return sets.Load() ? sets : null;
        }
        public static void DeleteSettings()
        {
            RegistryKey rk = Registry.CurrentUser.OpenSubKey(@"Software\IceRealm", true);

            if (rk != null)
            {
                rk.DeleteSubKey("HeimdallCheck");
                int whatsLeft = rk.GetSubKeyNames().Length;
                rk.Close();

                // If there's nothing left there, remove the entire IceRealm key.
                if (whatsLeft == 0)
                {
                    RegistryKey rkSoft = Registry.CurrentUser.OpenSubKey("Software", true);
                    rkSoft.DeleteSubKey("IceRealm");
                    rkSoft.Close();
                }
            }
        }

        /*** Constructor ***/
        public Settings()
        {
        }

        /*** Methods ***/
        public void AddUser(string charName, string password)
        {
            // Transform spaces and stuff
            charName = charName.Replace(' ', '|');
            password = password.Replace(' ', '_');

            // Sanity checks
            if (UserList.ContainsKey(charName))
                throw new Exception("Character already exists");

            // Add it on
            UserList.Add(charName, password);
        }

        public void DelUser(string charName)
        {
            // Transform spaces and stuff
            charName = charName.Replace(' ', '|');

            // Remove it
            if (UserList.ContainsKey(charName))
                UserList.Remove(charName);
        }

        /*** Methods - Import/Export ***/
        public bool Load()
        {
            RegistryKey rk = Registry.CurrentUser.OpenSubKey(@"Software\IceRealm\HeimdallCheck");

            // If there's nothing in the registry, assume load failed.
            if (rk == null) return false;

            // Prime data.
            this.Address = (string)rk.GetValue("Address", this.Address);
            this.Port = Convert.ToUInt16(rk.GetValue("Port", this.Port));
            this.nHeimdalls = (int)rk.GetValue("NumHeimdalls", this.nHeimdalls);
            this.nConnectionAttempts = (int)rk.GetValue("NumConnectionAttempts", this.nConnectionAttempts);
            
            object objUserList = rk.GetValue("UserList");
            if (objUserList == null)
                return true; // Early completion.

            string userList = UnscrambleUserList((byte[])objUserList);
            Dictionary<string, string> newUserList = new Dictionary<string, string>();

            foreach (string line in userList.Split('\n'))
            {
                if (line.Length < 3) continue;

                string[] tokens = line.Split('\t');
                if (tokens.Length != 2) continue; // Decrypt must be corrupted..
                newUserList.Add(tokens[0], tokens[1]);
            }
            UserList = newUserList;
            return true; // Load successful.
        }
        public bool Save()
        {
            // If the IceRealm key is missing, create it.
            RegistryKey irrk = Registry.CurrentUser.OpenSubKey(@"Software\IceRealm", true);
            if (irrk == null)
            {
                irrk = Registry.CurrentUser.OpenSubKey("Software", true);
                irrk.CreateSubKey("IceRealm");
                irrk = Registry.CurrentUser.OpenSubKey(@"Software\IceRealm", true);
                if (irrk == null) return false;
            }

            // If the HeimdallCheck key is missing, create it.
            RegistryKey rk = Registry.CurrentUser.OpenSubKey(@"Software\IceRealm\HeimdallCheck", true);
            if (rk == null)
            {
                irrk.CreateSubKey("HeimdallCheck");
                rk = Registry.CurrentUser.OpenSubKey(@"Software\IceRealm\HeimdallCheck", true);
                if (rk == null) return false;
            }
            irrk.Close();

            // Start storing data.
            rk.SetValue("Address", Address, RegistryValueKind.String);
            rk.SetValue("Port", Port, RegistryValueKind.DWord);
            rk.SetValue("NumHeimdalls", nHeimdalls, RegistryValueKind.DWord);
            rk.SetValue("NumConnectionAttempts", nConnectionAttempts, RegistryValueKind.DWord);
            rk.SetValue("UserList", ScrambleUserList(), RegistryValueKind.Binary);
            return true;
        }

        /*** Helper Methods (PRIVATE) ***/
        // Encryption here is more a means of not leaving data like login
        // info laying around in plain text. Obviously, people targetting
        // this tool owners specifically, would know how to decrypt it if
        // they have the source code or some common sense...
        // 
        // Look at the bright side: Furcadia INI files are in plaintext and
        // more accessible than this! :P
        private string UnscrambleUserList(byte[] encrypted)
        {
            StringBuilder decrypted = new StringBuilder();

            for (int i = 0; i < encrypted.Length; i++)
            {
                int ki = i % 32;
                decrypted.Append( (char)((encrypted[i] ^ (key[ki] + key[31 - ki])) % 256) );
            }

            return decrypted.ToString();
        }

        private byte[] ScrambleUserList()
        {
            StringBuilder sb = new StringBuilder();
            foreach (string username in UserList.Keys)
                sb.AppendFormat("{0}\t{1}\n", username, UserList[username]);

            byte[] decrypted = Encoding.ASCII.GetBytes(sb.ToString());
            byte[] encrypted = new byte[decrypted.Length];

            for (int i = 0; i < decrypted.Length; i++)
            {
                int ki = i % 32;
                encrypted[i] = (byte)((decrypted[i] ^ (key[ki] + key[31 - ki])) % 256);
            }

            return encrypted;
        }
    }
}
