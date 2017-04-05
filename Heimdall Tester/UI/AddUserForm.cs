using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Furcadia;

namespace Heimdall_Tester
{
    public partial class AddUserForm : Form
    {
        /*** Members ***/
        public bool ValidData = false;
        public string Username = "";
        public string Password = "";

        /*** Constructor ***/
        public AddUserForm()
        {
            InitializeComponent();
        }

        /*** Methods ***/
        private bool VerifyData()
        {
            return Username != "" && Password != "";
        }

        private void UpdateUI()
        {
            tbUsername.Text = Username;
            tbPassword.Text = Password;
        }

        private void SyncData()
        {
            Username = tbUsername.Text;
            Password = tbPassword.Text;
        }

        /*** Event Handlers ***/
        private void btnOk_Click(object sender, EventArgs e)
        {
            SyncData();
            ValidData = VerifyData();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            ofdLoadCharacter.InitialDirectory = Paths.CharacterPath;
            if (ofdLoadCharacter.ShowDialog() == DialogResult.OK)
            {
                Character c = new Character();
                c.LoadCharacterFile(ofdLoadCharacter.FileName);
                Username = c.LongName;
                Password = c.Password;
                UpdateUI();
            }
        }
        private void HandleKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (tbUsername.Text.Length == 0)
                    tbUsername.Focus();
                else if (tbPassword.Text.Length == 0)
                    tbPassword.Focus();
                else
                    btnOk.PerformClick();
            }
            if (e.KeyChar == (char)Keys.Escape)
                btnCancel.PerformClick();
        }

        private void tbUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleKeyPress(sender, e);
        }

        private void tbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleKeyPress(sender, e);
        }
    }
}
