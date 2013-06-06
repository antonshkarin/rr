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
        private List<GroupBox> _estimates;

        public EstimationForm()
        {
            InitializeComponent();

            _estimates = new List<GroupBox>();

            foreach (Control c in tableLayoutPanel1.Controls)
            {
                if (c is GroupBox)
                {
                    _estimates.Add((GroupBox)c);
                    foreach (Control r in c.Controls)
                    {
                        if (r is RadioButton)
                        {
                            ((RadioButton)r).CheckedChanged += estimation_Change;
                        }
                    }
                }
            }
        }

        void estimation_Change(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb != null)
            {
                if (rb.Checked)
                {
                    reCalcEstimation();
                }
            }
        }

        //function 

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            EstimationCard ec = new EstimationCard { 
                        СоответствиеФормыЗубаОвалуЛица = getEstimation(groupBox1),
                        ПропорцииСоблюдены = getEstimation(groupBox2),
                        РежущийКрайФестончатость = getEstimation(groupBox3),
                        КраевоеПрилегание = getEstimation(groupBox4),
                        КонтактныйПункт = getEstimation(groupBox5),
                        СоответствиеРеставрацииСрединнойЛинии = getEstimation(groupBox6),
                        СоответствиеЦвета = getEstimation(groupBox7),
                        ПлавностьПереходаЦветов = getEstimation(groupBox8),
                        ИзменениеЦветаНаГраницеРеставрацииСЗубом = getEstimation(groupBox9),
                        РежущийКрай = getEstimation(groupBox10),
                        КонтактныеПоверхности = getEstimation(groupBox11),
                        ОтсутствиеПрозрачности = getEstimation(groupBox12),
                        ГладкостьПоверхности = getEstimation(groupBox13),
                        БлескПоверхностиСухой = getEstimation(groupBox14),
                        БлескПоверхностиВлажный = getEstimation(groupBox15),
                        ОкклюзионныеВзаимоотношения = getEstimation(groupBox16),
                        ПослеоперационнаяЧувствительность = getEstimation(groupBox17),
                        Дикция = getEstimation(groupBox18),
                        СостояниеПародонтаПослеРеставрации = getEstimation(groupBox19),
                        ОценкаРеставрацииПациентом = getEstimation(groupBox20)
            };
            try
            {
                if (this.textBoxFirstName.Text.Length > 0 && this.textBoxSecondName.Text.Length > 0 && this.textBoxLastName.Text.Length > 0)
                {
                    var row = rr_history.Create<EstimationCard>(this.textBoxFirstName.Text,
                        this.textBoxSecondName.Text, this.textBoxLastName.Text,
                        DateTime.Now, rr_history.RowType.Estimation, ec, dateTimePicker1.Value, CardNum.Text, null);
                    RrDb db = new RrDb();
                    db.Add(row);

                    MessageBox.Show("Данные успешно сохранены", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Необходимо ввести Ф.И.О. пациента", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

        private int getEstimation(GroupBox gb)
        {
            return Convert.ToInt32(
                gb.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text);
        }

        private String reCalcEstimation()
        {
            const String estimationVeryGood = "Отличная реставрация (не требует повтороной реставрации)";
            const String estimationGood = "Хорошая реставрация (требует корректировки, полировки, покрытия реминерализующими средствами)";
            const String estimationNotGood = "Удовлетворительная реставрация (требует частично или полной замены)";
            const String estimationBad = "Неудовлетворительная реставрация (полная замена реставрации)";

            int totalEstimation = 0;
            foreach (var gb in _estimates)
            {
                totalEstimation += Convert.ToInt32(gb.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text);
            }

            if (totalEstimation >= 80)
                return estimationVeryGood;
            else if (totalEstimation >= 60)
                return estimationGood;
            else if (totalEstimation >= 40)
                return estimationNotGood;
            else
                return estimationBad;
        }

        private void showEstimation()
        {

        }
    }
}
