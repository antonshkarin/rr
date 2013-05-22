using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RRTooth
{
    public partial class Form1 : Form
    {

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form wizardForm = new TestForm();
            wizardForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form wizardForm = new EstimationForm();
            wizardForm.ShowDialog();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox1_MouseDown(object sender, EventArgs e)
        {
            Form wizardForm = new TestForm();
            wizardForm.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form wizardForm = new EstimationForm();
            wizardForm.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form historyForm = new HistoryForm();
            historyForm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void closeLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
