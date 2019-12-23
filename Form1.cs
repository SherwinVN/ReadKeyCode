using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ReadKeyCode
{
    public partial class frmReadKeyCode : Form
    {
        public frmReadKeyCode()
        {
            InitializeComponent();
        }

        private void frmReadKeyCode_KeyUp(object sender, KeyEventArgs e)
        {
            txtKeyPlus.Text = "";
            txtKeyCode.Text = e.KeyCode.ToString();
            txtKeyData.Text = e.KeyData.ToString();
            txtKeyValue.Text = e.KeyValue.ToString();
            if (e.Control)
                txtKeyPlus.Text += "CTRL +  ";
            if (e.Alt)
                txtKeyPlus.Text += "ALT + ";
            if (e.Shift)
                txtKeyPlus.Text += "SHIFT + ";
        }

        private void frmReadKeyCode_Load(object sender, EventArgs e)
        {

        }
    }
}
