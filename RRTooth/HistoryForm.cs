using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RREntities;

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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RrDb db = new RrDb();
            var finded = db.Find(textBoxLastName.Text);
            foreach (var historyRow in finded)
            {
                DataGridViewRow r = new DataGridViewRow();

                r.CreateCells(dataGridView1, new Object[] { 
                    historyRow.first_name, 
                    historyRow.second_name, 
                    historyRow.last_name, 
                    historyRow.type == (Int64)rr_history.RowType.Diagnostics ? "Диагностика" : "Оценка",
                    historyRow.date.ToShortDateString() });
                dataGridView1.Rows.Add(r);
            }

        }
    }
}
