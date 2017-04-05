using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Heimdall_Tester
{
    public partial class SettingsForm : Form
    {
        /*** Members ***/
        public Settings AppSettings;

        /*** Constructor ***/
        public SettingsForm() : this(new Settings()) { }
        public SettingsForm(Settings sets)
        {
            AppSettings = sets;
            InitializeComponent();

            // Update settings from the class.
            UpdateSettings();

            // Set the "Remove" status.
            btnRemoveFromDisk.Enabled = Settings.CanLoad();
        }

        /*** Methods ***/
        private void UpdateUserTable()
        {
            lbUserList.Items.Clear();
            foreach (string username in AppSettings.UserList.Keys)
                lbUserList.Items.Add(username.Replace('|', ' '));
        }

        private void UpdateSettings()
        {
            tbAddress.Text = AppSettings.Address;
            numPort.Value = AppSettings.Port;
            numConnectionAttempts.Value = AppSettings.ConnectionAttempts;
            numHeimdallAmount.Value = AppSettings.HeimdallAmount;

            // Update the user table with whatever is inside.
            UpdateUserTable();
        }

        private void SyncSettings()
        {
            AppSettings.Address = (tbAddress.Text != "") ? tbAddress.Text : AppSettings.Address;
            AppSettings.Port = (ushort)numPort.Value;
            AppSettings.ConnectionAttempts = (int)numConnectionAttempts.Value;
            AppSettings.HeimdallAmount = (int)numHeimdallAmount.Value;
        }

        private bool AddUser(string name, string password)
        {
            // Check for duplicates in the list.
            string shortname = Furcadia.Character.GetShortName(name);
            foreach (string username in AppSettings.UserList.Keys)
            {
                if (shortname == Furcadia.Character.GetShortName(username))
                    return false;
            }

            // No duplicates found, add the name.
            AppSettings.UserList.Add(name, password);
            lbUserList.Items.Add(name);
            return true;
        }

        /*** Event Handlers ***/
        private void SettingsForm_Load(object sender, EventArgs e)
        {
            // ???
        }

        private void btnRemoveFromDisk_Click(object sender, EventArgs e)
        {
            try
            {
                Settings.DeleteSettings();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            btnRemoveFromDisk.Enabled = Settings.CanLoad();
        }

        private void btnDelUser_Click(object sender, EventArgs e)
        {
            // Figure out what was selected, verify and delete from list.
            for (int i = 0; i < AppSettings.UserAmount; i++)
            {
                // Short circuit :D
                if (lbUserList.SelectedItem == lbUserList.Items[i] &&
                    DialogResult.Yes == MessageBox.Show("Delete the user " + (string)lbUserList.Items[i] + "?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    AppSettings.DelUser((string)lbUserList.Items[i]);
                    lbUserList.Items.Remove(lbUserList.Items[i]);
                }
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            SyncSettings();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SyncSettings();
            if (!AppSettings.Save())
                MessageBox.Show("Save failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void numHeimdallAmount_ValueChanged(object sender, EventArgs e)
        {
            // Store this in the class immediately and update this and connection
            // attempts. One has to not go under the other and the class will
            // deal with this correction for us.
            AppSettings.HeimdallAmount = (int)numHeimdallAmount.Value;

            numHeimdallAmount.Value = AppSettings.HeimdallAmount;
            numConnectionAttempts.Value = AppSettings.ConnectionAttempts;
        }

        private void numConnectionAttempts_ValueChanged(object sender, EventArgs e)
        {
            // Store this in the class immediately and update this and heimdall
            // count. One has to not go under the other and the class will deal
            // with this correction for us.
            AppSettings.ConnectionAttempts = (int)numConnectionAttempts.Value;

            numHeimdallAmount.Value = AppSettings.HeimdallAmount;
            numConnectionAttempts.Value = AppSettings.ConnectionAttempts;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddUserForm addUser = new AddUserForm();
            bool userAdded = false;

            // If the user wasn't added for some reason, go through the adding
            // procedure again - get them back there.
            do
            {
                DialogResult result = addUser.ShowDialog();
                userAdded = (result == DialogResult.OK && addUser.ValidData)
                    ? AddUser(addUser.Username, addUser.Password) : true;

                if (!userAdded)
                    MessageBox.Show("Name already exists - please choose another", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } while (!userAdded);
        }
    }
}
