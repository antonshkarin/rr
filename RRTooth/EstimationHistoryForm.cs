﻿using System;
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
    public partial class EstimationHistoryForm : Form
    {
        Bitmap memoryImage;

        public EstimationHistoryForm()
        {
            InitializeComponent();
        }

        public EstimationHistoryForm(rr_history history)
        {
            InitializeComponent();
            label1.Text = history.last_name + " " + history.first_name + " " + history.second_name;

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            var estimation = serializer.Deserialize<EstimationCard>(history.info);

            {
                DataGridViewRow r = new DataGridViewRow();
                r.CreateCells(dataGridView1, new Object[] {
                              "Соответствие формы зуба овалу лица",
                              estimation.СоответствиеФормыЗубаОвалуЛица });
                dataGridView1.Rows.Add(r);
            }

            {
                DataGridViewRow r = new DataGridViewRow();
                r.CreateCells(dataGridView1, new Object[] {
                          "Пропорции соблюдены: достаточная толщина, рельеф, мамелоны",
                          estimation.ПропорцииСоблюдены });
                dataGridView1.Rows.Add(r);
            }

            {
                DataGridViewRow r = new DataGridViewRow();
                r.CreateCells(dataGridView1, new Object[] {
                          "Режущий край (фестончатость)",
                          estimation.РежущийКрайФестончатость });
                dataGridView1.Rows.Add(r);
            }

            {
                DataGridViewRow r = new DataGridViewRow();
                r.CreateCells(dataGridView1, new Object[] {
                          "Краевое прилегание",
                          estimation.КраевоеПрилегание });
                dataGridView1.Rows.Add(r);
            }

            {
                DataGridViewRow r = new DataGridViewRow();
                r.CreateCells(dataGridView1, new Object[] {
                            "Контактный пункт",
                             estimation.КонтактныйПункт });
                dataGridView1.Rows.Add(r);
            }

            {
                DataGridViewRow r = new DataGridViewRow();
                r.CreateCells(dataGridView1, new Object[] {
                            "Соответствие реставрации срединной линии",
                            estimation.СоответствиеРеставрацииСрединнойЛинии });
                dataGridView1.Rows.Add(r);
            }

            {
                DataGridViewRow r = new DataGridViewRow();
                r.CreateCells(dataGridView1, new Object[] {
                            "Соответствие цвета",
                            estimation.СоответствиеЦвета });
                dataGridView1.Rows.Add(r);
            }

            {
                DataGridViewRow r = new DataGridViewRow();
                r.CreateCells(dataGridView1, new Object[] {
                            "Плавность перехода цветов",
                            estimation.ПлавностьПереходаЦветов });
                dataGridView1.Rows.Add(r);
            }

            {
                DataGridViewRow r = new DataGridViewRow();
                r.CreateCells(dataGridView1, new Object[] {
                            "Изменение цвета на границе реставрации с зубом",
                            estimation.ИзменениеЦветаНаГраницеРеставрацииСЗубом });
                dataGridView1.Rows.Add(r);
            }

            {
                DataGridViewRow r = new DataGridViewRow();
                r.CreateCells(dataGridView1, new Object[] {
                            "Режущий край",
                            estimation.РежущийКрай });
                dataGridView1.Rows.Add(r);
            }

            {
                DataGridViewRow r = new DataGridViewRow();
                r.CreateCells(dataGridView1, new Object[] {
                            "Контактные поверхности",
                            estimation.КонтактныеПоверхности });
                dataGridView1.Rows.Add(r);
            }

            {
                DataGridViewRow r = new DataGridViewRow();
                r.CreateCells(dataGridView1, new Object[] {
                            "Отсутствие прозрачности",
                            estimation.ОтсутствиеПрозрачности });
                dataGridView1.Rows.Add(r);
            }

            {
                DataGridViewRow r = new DataGridViewRow();
                r.CreateCells(dataGridView1, new Object[] {
                            "Гладкость поверхности",
                            estimation.ГладкостьПоверхности });
                dataGridView1.Rows.Add(r);
            }

            {
                DataGridViewRow r = new DataGridViewRow();
                r.CreateCells(dataGridView1, new Object[] {
                            "Блеск поверхности - сухой",
                            estimation.БлескПоверхностиСухой });
                dataGridView1.Rows.Add(r);
            }

            {
                DataGridViewRow r = new DataGridViewRow();
                r.CreateCells(dataGridView1, new Object[] {
                            "Блеск поверхности - влажный",
                            estimation.БлескПоверхностиВлажный });
                dataGridView1.Rows.Add(r);
            }

            {
                DataGridViewRow r = new DataGridViewRow();
                r.CreateCells(dataGridView1, new Object[] {
                            "Окклюзионные взаимоотношения",
                            estimation.ОкклюзионныеВзаимоотношения });
                dataGridView1.Rows.Add(r);
            }

            {
                DataGridViewRow r = new DataGridViewRow();
                r.CreateCells(dataGridView1, new Object[] {
                            "Послеоперационная чувствительность",
                            estimation.ПослеоперационнаяЧувствительность });
                dataGridView1.Rows.Add(r);
            }

            {
                DataGridViewRow r = new DataGridViewRow();
                r.CreateCells(dataGridView1, new Object[] {
                            "Дикция",
                            estimation.Дикция });
                dataGridView1.Rows.Add(r);
            }

            {
                DataGridViewRow r = new DataGridViewRow();
                r.CreateCells(dataGridView1, new Object[] {
                            "Состояние пародонта после реставрации",
                            estimation.СостояниеПародонтаПослеРеставрации });
                dataGridView1.Rows.Add(r);
            }

            {
                DataGridViewRow r = new DataGridViewRow();
                r.CreateCells(dataGridView1, new Object[] {
                            "Оценка реставрации пациентом",
                            estimation.ОценкаРеставрацииПациентом });
                dataGridView1.Rows.Add(r);
            }
        }

        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.dataGridView1.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);

            this.dataGridView1.DrawToBitmap(memoryImage, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            CaptureScreen();
            printDialog1.Document = printDocument1;
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.PrinterSettings = printDialog1.PrinterSettings;
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }
    }
}
