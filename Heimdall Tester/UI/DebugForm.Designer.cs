namespace Heimdall_Tester
{
    partial class DebugForm
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
            this.grpConnection = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numPort = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.stRunning = new System.Windows.Forms.Label();
            this.stTribble = new System.Windows.Forms.Label();
            this.stHorton = new System.Windows.Forms.Label();
            this.stHeimdall = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPhase = new System.Windows.Forms.Label();
            this.txtHeimdallId = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbData = new System.Windows.Forms.TextBox();
            this.refreshTimer = new System.Windows.Forms.Timer();
            this.grpConnection.SuspendLayout();
            this.grpInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpConnection
            // 
            this.grpConnection.Controls.Add(this.btnClose);
            this.grpConnection.Controls.Add(this.btnConnect);
            this.grpConnection.Controls.Add(this.label4);
            this.grpConnection.Controls.Add(this.label3);
            this.grpConnection.Controls.Add(this.tbPassword);
            this.grpConnection.Controls.Add(this.tbUsername);
            this.grpConnection.Controls.Add(this.label2);
            this.grpConnection.Controls.Add(this.numPort);
            this.grpConnection.Controls.Add(this.label1);
            this.grpConnection.Controls.Add(this.tbAddress);
            this.grpConnection.Location = new System.Drawing.Point(12, 12);
            this.grpConnection.Name = "grpConnection";
            this.grpConnection.Size = new System.Drawing.Size(227, 151);
            this.grpConnection.TabIndex = 0;
            this.grpConnection.TabStop = false;
            this.grpConnection.Text = "Connection";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(6, 122);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(64, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnect.Location = new System.Drawing.Point(76, 122);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(145, 23);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "&Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Username:";
            // 
            // tbPassword
            // 
            this.tbPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPassword.Location = new System.Drawing.Point(76, 97);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(145, 20);
            this.tbPassword.TabIndex = 3;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // tbUsername
            // 
            this.tbUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUsername.Location = new System.Drawing.Point(76, 71);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(145, 20);
            this.tbUsername.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port:";
            // 
            // numPort
            // 
            this.numPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numPort.Location = new System.Drawing.Point(76, 45);
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
            this.numPort.Size = new System.Drawing.Size(83, 20);
            this.numPort.TabIndex = 1;
            this.numPort.Value = new decimal(new int[] {
            6500,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Address:";
            // 
            // tbAddress
            // 
            this.tbAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAddress.Location = new System.Drawing.Point(76, 19);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(145, 20);
            this.tbAddress.TabIndex = 0;
            this.tbAddress.Text = "lightbringer.furcadia.com";
            // 
            // grpInfo
            // 
            this.grpInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpInfo.Controls.Add(this.stRunning);
            this.grpInfo.Controls.Add(this.stTribble);
            this.grpInfo.Controls.Add(this.stHorton);
            this.grpInfo.Controls.Add(this.stHeimdall);
            this.grpInfo.Controls.Add(this.label7);
            this.grpInfo.Controls.Add(this.txtPhase);
            this.grpInfo.Controls.Add(this.txtHeimdallId);
            this.grpInfo.Controls.Add(this.label6);
            this.grpInfo.Controls.Add(this.label5);
            this.grpInfo.Location = new System.Drawing.Point(244, 12);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(178, 151);
            this.grpInfo.TabIndex = 1;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Info";
            // 
            // stRunning
            // 
            this.stRunning.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.stRunning.BackColor = System.Drawing.Color.Transparent;
            this.stRunning.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stRunning.Location = new System.Drawing.Point(6, 97);
            this.stRunning.Name = "stRunning";
            this.stRunning.Size = new System.Drawing.Size(80, 43);
            this.stRunning.TabIndex = 8;
            this.stRunning.Text = "Running";
            this.stRunning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stTribble
            // 
            this.stTribble.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.stTribble.BackColor = System.Drawing.Color.Yellow;
            this.stTribble.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stTribble.Location = new System.Drawing.Point(92, 122);
            this.stTribble.Name = "stTribble";
            this.stTribble.Size = new System.Drawing.Size(80, 18);
            this.stTribble.TabIndex = 7;
            this.stTribble.Text = "Tribble";
            this.stTribble.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stHorton
            // 
            this.stHorton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.stHorton.BackColor = System.Drawing.Color.Yellow;
            this.stHorton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stHorton.Location = new System.Drawing.Point(92, 97);
            this.stHorton.Name = "stHorton";
            this.stHorton.Size = new System.Drawing.Size(80, 18);
            this.stHorton.TabIndex = 6;
            this.stHorton.Text = "Horton";
            this.stHorton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stHeimdall
            // 
            this.stHeimdall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.stHeimdall.BackColor = System.Drawing.Color.Yellow;
            this.stHeimdall.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stHeimdall.Location = new System.Drawing.Point(92, 73);
            this.stHeimdall.Name = "stHeimdall";
            this.stHeimdall.Size = new System.Drawing.Size(80, 18);
            this.stHeimdall.TabIndex = 5;
            this.stHeimdall.Text = "Heimdall";
            this.stHeimdall.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Status:";
            // 
            // txtPhase
            // 
            this.txtPhase.AutoSize = true;
            this.txtPhase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhase.Location = new System.Drawing.Point(76, 22);
            this.txtPhase.Name = "txtPhase";
            this.txtPhase.Size = new System.Drawing.Size(30, 13);
            this.txtPhase.TabIndex = 3;
            this.txtPhase.Text = "N/A";
            // 
            // txtHeimdallId
            // 
            this.txtHeimdallId.AutoSize = true;
            this.txtHeimdallId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeimdallId.Location = new System.Drawing.Point(76, 47);
            this.txtHeimdallId.Name = "txtHeimdallId";
            this.txtHeimdallId.Size = new System.Drawing.Size(30, 13);
            this.txtHeimdallId.TabIndex = 2;
            this.txtHeimdallId.Text = "N/A";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Heimdall ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Phase:";
            // 
            // tbData
            // 
            this.tbData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbData.Location = new System.Drawing.Point(12, 169);
            this.tbData.Multiline = true;
            this.tbData.Name = "tbData";
            this.tbData.ReadOnly = true;
            this.tbData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbData.Size = new System.Drawing.Size(410, 81);
            this.tbData.TabIndex = 2;
            // 
            // refreshTimer
            // 
            this.refreshTimer.Tick += new System.EventHandler(this.refreshTimer_Tick);
            // 
            // DebugForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 262);
            this.Controls.Add(this.tbData);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.grpConnection);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(450, 300);
            this.MinimumSize = new System.Drawing.Size(450, 300);
            this.Name = "DebugForm";
            this.Text = "HeimdallCheck Class Diagnostics";
            this.Load += new System.EventHandler(this.DebugForm_Load);
            this.grpConnection.ResumeLayout(false);
            this.grpConnection.PerformLayout();
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpConnection;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.Label stRunning;
        private System.Windows.Forms.Label stTribble;
        private System.Windows.Forms.Label stHorton;
        private System.Windows.Forms.Label stHeimdall;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label txtPhase;
        private System.Windows.Forms.Label txtHeimdallId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbData;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Timer refreshTimer;
    }
}