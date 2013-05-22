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
    public partial class EstimationForm : Form
    {
        public EstimationForm()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // TODO
                //var row = rr_history.Create<EstimationCard>(this.textBoxFirstName.Text, this.textBoxSecondName.Text, this.textBoxLastName.Text,
                //    DateTime.Now, rr_history.RowType.Diagnostics, diagnosticCard);
                //RrDb db = new RrDb();
                //db.Add(row);

                MessageBox.Show("Данные успешно сохранены", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось сохранить данные: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
