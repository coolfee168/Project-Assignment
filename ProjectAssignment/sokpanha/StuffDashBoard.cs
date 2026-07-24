using ProjectAssignment.sopanha;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjectAssignment.sokpanha
{
    public partial class StuffDashBoard : Form
    {
        public StuffDashBoard()
        {
            InitializeComponent();
        }

        private void Management_Resize(object sender, EventArgs e)
        {

        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            ChangeTopNav(new panelProduct());
        }
        public void OpenChildForm(Form childForm)
        {
            // Close any existing child form
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }
            // Set the new child form's properties
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            // Add the new child form to the panel and show it
            panel1.Controls.Add(childForm);
            panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        public void ChangeTopNav(Form frm)
        {
            panelTop.Controls.Clear();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            panelTop.Controls.Add(frm);
            frm.Show();
            frm.BringToFront();
        }

        private void StuffDashBoard_Load(object sender, EventArgs e)
        {
            

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            OpenChildForm(new staffOrder());
        }
    }
}
