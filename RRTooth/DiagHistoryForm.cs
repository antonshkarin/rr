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
    public partial class DiagHistoryForm : Form
    {
        public DiagHistoryForm()
        {
            InitializeComponent();
        }

        public DiagHistoryForm(rr_history history)
        {
            InitializeComponent();
            label1.Text = history.last_name + " " + history.first_name + " " + history.second_name;

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            var estimation = serializer.Deserialize<DiagnosticCard>(history.info);

            {
                DataGridViewRow r = new DataGridViewRow();
                r.CreateCells(dataGridView1, new Object[] {
                              "Индекс гигиены",
                              estimation.HygieneIndex });
                dataGridView1.Rows.Add(r);
            }

            {
                string s = "";
                switch(estimation.VizualToothColor)
                {
                    case VizualToothColorType.Depulped:
                        s = "Зуб депульпирован и эмаль зуба имеет цвет от серого до розового";
                        break;
                    case VizualToothColorType.Equal:
                        s = "Цвет совпадает с цветом соотв. интактного зуба на противоположной стороне";
                        break;
                    case VizualToothColorType.Periodontitis:
                        s = "При обследовании поставлен диагноз - периодонтит";
                        break;
                }


                DataGridViewRow r = new DataGridViewRow();
                r.CreateCells(dataGridView1, new Object[] {
                          "Цвет зуба: визуальный метод",
                          s });
                dataGridView1.Rows.Add(r);
            }

            {
                string s = "";
                switch (estimation.InstrumentalToothColor)
                {
                    case InstrumentalToothColorType.Equal:
                        s = "Цвет совпадает с цветом соотв. интактного зуба на противоположной стороне";
                        break;
                    case InstrumentalToothColorType.NotEqual:
                        s = "Цвет не совпадает с цветом соотв. интактного зуба на противоположной стороне";
                        break;
                    case InstrumentalToothColorType.NotEqualVizual:
                        s = "Цвет при визуальной и аппаратурной оценках не совпадает между собой";
                        break;
                }
                DataGridViewRow r = new DataGridViewRow();
                r.CreateCells(dataGridView1, new Object[] {
                          "Цвет зуба: аппаратурный метод",
                          s });
                dataGridView1.Rows.Add(r);
            }

            {
                string s = "";
                switch (estimation.PresenceOfFissures)
                {
                    case FissureType.Type1:
                        s = "Трещины I типа";
                        break;
                    case FissureType.Type2:
                        s = "Трещины II типа";
                        break;
                    case FissureType.Type3:
                        s = "Трещины III типа";
                        break;
                }
                DataGridViewRow r = new DataGridViewRow();
                r.CreateCells(dataGridView1, new Object[] {
                          "Наличие трещин",
                          s });
                dataGridView1.Rows.Add(r);
            }

            {
                DataGridViewRow r = new DataGridViewRow();
                r.CreateCells(dataGridView1, new Object[] {
                            "Уровень резистентности эмали",
                             estimation.ResistanceEnamelLevel });
                dataGridView1.Rows.Add(r);
            }

            {
                string s = "";
                switch (estimation.ToothCrownDestructionIndex)
                {
                    case ToothCrownDestructionIndexType.Class3and4and5_more_than_60_percents:
                        s = "Кариозный процесс по 3, 4, 5 классам";
                        break;
                    case ToothCrownDestructionIndexType.Class5_30percents:
                        s = "Кариозный процесс по 5 классу";
                        break;
                    case ToothCrownDestructionIndexType.Class5and6_Class_3and4_60_percents:
                        s = "Кариозный процесс по 5 и 6 классу, по 3 и 4 классу";
                        break;
                }
                DataGridViewRow r = new DataGridViewRow();
                r.CreateCells(dataGridView1, new Object[] {
                            "Индекс разрушения коронки зуба",
                            s });
                dataGridView1.Rows.Add(r);
            }

            {
                string s = "";
                switch (estimation.Bite)
                {
                    case BiteType.Deep:
                        s = "Глубокое резцовое перекрытие";
                        break;
                    case BiteType.Open:
                        s = "Ортогнатический, открытый, прогения";
                        break;
                    case BiteType.Other:
                        s = "Прикус любого другого вида";
                        break;
                }
                DataGridViewRow r = new DataGridViewRow();
                r.CreateCells(dataGridView1, new Object[] {
                            "Прикус",
                            s });
                dataGridView1.Rows.Add(r);
            }

            {
                string s = "";
                switch (estimation.PeriodontalDisease)
                {
                    case PeriodontalDiseaseType.Healthy:
                        s = "Здоровый пародонт";
                        break;
                    case PeriodontalDiseaseType.Low:
                        s = "Заболевания пародонта легкой степени тяжести";
                        break;
                    case PeriodontalDiseaseType.Medium:
                        s = "Заболевания пародонта средней степени тяжести";
                        break;
                }

                DataGridViewRow r = new DataGridViewRow();
                r.CreateCells(dataGridView1, new Object[] {
                            "Наличие заболеваний пародонта (только хронический процесс)",
                            s });
                dataGridView1.Rows.Add(r);
            }

            {
                string s = "";
                switch (estimation.BadHabits)
                {
                    case BadHabitsType.AnyBiting:
                        s = "Имеется вредная привычка грызть семечки, ручку, ногти";
                        break;
                    case BadHabitsType.No:
                        s = "Отсутствуют вредные привычки";
                        break;
                    case BadHabitsType.Other:
                        s = "Имеются другие вредные привычки";
                        break;
                }
                
                DataGridViewRow r = new DataGridViewRow();
                r.CreateCells(dataGridView1, new Object[] {
                            "Вредные привычки",
                            s });
                dataGridView1.Rows.Add(r);
            }

            {
                string s = "";
                switch (estimation.OccupationalInsalubrity)
                {
                    case OccupationalInsalubrityType.No:
                        s = "Нет профессиональных вредностей";
                        break;
                    case OccupationalInsalubrityType.Other:
                        s = "Хим. производство, кондитерское производство, спорт";
                        break;
                    case OccupationalInsalubrityType.WithoutPhysicalStresses:
                        s = "Производство без физических нагрузок";
                        break;
                }
                DataGridViewRow r = new DataGridViewRow();
                r.CreateCells(dataGridView1, new Object[] {
                            "Профессиональные вредности",
                            s });
                dataGridView1.Rows.Add(r);
            }

            {
                DataGridViewRow r = new DataGridViewRow();
                r.CreateCells(dataGridView1, new Object[] {
                            "Рекомендуемый метод лечения:",
                            estimation.chooseMethod() });
                dataGridView1.Rows.Add(r);
            }
        }
    }
}
