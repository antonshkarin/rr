using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RREntities;

namespace RRTooth
{
    public partial class TestForm : Form
    {
        private DiagnosticCard diagnosticCard;
        public TestForm()
        {
            InitializeComponent();
            diagnosticCard = new DiagnosticCard();
        }

        private void wizardControl1_SelectedPageChanged(object sender, EventArgs e)
        {

        }

        private void wizardPage2_Initialize(object sender, AeroWizard.WizardPageInitEventArgs e)
        {
            labelDescToothColor.Text = Properties.Resources.DescToothColor;
            comboBoxToothColorVisual.SelectedIndex = 0;
            comboBoxToothColorInstrumental.SelectedIndex = 0;
        }

        private void wizardPageHygieneIndex_Initialize(object sender, AeroWizard.WizardPageInitEventArgs e)
        {
            labelDescHygieneIndex.Text = Properties.Resources.DescHygieneIndex;
        }

        private void wizardPageFissure_Initialize(object sender, AeroWizard.WizardPageInitEventArgs e)
        {
            labelDescFissure.Text = Properties.Resources.DescFissure;
            comboBoxFissure.SelectedIndex = 0;
        }

        private void wizardPageResistanceEname_Initialize(object sender, AeroWizard.WizardPageInitEventArgs e)
        {
            labelDescResistanceEname.Text = Properties.Resources.DescResistanceEname;
            comboBoxResistanceEname.SelectedIndex = 0;
        }

        private void wizardPageToothCrownDestruction_Initialize(object sender, AeroWizard.WizardPageInitEventArgs e)
        {
            labelDescToothCrownDestruction.Text = Properties.Resources.DescToothCrownDestruction;
            comboBoxToothCrownDestruction.SelectedIndex = 0;
        }

