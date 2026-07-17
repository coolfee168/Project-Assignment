using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjectAssignment
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

            this.MinimumSize = new Size(900, 600);
            this.WindowState = FormWindowState.Normal;

        }
    }
}
