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
                case 1:
                    diagnosticCard.PresenceOfFissures = FissureType.Type1;
                    break;
                case 2:
                    diagnosticCard.PresenceOfFissures = FissureType.Type2;
                    break;
                case 3:
                    diagnosticCard.PresenceOfFissures = FissureType.Type3;
                    break;
            }
        }

        private void wizardPageResistanceEname_Commit(object sender, AeroWizard.WizardPageConfirmEventArgs e)
        {
            switch (comboBoxResistanceEname.SelectedIndex)
            {
                case 1:
                    diagnosticCard.ResistanceEnamelLevel = 2;
                    break;
                case 2:
                    diagnosticCard.ResistanceEnamelLevel = 3;
                    break;
                case 3:
                    diagnosticCard.ResistanceEnamelLevel = 4;
                    break;
            }
        }

        private void wizardPageToothCrownDestruction_Commit(object sender, AeroWizard.WizardPageConfirmEventArgs e)
        {
            switch (comboBoxToothCrownDestruction.SelectedIndex)
            {
                case 1:
                    diagnosticCard.ToothCrownDestructionIndex = 2;
                    break;
                case 2:
                    diagnosticCard.ToothCrownDestructionIndex = 3;
                    break;
                case 3:
                    diagnosticCard.ToothCrownDestructionIndex = 4;
                    break;
            }
        }

        private void wizardPageBite_Commit(object sender, AeroWizard.WizardPageConfirmEventArgs e)
        {
            switch (comboBoxBite.SelectedIndex)
            {
                case 1:
                    diagnosticCard.Bite = BiteType.Open;
                    break;
                case 2:
                    diagnosticCard.Bite = BiteType.Deep;
                    break;
                case 3:
                    diagnosticCard.Bite = BiteType.Other;
                    break;
            }
        }

        private void wizardPagePeriodontalDisease_Commit(object sender, AeroWizard.WizardPageConfirmEventArgs e)
        {
            switch (comboBoxPeriodontalDisease.SelectedIndex)
            {
                case 1:
                    diagnosticCard.PeriodontalDisease = PeriodontalDiseaseType.Healthy;
                    break;
                case 2:
                    diagnosticCard.PeriodontalDisease = PeriodontalDiseaseType.Low;
                    break;
                case 3:
                    diagnosticCard.PeriodontalDisease = PeriodontalDiseaseType.Medium;
                    break;
            }
        }

        private void wizardPageBadHabits_Commit(object sender, AeroWizard.WizardPageConfirmEventArgs e)
        {
            switch (comboBoxBadHabits.SelectedIndex)
            {
                case 1:
                    diagnosticCard.BadHabits = BadHabitsType.No;
                    break;
                case 2:
                    diagnosticCard.BadHabits = BadHabitsType.AnyBiting;
                    break;
                case 3:
                    diagnosticCard.BadHabits = BadHabitsType.Other;
                    break;
            }
        }

        private void wizardPageProfessionalHarmfulness_Commit(object sender, AeroWizard.WizardPageConfirmEventArgs e)
        {
            switch (comboBoxProfessionalHarmfulness.SelectedIndex)
            {
                /*case 1:
                    //diagnosticCard.
                    break;
                case 2:
                    diagnosticCard.BadHabits = BadHabitsType.AnyBiting;
                    break;
                case 3:
                    diagnosticCard.BadHabits = BadHabitsType.Other;
                    break;*/
            }
        }
    }
}
