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
        #region Properties
        BodySize SelectedBodySize { get; set; }
        Difficulty SelectedDifficulty { get; set; }
        BodyType SelectedBodyType { get; set; }
        Locomotion SelectedLocomotion { get; set; }
        Specialization SelectedSpecialization { get; set; }
        #endregion

        #region Events
        public AngelGenerator()
        {
            InitializeComponent();
            InitiateComboBox();
        }
        private void CreateWeaponOne_Click(object sender, EventArgs e)
        {

        }

        private void RandomChkBoxWeaponOne_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void EmptyChkBoxWeaponOne_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CreateWeaponTwo_Click(object sender, EventArgs e)
        {

        }

        private void RandomChkBoxWeaponTwo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void EmptyChkBoxWeaponTwo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void GenButton_Click(object sender, EventArgs e)
        {
            if (verifyEmptyComboBoxes())
            {
                Angel generatedAngel = new Angel(SelectedBodyType, SelectedDifficulty, SelectedLocomotion, SelectedBodySize, SelectedSpecialization,  decimalToInt(BSValue.Value),
                                                 decimalToInt(WSValue.Value), decimalToInt(StrengthValue.Value), decimalToInt(ToughnessValue.Value),
                                                 decimalToInt(AgilityValue.Value), decimalToInt(IntValue.Value), decimalToInt(PerValue.Value),
                                                 decimalToInt(WPValue.Value), decimalToInt(FelValue.Value), decimalToInt(SRValue.Value));
                displayText(generatedAngel);
            }

        }

        private void RandomDifficulty_CheckedChanged(object sender, EventArgs e)
        {
            if (RandomDifficulty.Checked)
            {
                DifficultyBox.SelectedItem = null;
                DifficultyBox.Enabled = false;
                SelectedDifficulty = null;
            }
            else
            {
                DifficultyBox.Enabled = true;
            }
        }

        private void rndSpecializationChkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (rndSpecializationChkBox.Checked)
            {
                SpecializationCombo.SelectedItem = null;
                SpecializationCombo.Enabled = false;
                SelectedSpecialization = null;
            }
            else
            {
                SpecializationCombo.Enabled = true;
            }
        }

        private void rndBodyTypeChkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (rndBodyTypeChkBox.Checked)
            {
                BodyTypeCombo.SelectedItem = null;
                BodyTypeCombo.Enabled = false;
                SelectedSpecialization = null;
            }
            else
            {
                BodyTypeCombo.Enabled = true;
            }
        }

        private void rndLocomotionChkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (rndLocomotionChkBox.Checked)
            {
                LocomotionCombo.SelectedItem = null;
                LocomotionCombo.Enabled = false;
                SelectedLocomotion = null;
            }
            else
            {
                LocomotionCombo.Enabled = true;
            }
        }

        private void rndSizeChkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (rndSizeChkBox.Checked)
            {
                SizeCombo.SelectedItem = null;
                SizeCombo.Enabled = false;
                SelectedBodySize = null;
            }
            else
            {
                SizeCombo.Enabled = true;
            }
        }

        private void RandomWS_CheckedChanged(object sender, EventArgs e)
        {
            if (RandomWS.Checked)
            {
                WSValue.Value = 0;
                WSValue.Enabled = false;
            }
            else
            {
                WSValue.Enabled = true;
            }
        }

        private void RandomBS_CheckedChanged(object sender, EventArgs e)
        {
            if (RandomBS.Checked)
            {
                BSValue.Value = 0;
                BSValue.Enabled = false;
            }
            else
            {
                BSValue.Enabled = true;
            }
        }

        private void RandomStrength_CheckedChanged(object sender, EventArgs e)
        {
            if (RandomStrength.Checked)
            {
                StrengthValue.Value = 0;
                StrengthValue.Enabled = false;
            }
            else
            {
                StrengthValue.Enabled = true;
            }
        }

        private void RandomToughness_CheckedChanged(object sender, EventArgs e)
        {
            if (RandomToughness.Checked)
            {
                ToughnessValue.Value = 0;
                ToughnessValue.Enabled = false;
            }
            else
            {
                ToughnessValue.Enabled = true;
            }
        }

        private void RandomAgility_CheckedChanged(object sender, EventArgs e)
        {
            if (RandomAgility.Checked)
            {
                AgilityValue.Value = 0;
                AgilityValue.Enabled = false;
            }
            else
            {
                AgilityValue.Enabled = true;
            }
        }

        private void RandomInt_CheckedChanged(object sender, EventArgs e)
        {
            if (RandomInt.Checked)
            {
                IntValue.Value = 0;
                IntValue.Enabled = false;
            }
            else
            {
                IntValue.Enabled = true;
            }
        }

        private void RandomPer_CheckedChanged(object sender, EventArgs e)
        {
            if (RandomPer.Checked)
            {
                PerValue.Value = 0;
                PerValue.Enabled = false;
            }
            else
            {
                PerValue.Enabled = true;
            }
        }

        private void RandomWP_CheckedChanged(object sender, EventArgs e)
        {
            if (RandomWP.Checked)
            {
                WPValue.Value = 0;
                WPValue.Enabled = false;
            }
            else
            {
                WPValue.Enabled = true;
            }
        }

        private void RandomFel_CheckedChanged(object sender, EventArgs e)
        {
            if (RandomFel.Checked)
            {
                FelValue.Value = 0;
                FelValue.Enabled = false;
            }
            else
            {
                FelValue.Enabled = true;
            }
        }

        private void RandomSR_CheckedChanged(object sender, EventArgs e)
        {
            if (RandomSR.Checked)
            {
                SRValue.Value = 0;
                SRValue.Enabled = false;
            }
            else
            {
                SRValue.Enabled = true;
            }
        }

        private void DifficultyBox_TextChanged(object sender, EventArgs e)
        {
            Angel angel = new Angel();
            if (DifficultyBox.SelectedItem != null)
            {
                SelectedDifficulty = angel.ComboBoxDifficulty.Where(x => x.Name.Equals(DifficultyBox.SelectedItem.ToString())).FirstOrDefault();
                reloadComboBoxes();
                switch (SelectedDifficulty.Name)
                {
                    case "Introductory":
                        easyIntroHandling();
                        break;
                    case "Easy":
                        easyIntroHandling();
                        break;
                }
            }
        }

        private void SpecializationCombo_TextChanged(object sender, EventArgs e)
        {
            Angel angel = new Angel();
            if (SpecializationCombo.SelectedItem != null)
                SelectedSpecialization = angel.ComboBoxSpecialization.Where(x => x.Name.Equals(SpecializationCombo.SelectedItem.ToString())).FirstOrDefault();
        }

        private void BodyTypeCombo_TextChanged(object sender, EventArgs e)
        {
            Angel angel = new Angel();
            if (BodyTypeCombo.SelectedItem != null)
                SelectedBodyType = angel.ComboBoxBodyType.Where(x => x.Name.Equals(BodyTypeCombo.SelectedItem.ToString())).FirstOrDefault();
        }

        private void LocomotionCombo_TextChanged(object sender, EventArgs e)
        {
            Angel angel = new Angel();
            if (LocomotionCombo.SelectedItem != null)
                SelectedLocomotion = angel.ComboBoxLocomotion.Where(x => x.Name.Equals(LocomotionCombo.SelectedItem.ToString())).FirstOrDefault();
        }

        private void SizeCombo_TextChanged(object sender, EventArgs e)
        {
            Angel angel = new Angel();
            if (SizeCombo.SelectedItem != null)
                SelectedBodySize = angel.ComboBoxSize.Where(x => x.Name.Equals(SizeCombo.SelectedItem.ToString())).FirstOrDefault();
        }
        #endregion

        #region Private Methods
        private void displayText(Angel angel)
        {
            AngelOutPutText.Text =
                "Difficulty: " + angel.difficulty.Name + Environment.NewLine +
                "Specialization: " + angel.specialization.Name + Environment.NewLine +
                "Body Type: " + angel.bodyType.Name + Environment.NewLine +
                "Locomotion: " + angel.locomotion.Name + Environment.NewLine +
                "Size: " + angel.size.Name + Environment.NewLine +
                "Ballistic Skill: " + angel.BallisticSkill + Environment.NewLine +
                "Weapon Skill: " + angel.WeaponSkill + Environment.NewLine +
                "Strength: " + angel.Strength + Environment.NewLine +
                "Toughness: " + angel.Toughness + Environment.NewLine +
                "Agility: " + angel.Agility + Environment.NewLine +
                "Intelligence: " + angel.Intelligence + Environment.NewLine +
                "Perception: " + angel.Perception + Environment.NewLine +
                "Willpower: " + angel.Willpower + Environment.NewLine +
                "Fellowship: " + angel.Fellowship + Environment.NewLine +
                "Synch Ratio: " + angel.SynchRatio + Environment.NewLine +
                "-------------------------------" + Environment.NewLine +
                bodyPrint(angel.body);
        }
        private String bodyPrint(Body body)
        {
            String bodychart = "Body Part|Wounds|Armor" + Environment.NewLine;
            if (body.Head != null)
                bodychart += "      Head:     " + body.Head.Wounds + "       |   " + body.Head.Armor + Environment.NewLine;
            if (body.Torso != null)
                bodychart += "     Torso:     " + body.Torso.Wounds + "       |   " + body.Torso.Armor + Environment.NewLine;
            if (body.Core != null)
                bodychart += "     Core:     " + body.Core.Wounds + "       |   " + body.Core.Armor + Environment.NewLine;
            if (body.LeftArm != null)
                bodychart += "     L.Arm:     " + body.LeftArm.Wounds + "       |   " + body.LeftArm.Armor + Environment.NewLine;
            if (body.RightArm != null)
                bodychart += "     R.Arm:     " + body.RightArm.Wounds + "       |   " + body.RightArm.Armor + Environment.NewLine;
            if (body.LeftLeg != null)
                bodychart += "     L.Leg:     " + body.LeftLeg.Wounds + "       |   " + body.LeftLeg.Armor + Environment.NewLine;
            if (body.RightLeg != null)
                bodychart += "     L.Leg:     " + body.RightLeg.Wounds + "       |   " + body.RightLeg.Armor + Environment.NewLine;
            return bodychart;
        }
        private int decimalToInt(decimal dec)
        {
            return Convert.ToInt32(dec);
        }
        private void InitiateComboBox()
        {
            Angel angel = new Angel();
            foreach (BodyType body in angel.ComboBoxBodyType)
            {
                BodyTypeCombo.Items.Add(body.Name);
            }
            if (DifficultyBox.Items.Count == 0)
            {
                foreach (Difficulty diff in angel.ComboBoxDifficulty)
                {
                    DifficultyBox.Items.Add(diff.Name);
                }
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
        private bool verifyEmptyComboBoxes()
        {
            if ((!rndBodyTypeChkBox.Checked && BodyTypeCombo.SelectedItem == null) ||
                (!rndLocomotionChkBox.Checked && LocomotionCombo.SelectedItem == null) ||
                (!rndSizeChkBox.Checked && SizeCombo.SelectedItem == null) ||
                (!RandomDifficulty.Checked && DifficultyBox.SelectedItem == null) ||
                (!rndSpecializationChkBox.Checked && SpecializationCombo == null))
            {
                string message = "Custom generated fields are not selected";
                string caption = "Error Detected in Angel Generation";
                MessageBoxButtons buttons = MessageBoxButtons.OK;

                MessageBox.Show(message, caption, buttons);
                return false;
            }
            return true;
        }
        private void reloadComboBoxes()
        {
            BodyTypeCombo.Items.Clear();
            LocomotionCombo.Items.Clear();
            SpecializationCombo.Items.Clear();
            SizeCombo.Items.Clear();
            InitiateComboBox();
        }
        private void easyIntroHandling()
        {
            BodyTypeCombo.Items.RemoveAt(2); //orbital
            SpecializationCombo.Items.RemoveAt(2); //encroachment
        }
        #endregion

    }
}
