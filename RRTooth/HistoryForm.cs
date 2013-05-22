using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RRTooth
{
    public partial class HistoryForm : Form
    {
        public HistoryForm()
        {
            InitializeComponent();
        }

        private void HistoryForm_Load(object sender, EventArgs e)
        {
            {
                DataGridViewRow r = new DataGridViewRow();
                DataGridViewTextBoxCell a = new DataGridViewTextBoxCell();
                a.Value = "Иван";
                r.Cells.Add(a);
                DataGridViewTextBoxCell b = new DataGridViewTextBoxCell();
                b.Value = "Иванов";
                r.Cells.Add(b);
                DataGridViewTextBoxCell c = new DataGridViewTextBoxCell();
                c.Value = "Иванович";
                r.Cells.Add(c);
                DataGridViewLinkCell d = new DataGridViewLinkCell();
                d.Value = "Диагностика";
                r.Cells.Add(d);
                dataGridView1.Rows.Add(r);
            }
            {
                DataGridViewRow r = new DataGridViewRow();
                DataGridViewTextBoxCell a = new DataGridViewTextBoxCell();
                a.Value = "Иван";
                r.Cells.Add(a);
                DataGridViewTextBoxCell b = new DataGridViewTextBoxCell();
                b.Value = "Иванов";
                r.Cells.Add(b);
                DataGridViewTextBoxCell c = new DataGridViewTextBoxCell();
                c.Value = "Иванович";
                r.Cells.Add(c);
                DataGridViewLinkCell d = new DataGridViewLinkCell();
                d.Value = "Оценка";
                r.Cells.Add(d);
                dataGridView1.Rows.Add(r);
            } 
        }
    }
}
