using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Heimdall_Tester
{
    public partial class DebugForm : Form
    {
        private HeimdallCheck tester = null;

        /*** Constructor ***/
        public DebugForm()
        {
            InitializeComponent();
        }

        /*** UI Manipulation ***/
        private void FreezeSettings() { FreezeSettings(true); }
        private void UnfreezeSettings() { FreezeSettings(false); }
        private void FreezeSettings(bool doFreeze)
        {
            tbAddress.Enabled = (!doFreeze);
            numPort.Enabled = (!doFreeze);
            tbUsername.Enabled = (!doFreeze);
            tbPassword.Enabled = (!doFreeze);
        }

        private void UpdateStatus(string line)
        {
            tbData.Text += line + Environment.NewLine;
        }
        private void UpdateIO()
        {
            string nextLine;
            do
            {
                nextLine = tester.NextLine;
                if (nextLine != null)
                    UpdateStatus(nextLine);
            } while (nextLine != null);
        }
        private void UpdateReadings()
        {
            Color negativeColor = (tester.Running) ? Color.Yellow : Color.Red;

            stRunning.BackColor = (tester.Running) ? Color.Lime : Color.Transparent;
            stHeimdall.BackColor = (tester.HasHeimdall) ? Color.Lime : negativeColor;
            stHorton.BackColor = (tester.HasHorton) ? Color.Lime : negativeColor;
            stTribble.BackColor = (tester.HasTribble) ? Color.Lime : negativeColor;

            if (tester.HeimdallNumber > 0)
                txtHeimdallId.Text = tester.HeimdallNumber.ToString();

            string phaseText = "Unknown";
            switch (tester.ConnectionPhase)
            {
                case Phase.Init:
                    phaseText = "INIT";
                    break;
                case Phase.Connecting:
                    phaseText = "Connecting";
                    break;
                case Phase.MOTD:
                    phaseText = "Awaiting MOTD";
                    break;
                case Phase.Auth:
                    phaseText = "Logging in";
                    break;
                case Phase.Connected:
                    phaseText = "In Progress...";
                    break;
                case Phase.Disconnected:
                    phaseText = "Disconnected";
                    break;
            }
            txtPhase.Text = phaseText;

            // Update IO
            UpdateIO();
        }
        private void StopTest()
        {
            UnfreezeSettings();
            refreshTimer.Stop();
            UpdateReadings();
        }

        /*** Event Handlers ***/
        private void DebugForm_Load(object sender, EventArgs e)
        {
            // Initialization.
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Shut off the test if it's taking place.
            if (tester != null)
                tester.Stop();

            // Shut off the refresh timer if it's still running.
            refreshTimer.Stop();

            // Close this form.
            this.Close();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (btnConnect.Text == "&Connect")
            {
                // Clear the log.
                tbData.Text = "";

                // Create a tester instance.
                tester = new HeimdallCheck();
                tester.SetAddress(tbAddress.Text, (ushort)numPort.Value);
                tester.SetLogin(tbUsername.Text, tbPassword.Text);

                // Before we connect, freeze the settings from further tampering.
                FreezeSettings();

                // Change the Connect/Disconnect button.
                btnConnect.Text = "&Disconnect";

                // Start the test and run the timer.
                UpdateStatus("Starting a heimdall test...");
                tester.Start();
                refreshTimer.Start();
            }
            else
            {
                txtPhase.Text = "Aborted";
                tester.Stop();
                btnConnect.Text = "&Connect";
                UpdateStatus("Test aborted!");
                StopTest();
            }
        }

        private void refreshTimer_Tick(object sender, EventArgs e)
        {
            // Synchronize the readings from the tester.
            UpdateReadings();

            // If the tester is no longer running, assume test done.
            if (!tester.Running)
            {
                // Update whatever status is left.
                UpdateStatus("Test is no longer running - stopping diagnostic.");
                StopTest();

                // If there was an error message, display it.
                if (tester.Error)
                    UpdateStatus("Error Message: " + tester.ErrorMessage);
                else
                    UpdateStatus("Test successfully completed!");
            }
        }
    }
}