        private void wizardPageHygieneIndex_Commit(object sender, AeroWizard.WizardPageConfirmEventArgs e)
        {
            try
            {

                if (textBoxHygieneIndex.Text.Length == 0)
                {
                    MessageBox.Show("Значение не должно быть пустым", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                    return;
                }

                double b = Convert.ToDouble(textBoxHygieneIndex.Text);
                if (b < 0 || b > 6)
                {
                    MessageBox.Show("Значение должно быть в диапазоне от 0 до 6 баллов", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                    return;
                }
                diagnosticCard.HygieneIndex = b;
            }
            catch
            {
                MessageBox.Show("Введено некорректное значение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
                return;
            }
        }

        private void wizardPageBite_Initialize(object sender, AeroWizard.WizardPageInitEventArgs e)
        {
            comboBoxBite.SelectedIndex = 0;
        }

        private void wizardPagePeriodontalDisease_Initialize(object sender, AeroWizard.WizardPageInitEventArgs e)
        {
            comboBoxPeriodontalDisease.SelectedIndex = 0;
        }

        private void wizardPageBadHabits_Initialize(object sender, AeroWizard.WizardPageInitEventArgs e)
        {
            comboBoxBadHabits.SelectedIndex = 0;
        }

        private void wizardPageFissure_Commit(object sender, AeroWizard.WizardPageConfirmEventArgs e)
        {
            switch (comboBoxFissure.SelectedIndex)
            {
                case 0:
                    diagnosticCard.PresenceOfFissures = FissureType.Type1;
                    break;
                case 1:
                    diagnosticCard.PresenceOfFissures = FissureType.Type2;
                    break;
                case 2:
                    diagnosticCard.PresenceOfFissures = FissureType.Type3;
                    break;
            }
        }

        private void wizardPageResistanceEname_Commit(object sender, AeroWizard.WizardPageConfirmEventArgs e)
        {
            switch (comboBoxResistanceEname.SelectedIndex)
            {
                case 0:
                    diagnosticCard.ResistanceEnamelLevel = 75;
                    break;
                case 1:
                    diagnosticCard.ResistanceEnamelLevel = 35;
                    break;
                case 2:
                    diagnosticCard.ResistanceEnamelLevel = 15;
                    break;
            }
        }

        private void wizardPageToothCrownDestruction_Commit(object sender, AeroWizard.WizardPageConfirmEventArgs e)
        {
            switch (comboBoxToothCrownDestruction.SelectedIndex)
            {
                case 0:
                    diagnosticCard.ToothCrownDestructionIndex = ToothCrownDestructionIndexType.Class5_30percents;
                    break;
                case 1:
                    diagnosticCard.ToothCrownDestructionIndex = ToothCrownDestructionIndexType.Class5and6_Class_3and4_60_percents;
                    break;
                case 2:
                    diagnosticCard.ToothCrownDestructionIndex = ToothCrownDestructionIndexType.Class3and4and5_more_than_60_percents;
                    break;
            }
        }

        private void wizardPageBite_Commit(object sender, AeroWizard.WizardPageConfirmEventArgs e)
        {
            switch (comboBoxBite.SelectedIndex)
            {
                case 0:
                    diagnosticCard.Bite = BiteType.Open;
                    break;
                case 1:
                    diagnosticCard.Bite = BiteType.Deep;
                    break;
                case 2:
                    diagnosticCard.Bite = BiteType.Other;
                    break;
            }
        }

        private void wizardPagePeriodontalDisease_Commit(object sender, AeroWizard.WizardPageConfirmEventArgs e)
        {
            switch (comboBoxPeriodontalDisease.SelectedIndex)
            {
                case 0:
                    diagnosticCard.PeriodontalDisease = PeriodontalDiseaseType.Healthy;
                    break;
                case 1:
                    diagnosticCard.PeriodontalDisease = PeriodontalDiseaseType.Low;
                    break;
                case 2:
                    diagnosticCard.PeriodontalDisease = PeriodontalDiseaseType.Medium;
                    break;
            }
        }

        private void wizardPageBadHabits_Commit(object sender, AeroWizard.WizardPageConfirmEventArgs e)
        {
            switch (comboBoxBadHabits.SelectedIndex)
            {
                case 0:
                    diagnosticCard.BadHabits = BadHabitsType.No;
                    break;
                case 1:
                    diagnosticCard.BadHabits = BadHabitsType.AnyBiting;
                    break;
                case 2:
                    diagnosticCard.BadHabits = BadHabitsType.Other;
                    break;
            }
        }

        private void wizardPageProfessionalHarmfulness_Commit(object sender, AeroWizard.WizardPageConfirmEventArgs e)
        {
            switch (comboBoxProfessionalHarmfulness.SelectedIndex)
            {
                case 0:
                    diagnosticCard.OccupationalInsalubrity = OccupationalInsalubrityType.No;
                    break;
                case 1:
                    diagnosticCard.OccupationalInsalubrity = OccupationalInsalubrityType.WithoutPhysicalStresses;
                    break;
                case 2:
                    diagnosticCard.OccupationalInsalubrity = OccupationalInsalubrityType.Other;
                    break;
            }
        }

        private void wizardPage10_Initialize(object sender, AeroWizard.WizardPageInitEventArgs e)
        {
            labelMethod.Text = diagnosticCard.chooseMethod();
        }

        private void wizardPage10_Commit(object sender, AeroWizard.WizardPageConfirmEventArgs e)
        {

        }

        private void wizardPageProfessionalHarmfulness_Initialize(object sender, AeroWizard.WizardPageInitEventArgs e)
        {
            comboBoxProfessionalHarmfulness.SelectedIndex = 0;
        }

        private void labelToothColor_Click(object sender, EventArgs e)
        {

        }

        private void wizardPageToothColor_Commit(object sender, AeroWizard.WizardPageConfirmEventArgs e)
        {
            switch (comboBoxToothColorVisual.SelectedIndex)
            {
                case 0:
                    diagnosticCard.VizualToothColor = VizualToothColorType.Equal;
                    break;
                case 1:
                    diagnosticCard.VizualToothColor = VizualToothColorType.Periodontitis;
                    break;
                case 2:
                    diagnosticCard.VizualToothColor = VizualToothColorType.Depulped;
                    break;
            }

            switch (comboBoxToothColorInstrumental.SelectedIndex)
            {
                case 0:
                    diagnosticCard.InstrumentalToothColor = InstrumentalToothColorType.Equal;
                    break;
                case 1:
                    diagnosticCard.InstrumentalToothColor = InstrumentalToothColorType.NotEqualVizual;
                    break;
                case 2:
                    diagnosticCard.InstrumentalToothColor = InstrumentalToothColorType.NotEqual;
                    break;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (this.textBoxLastName.Text.Length == 0 || this.textBoxFirstName.Text.Length == 0 || this.textBoxSecondName.Text.Length == 0)
                MessageBox.Show("Не заполнены обязательные поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                try
                {
                    var row = rr_history.Create<DiagnosticCard>(this.textBoxFirstName.Text, this.textBoxSecondName.Text, this.textBoxLastName.Text,
                        DateTime.Now, rr_history.RowType.Diagnostics, diagnosticCard);
                    RrDb db = new RrDb();
                    db.Add(row);

                    MessageBox.Show("Данные успешно сохранены", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Не удалось сохранить данные: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
