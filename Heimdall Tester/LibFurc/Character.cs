/*
 *** Character Handling Class - Furcadia Library
 *
 * Copyright (c) 2009 by IceDragon of QuickFox.org - All rights reserved.
 * 
 * <icedragon@quickfox.org>
 * http://www.icerealm.org/
 * 
 * This file contains the classes responsible for the Furcadia character
 * information and its manipulation.
 */

using System;
using System.IO;

namespace Furcadia
{
    public class Character
    {
        //--- Data Members ---//
        private string sLongName;
        private string sShortName;
        private string sPassword;
        private string sColorString = "t#############"; // TODO: Make a ColorString class that translates these.
        private string sDescription = "";

        //--- Properties ---//
        public string LongName {
            get { return sLongName; }
            set { SetName(value); }
        }
        public string ShortName {
            get { return sShortName; }
        }
        public string Password {
            get { return GetPassword(); }
            set { SetPassword(value); }
        }
        public string Description
        {
            get { return sDescription; }
            set { SetDescription(value); }
        }
        public string ColorString
        {
            get { return sColorString; }
            set { sColorString = value; }
        }
        
        //--- Class Functions ---//
        /// <summary>
        /// Generate a Furcadia short (safe) name from a long name.
        /// </summary>
        /// <param name="longName">Long (full) name of a character.</param>
        /// <returns>Short (safe) name generated from the long name.</returns>
        public static string GetShortName( string longName )
        {
            string shortname = "";

            foreach( int ch in longName.ToLower() )
            {
                /// TODO: Convert special characters to their simple equivalents.
                // Looking for 0-9 and a-z
                if( ( ch >= 0x30 && ch <= 0x39 ) ||
                    ( ch >= 0x61 && ch <= 0x7a ) )
                    shortname += (char)ch;
            }

            return shortname;
        }

        /// <summary>
        /// Generate a furcadia.ini filename based on a long name.
        /// </summary>
        /// <param name="longName">Long (full) name of a character.</param>
        /// <returns>Character-specific furcadia.ini filename.</returns>
        public static string GetIniFilename(string longName)
        {
            string shortname = Character.GetShortName(longName);
            return String.Format("furcadia-{0}.ini", shortname);
        }

        /// <summary>
        /// Find the full traditional path of the character files on this machine.
        /// Localdir settings in Furcadia can change this!
        /// </summary>
        /// <returns>Full path to the Furcadia Characters folder.</returns>
        public static string GetCharacterPath()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Furcadia\Furcadia Characters\";
        }


        //--- Object Methods ---//
        /// <summary>
        /// Set the character name and shortname, generated from the long name given.
        /// </summary>
        /// <param name="newLongName">Long (full) name of the character.</param>
        public void SetName(string newLongName)
        {
            SetName(newLongName, null);
        }

        /// <summary>
        /// Set the character longname and shortname.
        /// </summary>
        /// <param name="newLongName">Long (full) name of the character.</param>
        /// <param name="newShortName">Short (safe) name of the character or null for auto-generation.</param>
        public void SetName(string newLongName, string newShortName)
        {
            sLongName = newLongName.Replace(' ','|');
            sShortName = (newShortName == null) ? GetShortName(newLongName) : newShortName;
        }

        /// <summary>
        /// Safely set the character password.
        /// </summary>
        /// <param name="newPassword">New character password</param>
        public void SetPassword(string newPassword)
        {
            sPassword = newPassword.Replace(' ','_');
        }

        /// <summary>
        /// Safely set the character description.
        /// </summary>
        /// <param name="newDescription">New character description.</param>
        public void SetDescription(string newDescription)
        {
            sDescription = newDescription.Replace('\n', ' ');
        }

        /// <summary>
        /// Read character information from a furcadia.ini file.
        /// 
        /// This method will throw an exception if there is a problem with
        /// the reading process!
        /// </summary>
        /// <param name="iniPath">Full or relative path to the file.</param>
        public void LoadCharacterFile(string iniPath)
        {
            using (StreamReader sr = new StreamReader(iniPath))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    line.Trim();
                    if (line.StartsWith("Colors="))
                        ColorString = line.Substring(7);
                    else if (line.StartsWith("Name="))
                        LongName = line.Substring(5);
                    else if (line.StartsWith("Password="))
                        Password = line.Substring(9);
                    else if (line.StartsWith("Desc="))
                        Description = line.Substring(5);
                }
            }
        }

        /// <summary>
        /// Save character information into a version 3.0 furcadia.ini file.
        /// 
        /// This method will throw an exception if there is a problem with
        /// the writing process!
        /// </summary>
        /// <param name="iniPath">Full or relative path to the file.</param>
        public void SaveCharacterFileV3(string iniPath)
        {
            using (StreamWriter sw = new StreamWriter(iniPath, false))
            {
                sw.WriteLine("V3.0 character");
                sw.WriteLine("Colors={0}", ColorString);
                sw.WriteLine("Name={0}", LongName);
                sw.WriteLine("Password={0}", sPassword); // Best to approach directly.
                sw.WriteLine("Desc={0}", Description.Replace('\n', ' '));
                sw.WriteLine("Logins=0");
                sw.WriteLine("LastLogin=0");
                sw.WriteLine("AutoResponse=0");
                sw.WriteLine("AutoResponseMessage=Thank you for whispering! This is " +
                    "my automatic response message. #SA");
                sw.WriteLine("AFKTime=20");
                sw.WriteLine("AFKMessage=Inactive -- Sorry, this furre has been away " +
                    "for the last [afkhours] hours and [afkminutes] minutes and may " +
                    " have missed your whisper. ([afkreason])");
                sw.WriteLine("AFKPortrait=0");
                sw.WriteLine("DefaultPortrait=0");
                sw.WriteLine("AFKDisconnectTime=0");
                sw.Close();
            }
        }

        /// <summary>
        /// Return a string representation of the character (in our case, its long name).
        /// </summary>
        /// <returns>Long name of the character.</returns>
        public override string ToString()
        {
            return LongName;
        }

        /// <summary>
        /// Retrieve the character password as a string.
        /// </summary>
        /// <returns>Character password.</returns>
        public string GetPassword()
        {
            /// TODO: Find a better way to manipulate the character password.
            return sPassword;
        }
    }
}
