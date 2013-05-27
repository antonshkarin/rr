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
                        СоответствиеФормыЗубаОвалуЛица = 2,
                        ПропорцииСоблюдены = 2,
                        РежущийКрайФестончатость = 2,
                        КраевоеПрилегание = 2,
                        КонтактныйПункт = 2,
                        СоответствиеРеставрацииСрединнойЛинии = 2,
                        СоответствиеЦвета = 2,
                        ПлавностьПереходаЦветов = 2,
                        ИзменениеЦветаНаГраницеРеставрацииСЗубом = 2,
                        РежущийКрай = 2,
                        КонтактныеПоверхности = 2,
                        ОтсутствиеПрозрачности = 2,
                        ГладкостьПоверхности = 2,
                        БлескПоверхностиСухой = 2,
                        БлескПоверхностиВлажный = 2,
                        ОкклюзионныеВзаимоотношения = 2,
                        ПослеоперационнаяЧувствительность = 2,
                        Дикция = 2,
                        СостояниеПародонтаПослеРеставрации = 2,
                        ОценкаРеставрацииПациентом = 2
            };
            try
            {
                var row = rr_history.Create<EstimationCard>(/*this.textBoxFirstName.Text*/ "",
                    /*this.textBoxSecondName.Text*/ "", /*this.textBoxLastName.Text*/ "",
                    DateTime.Now, rr_history.RowType.Estimation, ec);
                RrDb db = new RrDb();
                db.Add(row);

                MessageBox.Show("Данные успешно сохранены", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
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

        private void radioButton84_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
