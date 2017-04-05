namespace Heimdall_Tester
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnDiagnostics = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.dgvHeimdall = new System.Windows.Forms.DataGridView();
            this.HeimdallId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeimdallStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HortonStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TribbleStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnScan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtConnectionAttempt = new System.Windows.Forms.Label();
            this.txtHeimdallsAcquired = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserCount = new System.Windows.Forms.Label();
            this.refreshTimer = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.txtErrors = new System.Windows.Forms.LinkLabel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.txtStatus = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHeimdall)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDiagnostics
            // 
            this.btnDiagnostics.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDiagnostics.Location = new System.Drawing.Point(313, 136);
            this.btnDiagnostics.Name = "btnDiagnostics";
            this.btnDiagnostics.Size = new System.Drawing.Size(75, 23);
            this.btnDiagnostics.TabIndex = 2;
            this.btnDiagnostics.Text = "&Diagnostics";
            this.btnDiagnostics.UseVisualStyleBackColor = true;
            this.btnDiagnostics.Click += new System.EventHandler(this.btnDiagnostics_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(313, 165);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dgvHeimdall
            // 
            this.dgvHeimdall.AllowUserToAddRows = false;
            this.dgvHeimdall.AllowUserToDeleteRows = false;
            this.dgvHeimdall.AllowUserToResizeColumns = false;
            this.dgvHeimdall.AllowUserToResizeRows = false;
            this.dgvHeimdall.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvHeimdall.ColumnHeadersHeight = 22;
            this.dgvHeimdall.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvHeimdall.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HeimdallId,
            this.Hits,
            this.HeimdallStatus,
            this.HortonStatus,
            this.TribbleStatus});
            this.dgvHeimdall.Location = new System.Drawing.Point(12, 12);
            this.dgvHeimdall.MultiSelect = false;
            this.dgvHeimdall.Name = "dgvHeimdall";
            this.dgvHeimdall.ReadOnly = true;
            this.dgvHeimdall.RowHeadersVisible = false;
            this.dgvHeimdall.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvHeimdall.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHeimdall.ShowEditingIcon = false;
            this.dgvHeimdall.Size = new System.Drawing.Size(295, 175);
            this.dgvHeimdall.TabIndex = 4;
            this.dgvHeimdall.SelectionChanged += new System.EventHandler(this.dgvHeimdall_SelectionChanged);
            // 
            // HeimdallId
            // 
            this.HeimdallId.HeaderText = "Heimdall #";
            this.HeimdallId.MinimumWidth = 68;
            this.HeimdallId.Name = "HeimdallId";
            this.HeimdallId.ReadOnly = true;
            this.HeimdallId.Width = 68;
            // 
            // Hits
            // 
            this.Hits.HeaderText = "Hits";
            this.Hits.MinimumWidth = 50;
            this.Hits.Name = "Hits";
            this.Hits.ReadOnly = true;
            this.Hits.Width = 50;
            // 
            // HeimdallStatus
            // 
            this.HeimdallStatus.HeaderText = "Heimdall";
            this.HeimdallStatus.MinimumWidth = 58;
            this.HeimdallStatus.Name = "HeimdallStatus";
            this.HeimdallStatus.ReadOnly = true;
            this.HeimdallStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.HeimdallStatus.Width = 58;
            // 
            // HortonStatus
            // 
            this.HortonStatus.HeaderText = "Horton";
            this.HortonStatus.MinimumWidth = 58;
            this.HortonStatus.Name = "HortonStatus";
            this.HortonStatus.ReadOnly = true;
            this.HortonStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.HortonStatus.Width = 58;
            // 
            // TribbleStatus
            // 
            this.TribbleStatus.HeaderText = "Tribble";
            this.TribbleStatus.MinimumWidth = 58;
            this.TribbleStatus.Name = "TribbleStatus";
            this.TribbleStatus.ReadOnly = true;
            this.TribbleStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TribbleStatus.Width = 58;
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettings.Location = new System.Drawing.Point(313, 107);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(75, 23);
            this.btnSettings.TabIndex = 1;
            this.btnSettings.Text = "S&ettings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnScan
            // 
            this.btnScan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnScan.Enabled = false;
            this.btnScan.Location = new System.Drawing.Point(313, 78);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(75, 23);
            this.btnScan.TabIndex = 0;
            this.btnScan.Text = "&Scan";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(313, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "CAtt:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Heim:";
            // 
            // txtConnectionAttempt
            // 
            this.txtConnectionAttempt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConnectionAttempt.AutoSize = true;
            this.txtConnectionAttempt.Location = new System.Drawing.Point(353, 12);
            this.txtConnectionAttempt.Name = "txtConnectionAttempt";
            this.txtConnectionAttempt.Size = new System.Drawing.Size(27, 13);
            this.txtConnectionAttempt.TabIndex = 7;
            this.txtConnectionAttempt.Text = "N/A";
            // 
            // txtHeimdallsAcquired
            // 
            this.txtHeimdallsAcquired.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHeimdallsAcquired.AutoSize = true;
            this.txtHeimdallsAcquired.Location = new System.Drawing.Point(353, 25);
            this.txtHeimdallsAcquired.Name = "txtHeimdallsAcquired";
            this.txtHeimdallsAcquired.Size = new System.Drawing.Size(27, 13);
            this.txtHeimdallsAcquired.TabIndex = 8;
            this.txtHeimdallsAcquired.Text = "N/A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Usr:";
            // 
            // txtUserCount
            // 
            this.txtUserCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserCount.AutoSize = true;
            this.txtUserCount.Location = new System.Drawing.Point(353, 38);
            this.txtUserCount.Name = "txtUserCount";
            this.txtUserCount.Size = new System.Drawing.Size(27, 13);
            this.txtUserCount.TabIndex = 10;
            this.txtUserCount.Text = "N/A";
            // 
            // refreshTimer
            // 
            this.refreshTimer.Tick += new System.EventHandler(this.refreshTimer_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(313, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Errors:";
            // 
            // txtErrors
            // 
            this.txtErrors.AutoSize = true;
            this.txtErrors.Location = new System.Drawing.Point(353, 51);
            this.txtErrors.Name = "txtErrors";
            this.txtErrors.Size = new System.Drawing.Size(13, 13);
            this.txtErrors.TabIndex = 12;
            this.txtErrors.TabStop = true;
            this.txtErrors.Text = "0";
            this.txtErrors.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.txtErrors_LinkClicked);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtStatus});
            this.statusStrip.Location = new System.Drawing.Point(0, 190);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(400, 22);
            this.statusStrip.TabIndex = 5;
            this.statusStrip.Text = "statusStrip1";
            // 
            // txtStatus
            // 
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(64, 17);
            this.txtStatus.Text = "Initializing.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 212);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.txtErrors);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUserCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHeimdallsAcquired);
            this.Controls.Add(this.txtConnectionAttempt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.dgvHeimdall);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDiagnostics);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(416, 250);
            this.MinimumSize = new System.Drawing.Size(416, 250);
            this.Name = "Form1";
            this.Text = "Heimdall Check 1.2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHeimdall)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDiagnostics;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dgvHeimdall;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeimdallId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hits;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeimdallStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn HortonStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn TribbleStatus;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtConnectionAttempt;
        private System.Windows.Forms.Label txtHeimdallsAcquired;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtUserCount;
        private System.Windows.Forms.Timer refreshTimer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel txtErrors;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel txtStatus;

    }
}

