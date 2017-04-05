namespace Heimdall_Tester
{
    partial class SettingsForm
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
            this.grpAccountInfo = new System.Windows.Forms.GroupBox();
            this.btnDelUser = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.lbUserList = new System.Windows.Forms.ListBox();
            this.grpConnectivity = new System.Windows.Forms.GroupBox();
            this.numConnectionAttempts = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numPort = new System.Windows.Forms.NumericUpDown();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpTestSettings = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numHeimdallAmount = new System.Windows.Forms.NumericUpDown();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnRemoveFromDisk = new System.Windows.Forms.Button();
            this.grpAccountInfo.SuspendLayout();
            this.grpConnectivity.SuspendLayout();
            this.grpTestSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAccountInfo
            // 
            this.grpAccountInfo.Controls.Add(this.btnDelUser);
            this.grpAccountInfo.Controls.Add(this.btnAddUser);
            this.grpAccountInfo.Controls.Add(this.lbUserList);
            this.grpAccountInfo.Location = new System.Drawing.Point(12, 12);
            this.grpAccountInfo.Name = "grpAccountInfo";
            this.grpAccountInfo.Size = new System.Drawing.Size(168, 173);
            this.grpAccountInfo.TabIndex = 0;
            this.grpAccountInfo.TabStop = false;
            this.grpAccountInfo.Text = "Account Info";
            // 
            // btnDelUser
            // 
            this.btnDelUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelUser.Location = new System.Drawing.Point(87, 144);
            this.btnDelUser.Name = "btnDelUser";
            this.btnDelUser.Size = new System.Drawing.Size(75, 23);
            this.btnDelUser.TabIndex = 3;
            this.btnDelUser.Text = "&Remove";
            this.btnDelUser.UseVisualStyleBackColor = true;
            this.btnDelUser.Click += new System.EventHandler(this.btnDelUser_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddUser.Location = new System.Drawing.Point(6, 144);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(75, 23);
            this.btnAddUser.TabIndex = 2;
            this.btnAddUser.Text = "&Add";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // lbUserList
            // 
            this.lbUserList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbUserList.FormattingEnabled = true;
            this.lbUserList.Location = new System.Drawing.Point(6, 19);
            this.lbUserList.Name = "lbUserList";
            this.lbUserList.Size = new System.Drawing.Size(156, 121);
            this.lbUserList.TabIndex = 1;
            // 
            // grpConnectivity
            // 
            this.grpConnectivity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpConnectivity.Controls.Add(this.numConnectionAttempts);
            this.grpConnectivity.Controls.Add(this.label3);
            this.grpConnectivity.Controls.Add(this.label2);
            this.grpConnectivity.Controls.Add(this.numPort);
            this.grpConnectivity.Controls.Add(this.tbAddress);
            this.grpConnectivity.Controls.Add(this.label1);
            this.grpConnectivity.Location = new System.Drawing.Point(186, 12);
            this.grpConnectivity.Name = "grpConnectivity";
            this.grpConnectivity.Size = new System.Drawing.Size(209, 101);
            this.grpConnectivity.TabIndex = 1;
            this.grpConnectivity.TabStop = false;
            this.grpConnectivity.Text = "Connectivity";
            // 
            // numConnectionAttempts
            // 
            this.numConnectionAttempts.Location = new System.Drawing.Point(60, 72);
            this.numConnectionAttempts.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numConnectionAttempts.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numConnectionAttempts.Name = "numConnectionAttempts";
            this.numConnectionAttempts.Size = new System.Drawing.Size(69, 20);
            this.numConnectionAttempts.TabIndex = 5;
            this.numConnectionAttempts.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numConnectionAttempts.ValueChanged += new System.EventHandler(this.numConnectionAttempts_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Attempts:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port:";
            // 
            // numPort
            // 
            this.numPort.Location = new System.Drawing.Point(60, 46);
            this.numPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPort.Name = "numPort";
            this.numPort.Size = new System.Drawing.Size(69, 20);
            this.numPort.TabIndex = 2;
            this.numPort.Value = new decimal(new int[] {
            6500,
            0,
            0,
            0});
            // 
            // tbAddress
            // 
            this.tbAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAddress.Location = new System.Drawing.Point(60, 20);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(143, 20);
            this.tbAddress.TabIndex = 1;
            this.tbAddress.Text = "lightbringer.furcadia.com";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Address:";
            // 
            // grpTestSettings
            // 
            this.grpTestSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpTestSettings.Controls.Add(this.label4);
            this.grpTestSettings.Controls.Add(this.numHeimdallAmount);
            this.grpTestSettings.Location = new System.Drawing.Point(186, 119);
            this.grpTestSettings.Name = "grpTestSettings";
            this.grpTestSettings.Size = new System.Drawing.Size(209, 66);
            this.grpTestSettings.TabIndex = 2;
            this.grpTestSettings.TabStop = false;
            this.grpTestSettings.Text = "Test Settings";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Total heimdall amount:";
            // 
            // numHeimdallAmount
            // 
            this.numHeimdallAmount.Location = new System.Drawing.Point(125, 20);
            this.numHeimdallAmount.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numHeimdallAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numHeimdallAmount.Name = "numHeimdallAmount";
            this.numHeimdallAmount.Size = new System.Drawing.Size(78, 20);
            this.numHeimdallAmount.TabIndex = 0;
            this.numHeimdallAmount.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numHeimdallAmount.ValueChanged += new System.EventHandler(this.numHeimdallAmount_ValueChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(320, 191);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(239, 191);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(158, 191);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "&OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnRemoveFromDisk
            // 
            this.btnRemoveFromDisk.Enabled = false;
            this.btnRemoveFromDisk.Location = new System.Drawing.Point(12, 191);
            this.btnRemoveFromDisk.Name = "btnRemoveFromDisk";
            this.btnRemoveFromDisk.Size = new System.Drawing.Size(113, 23);
            this.btnRemoveFromDisk.TabIndex = 6;
            this.btnRemoveFromDisk.Text = "&Remove from disk";
            this.btnRemoveFromDisk.UseVisualStyleBackColor = true;
            this.btnRemoveFromDisk.Click += new System.EventHandler(this.btnRemoveFromDisk_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 224);
            this.Controls.Add(this.btnRemoveFromDisk);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grpTestSettings);
            this.Controls.Add(this.grpConnectivity);
            this.Controls.Add(this.grpAccountInfo);
            this.MaximumSize = new System.Drawing.Size(423, 262);
            this.MinimumSize = new System.Drawing.Size(423, 262);
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.grpAccountInfo.ResumeLayout(false);
            this.grpConnectivity.ResumeLayout(false);
            this.grpConnectivity.PerformLayout();
            this.grpTestSettings.ResumeLayout(false);
            this.grpTestSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAccountInfo;
        private System.Windows.Forms.Button btnDelUser;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.ListBox lbUserList;
        private System.Windows.Forms.GroupBox grpConnectivity;
        private System.Windows.Forms.NumericUpDown numConnectionAttempts;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numPort;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpTestSettings;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numHeimdallAmount;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnRemoveFromDisk;
    }
}