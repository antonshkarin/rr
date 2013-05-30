using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RREntities;
using System.Web.Script.Serialization;

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
            if (textBoxLastName.Text.Length > 0 || textBoxFirstName.Text.Length > 0 || textBoxSecondName.Text.Length > 0)
            {
                dataGridView1.Rows.Clear();
                try
                {
                    RrDb db = new RrDb();
                    var finded = db.Find(textBoxLastName.Text, textBoxFirstName.Text, textBoxSecondName.Text);
                    foreach (var historyRow in finded)
                    {
                        DataGridViewRow r = new DataGridViewRow();

                        r.CreateCells(dataGridView1, new Object[] { 
                            historyRow.last_name, 
                            historyRow.first_name,
                            historyRow.second_name,  
                            historyRow.type == (Int64)rr_history.RowType.Diagnostics ? "Диагностика" : "Оценка",
                            historyRow.date.ToShortDateString() });
                        r.Tag = historyRow;
                        dataGridView1.Rows.Add(r);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не удалось выполнить запрос к БД (" + ex.Message + ")", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Необходимо ввести фамилию, имя или отчество пациента", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.dataGridView1.Columns["type"].Index)
            {

                var entry = this.dataGridView1.Rows[e.RowIndex].Tag as rr_history;

                if (entry.type == (Int64)RREntities.rr_history.RowType.Diagnostics)
                {
                    DiagHistoryForm form = new DiagHistoryForm(entry);
                    form.ShowDialog();
                    //var card = serializer.Deserialize<DiagnosticCard>(entry.info);
                }
                else
                {
                    EstimationHistoryForm form = new EstimationHistoryForm(entry);
                    form.ShowDialog();
                    //var estimation = serializer.Deserialize<EstimationCard>(entry.info);
                }
            }
        }
    }
}
