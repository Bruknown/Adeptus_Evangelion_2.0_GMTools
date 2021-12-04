using AdeptusEvangelionGmTools.Objects;
using AdeptusEvangelionGmTools.Objects.AngelProperties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdeptusEvangelionGmTools
{
    public partial class AngelGenerator : Form
    {
        public AngelGenerator()
        {
            InitializeComponent();
            InitiateComboBox();
        }
        #region Events
        private void GenButton_Click(object sender, EventArgs e)
        {
            verifyEmptyComboBoxes();

        }

        private void SRBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void FelBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void WPBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PerBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void IntBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AgilityBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ToughnessBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void StrengthBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void BSBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void WSBox_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region Private Methods
        private void InitiateComboBox()
        {
            Angel angel = new Angel();
            foreach (BodyType body in angel.ComboBoxBodyType)
            {
                BodyTypeCombo.Items.Add(body.Name);
            }
            foreach (Difficulty diff in angel.ComboBoxDifficulty)
            {
                DifficultyBox.Items.Add(diff.Name);
            }
            foreach (Locomotion Locomo in angel.ComboBoxLocomotion)
            {
                LocomotionCombo.Items.Add(Locomo.Name);
            }
            foreach (BodySize size in angel.ComboBoxSize)
            {
                SizeCombo.Items.Add(size.Name);
            }
            foreach (Specialization special in angel.ComboBoxSpecialization)
            {
                SpecializationCombo.Items.Add(special.Name);
            }
            
        }
        private void verifyEmptyComboBoxes()
        {

        }
        #endregion

    }
}
