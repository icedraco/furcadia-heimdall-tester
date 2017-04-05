using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Heimdall_Tester
{
    public partial class Form1 : Form
    {
        /*** Members ***/
        HeimdallCheckController hcc = new HeimdallCheckController();
        string ScanBlockReason = null;

        Settings AppSettings = new Settings();

        /*** Properties ***/
        private bool CanScan
        {
            get { return CheckScan(); }
        }
        private int ErrorCount { get { return hcc.Errors.Count; } }
        private string[] ErrorList
        {
            get
            {
                // Transform into an array of strings.
                string[] result = new string[hcc.Errors.Count];
                hcc.Errors.CopyTo(result);
                return result;
            }
        }
        private string Status
        {
            get { return txtStatus.Text; }
            set { txtStatus.Text = value; }
        }


        /*** Constructor ***/
        public Form1()
        {
            InitializeComponent();

            // Load settings (if able) and prime them.
            Settings sets = new Settings();
            sets.Load();
            ApplySettings(sets);
            Status = "Ready.";
        }

        /*** Methods ***/
        private bool CheckScan()
        {
            // See if we have at least one user info to log in with.
            if (AppSettings.UserAmount < 1)
            {
                ScanBlockReason = "No characters to log in with";
                return false;
            }

            ScanBlockReason = null;
            return true;
        }
        private void DoScan()
        {
            // If we can't scan yet, display an error and let the user fix it.
            if (!CanScan)
            {
                MessageBox.Show(ScanBlockReason, "Not ready", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Change the button to "Stop"
            btnScan.Text = "Sto&p";

            // Silence the "Settings" and "Diagnostic" buttons.
            btnSettings.Enabled = false;
            btnDiagnostics.Enabled = false;
            Status = "Scanning...";

            // Initialize the check controller and start the checks.
            hcc = new HeimdallCheckController(AppSettings);
            hcc.Start();
            UpdateStatus();
            refreshTimer.Start();
        }

        private void StopScan()
        {
            refreshTimer.Stop();

            // Change the button to "Scan"
            btnScan.Text = "&Scan";

            // Reactivate the "Settings" and "Diagnostic" buttons.
            btnSettings.Enabled = true;
            btnDiagnostics.Enabled = true;

            // Deactivate checks.
            hcc.Stop();
            Status = "Ready.";
        }

        private void UpdateStatus()
        {
            // Update the checks so far.
            hcc.Update();

            // Update the status labels to the right.
            txtConnectionAttempt.Text = String.Format("{0}/{1}", hcc.RequestsMade, hcc.MaxRequests);
            txtHeimdallsAcquired.Text = String.Format("{0}/{1}", hcc.HeimdallsScanned, hcc.HeimdallAmount);
            txtErrors.Text = ErrorCount.ToString();
            
            // Update the list itself.
            HeimdallCheckController.HeimdallStatus heimStatus;
            for (int heim = 1; heim <= hcc.HeimdallAmount; heim++)
            {
                heimStatus = hcc.GetHeimdallStatus(heim);
                SetHeimdallStatus(heim, heimStatus);
            }
        }

        private void ApplySettings(Settings sets)
        {
            // These are now primary.
            AppSettings = sets;

            // Update the heimdall list to reflect the heimdalls and users.
            ClearHeimdallTable();

            for (int i = 1; i <= sets.HeimdallAmount; i++)
                HeimdallTableAdd(i);

            // Update the labels.
            txtConnectionAttempt.Text = "-/" + sets.ConnectionAttempts.ToString();
            txtHeimdallsAcquired.Text = "-/" + sets.HeimdallAmount.ToString();
            txtUserCount.Text = sets.UserAmount.ToString();

            btnScan.Enabled = CanScan;
        }

        /*** Methods - Heimdall Table Manipulation ***/
        private void ClearHeimdallTable()
        {
            dgvHeimdall.Rows.Clear();
        }

        private void HeimdallTableAdd(int heimID)
        {
            int iRow = dgvHeimdall.Rows.Add();
            dgvHeimdall.Rows[iRow].Cells[0].Value = heimID;
            dgvHeimdall.Rows[iRow].Cells[1].Value = 0;
            dgvHeimdall.Rows[iRow].Cells[2].Value = "?";
            dgvHeimdall.Rows[iRow].Cells[3].Value = "?";
            dgvHeimdall.Rows[iRow].Cells[4].Value = "?";

            for (int i = 0; i < 5; i++)
                dgvHeimdall.Rows[iRow].Cells[i].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void SetHeimdallStatus(int heimID, HeimdallCheckController.HeimdallStatus status)
        {
            // Locate the right row - one that corresponds to heimID.
            int row;
            for (row = 0; row < dgvHeimdall.Rows.Count; row++)
                if ((int)dgvHeimdall.Rows[row].Cells[0].Value == heimID)
                    break;

            // If we reached beyond the row count, then for some reason, we
            // didn't find the right heimdall ID...
            if (row == dgvHeimdall.Rows.Count)
                throw new System.MissingFieldException("SetHeimdallStatus() request to unknown heimdall ID " + heimID.ToString());

            dgvHeimdall.Rows[row].Cells[1].Value = status.Hits;

            if (status.Hits > 0)
            {
                dgvHeimdall.Rows[row].Cells[0].Style.BackColor = Color.Lime;

                dgvHeimdall.Rows[row].Cells[2].Value = (status.HasHeimdall) ? status.HeimdallQTEMP.ToString() : "FAIL";
                dgvHeimdall.Rows[row].Cells[2].Style.BackColor = (status.HasHeimdall) ? Color.Lime : Color.Red;

                dgvHeimdall.Rows[row].Cells[3].Value = (status.HasHorton) ? status.HortonQTEMP.ToString() : "FAIL";
                dgvHeimdall.Rows[row].Cells[3].Style.BackColor = (status.HasHorton) ? Color.Lime : Color.Red;

                dgvHeimdall.Rows[row].Cells[4].Value = (status.HasTribble) ? status.TribbleQTEMP.ToString() : "FAIL";
                dgvHeimdall.Rows[row].Cells[4].Style.BackColor = (status.HasTribble) ? Color.Lime : Color.Red;
            }
        }

        #region Event Handlers
        private void btnDiagnostics_Click(object sender, EventArgs e)
        {
            // Open diagnostics window
            DebugForm dbgForm = new DebugForm();
            dbgForm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            if (btnScan.Text == "&Scan")
                DoScan();
            else
                StopScan();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            // Show the settings dialog
            SettingsForm settingsForm = new SettingsForm(AppSettings);
            if (settingsForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ApplySettings(settingsForm.AppSettings);
            }
        }

        private void refreshTimer_Tick(object sender, EventArgs e)
        {
            if (hcc.Ready)
                StopScan();
            else
                UpdateStatus();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            hcc.Stop();
        }

        private void txtErrors_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (ErrorCount > 0)
            {
                ErrorLogForm errorLogForm = new ErrorLogForm(ErrorList);
                errorLogForm.ShowDialog();
            }
            else
                MessageBox.Show("No errors logged", "Error Log", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvHeimdall_SelectionChanged(object sender, EventArgs e)
        {
            dgvHeimdall.ClearSelection();
        }
        #endregion
    }
}
