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
    public partial class MethodForm : Form
    {
        public MethodForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxLastName.Text.Length > 0 || textBoxFirstName.Text.Length > 0 || textBoxSecondName.Text.Length > 0)
            {
                dataGridView1.Rows.Clear();
                try
                {
                    RrDb db = new RrDb();
                    var finded = db.Find(textBoxLastName.Text, textBoxFirstName.Text, textBoxSecondName.Text, (int)rr_history.RowType.Diagnostics);
                    foreach (var historyRow in finded)
                    {
                        JavaScriptSerializer serializer = new JavaScriptSerializer();
                        var estimation = serializer.Deserialize<DiagnosticCard>(historyRow.info);
                        

                        DataGridViewRow r = new DataGridViewRow();

                        r.CreateCells(dataGridView1, new Object[] { 
                            historyRow.last_name, 
                            historyRow.first_name,
                            historyRow.second_name,
                            historyRow.birthday.Value.ToShortDateString(),
                            estimation.chooseMethod() });
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
    }
}
