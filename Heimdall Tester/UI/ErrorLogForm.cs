using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Heimdall_Tester
{
    public partial class ErrorLogForm : Form
    {
        public ErrorLogForm(string[] errors)
        {
            InitializeComponent();
            
            string errorsBuffer = "";
            foreach (string error in errors)
                errorsBuffer += error + Environment.NewLine;
            tbErrorLog.Text = errorsBuffer;
        }

        private void ErrorLogForm_Load(object sender, EventArgs e)
        {
            // ???
        }
    }
}
