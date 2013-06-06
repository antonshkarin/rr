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
                if (this.textBoxLastName.Text.Length == 0 || this.textBoxFirstName.Text.Length == 0 || this.textBoxSecondName.Text.Length == 0 || this.textBoxCardNumber.Text.Length == 0)
                {
                    MessageBox.Show("Не заполнены обязательные поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var row = rr_history.Create<EstimationCard>(this.textBoxFirstName.Text,
                        this.textBoxSecondName.Text, this.textBoxLastName.Text,
                        dateTimeCreating.Value, rr_history.RowType.Estimation, ec, dateTimeBirthday.Value, textBoxCardNumber.Text, null);
                    RrDb db = new RrDb();
                    db.Add(row);

                    MessageBox.Show("Данные успешно сохранены", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
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
    }
}
