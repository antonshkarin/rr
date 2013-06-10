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
            this.MaximumSize = this.MinimumSize = this.Size;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            DrawBorder();
        }

        private void DrawBorder()
        {
            Pen myPen = new Pen(Color.Maroon);
            myPen.Width = 2;
            Point[] points = { new Point(0, 0), 
                               new Point(this.Width, 0), 
                               new Point(this.Width, this.Height),
                               new Point(0, this.Height),
                               new Point(0, 0) };
            var g = this.CreateGraphics();
            g.DrawLines(myPen, points);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form wizardForm = new TestForm();
            wizardForm.ShowDialog();
        }

        private void closeLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form wizardForm = new EstimationForm();
            wizardForm.ShowDialog();
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

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form methodForm = new MethodForm();
            methodForm.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form historyForm = new HistoryForm();
            historyForm.ShowDialog();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form wizardForm = new TestForm();
            wizardForm.ShowDialog();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form methodForm = new MethodForm();
            methodForm.ShowDialog();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form estimationForm = new EstimationForm();
            estimationForm.ShowDialog();
        }
    }
}
