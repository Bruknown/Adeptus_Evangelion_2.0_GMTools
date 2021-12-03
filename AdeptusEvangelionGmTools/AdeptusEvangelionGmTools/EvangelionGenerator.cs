using System;
using AdeptusEvangelionGmTools.Objects;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdeptusEvangelionGmTools.Objects.EvaProperties;

namespace AdeptusEvangelionGmTools
{
    public partial class EvangelionGenerator : Form
    {
        #region Properties
        public Soul selectedSoul { get; set; }
        public Mutation selectedMutation { get; set; }
        public Construction selectedConstruction { get; set; }
        public History selectedHistory { get; set; }
        public String selectedColor1 { get; set; }
        public String selectedColor2 { get; set; }
        public String selectedColorDescription1 { get; set; }
        public String selectedColorDescription2 { get; set; }
        public Evangelion eva;
        Random rand = new Random();

        #endregion

        #region Events
        public EvangelionGenerator()
        {
            InitializeComponent();
            initiateComboBox();
        }
        private void RandomSoul_CheckedChanged(object sender, EventArgs e)
        {
            if (RandomSoul.Checked)
            {
                SoulSelect.SelectedItem = null;
                SoulSelect.Enabled = false;
                selectedSoul = null;
            }
            else
            {
                SoulSelect.Enabled = true;
            }
        }

        private void RandMutation_CheckedChanged(object sender, EventArgs e)
        {
            if (RandMutation.Checked)
            {
                MutationSelect.Enabled = false;
                MutationSelect.SelectedItem = null;
                selectedMutation = null;
            }
            else
            {
                MutationSelect.Enabled = true;
            }
        }

        private void RandConstruction_CheckedChanged(object sender, EventArgs e)
        {
            if (RandConstruction.Checked)
            {
                ConstructionSelect.Enabled = false;
                ConstructionSelect.SelectedItem = null;
                selectedConstruction = null;
            }
            else
            {
                ConstructionSelect.Enabled = true;
            }
        }

        private void RandHistory_CheckedChanged(object sender, EventArgs e)
        {
            if (RandHistory.Checked)
            {
                HistorySelect.Enabled = false;
                HistorySelect.SelectedItem = null;
                selectedHistory = null;
            }
            else
            {
                HistorySelect.Enabled = true;
            }
        }

        private void RandColor_CheckedChanged(object sender, EventArgs e)
        {
            if (RandColor.Checked)
            {
                MColor1Select.Enabled = false;
                MColor2Select.Enabled = false;
                SColor1Select.Enabled = false;
                SColor2Select.Enabled = false;
                MColor1Select.SelectedItem = null;
                MColor2Select.SelectedItem = null;
                SColor1Select.SelectedItem = null;
                SColor2Select.SelectedItem = null;
            }
            else
            {
                MColor1Select.Enabled = true;
                MColor2Select.Enabled = true;
                SColor1Select.Enabled = true;
                SColor2Select.Enabled = true;
            }
        }

        private void SoulSelect_TextChanged(object sender, EventArgs e)
        {
            eva = new Evangelion();
            if (SoulSelect.SelectedItem != null)
                selectedSoul = eva.SoulList.Where(x => x.Name.Equals(SoulSelect.SelectedItem.ToString())).FirstOrDefault();
        }

        private void MutationSelect_TextChanged(object sender, EventArgs e)
        {
            eva = new Evangelion();
            if (MutationSelect.SelectedItem != null)
                selectedMutation = eva.MutationList.Where(x => x.Name.Equals(MutationSelect.SelectedItem.ToString())).FirstOrDefault();
        }

        private void ConstructionSelect_TextChanged(object sender, EventArgs e)
        {
            eva = new Evangelion();
            if (ConstructionSelect.SelectedItem != null)
                selectedConstruction = eva.ConstructionList.Where(x => x.Name.Equals(ConstructionSelect.SelectedItem.ToString())).FirstOrDefault();
        }

        private void HistorySelect_TextChanged(object sender, EventArgs e)
        {
            eva = new Evangelion();
            if (HistorySelect.SelectedItem != null)
                selectedHistory = eva.HistoryList.Where(x => x.Name.Equals(HistorySelect.SelectedItem.ToString())).FirstOrDefault();
        }

        private void MColor1Select_TextChanged(object sender, EventArgs e)
        {
            if (MColor1Select.SelectedItem != null)
                selectedColorDescription1 = MColor1Select.Text;
        }

        private void MColor2Select_TextChanged(object sender, EventArgs e)
        {
            if (MColor1Select.SelectedItem != null)
                selectedColor1 = MColor2Select.Text;
        }

        private void SColor1Select_TextChanged(object sender, EventArgs e)
        {
            if (SColor1Select.SelectedItem != null)
                selectedColorDescription2 = SColor1Select.Text;
        }

        private void SColor2Select_TextChanged(object sender, EventArgs e)
        {
            if (SColor1Select.SelectedItem != null)
                selectedColor2 = SColor2Select.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            verifyEmptyComboBoxes();

            Evangelion evangelion = new Evangelion(
                selectedSoul,
                selectedMutation,
                selectedConstruction,
                selectedHistory,
                selectedColorDescription1 + selectedColor1,
                selectedColorDescription2 + selectedColor2
                );
            displayText(evangelion);
        }
        #endregion

        #region PrivateMethods
        private void verifyEmptyComboBoxes()
        {
            if ((selectedConstruction == null && !RandConstruction.Checked) ||
                (selectedHistory == null && !RandHistory.Checked) ||
                (selectedMutation == null && !RandMutation.Checked) ||
                (selectedSoul == null && !RandomSoul.Checked) ||
                (selectedColor1 == null || selectedColor2 == null ||
                selectedColorDescription1 == null || selectedColorDescription2 == null)
                && !RandColor.Checked)
            {
                string message = "Custom generated fields are not selected";
                string caption = "Error Detected in Evangelion Generation";
                MessageBoxButtons buttons = MessageBoxButtons.OK;

                MessageBox.Show(message, caption, buttons);
                return;
            }
        }
        private void displayText(Evangelion evangelion)
        {
            String mutationOutput = "";
            String constructionOutput = "";
            foreach(Mutation mutation in evangelion.Mutations)
            {
                mutationOutput += mutation.Name + ", ";
            }
            foreach (Construction construction in evangelion.Construction)
            {
                constructionOutput += construction.Name + ", ";
            }
            EvangelionOutput.Text =
                "Evangelion Unit " + rand.Next(0, 101) + Environment.NewLine +
                "Soul: " + evangelion.Soul.Name + Environment.NewLine +
                "Mutation(s): " + mutationOutput + Environment.NewLine +
                "Construction: " + constructionOutput + Environment.NewLine +
                "History: " + evangelion.History.Name + Environment.NewLine +
                "Primary Color: " + evangelion.primaryColor + Environment.NewLine +
                "Secondary Color: " + evangelion.secondaryColor + Environment.NewLine +
                "Strength: " + evangelion.Strength + Environment.NewLine +
                "Toughness: " + evangelion.Toughness + Environment.NewLine +
                "Agility: " + evangelion.Agility + Environment.NewLine +
                "Operational Time: " + evangelion.OperationalTime + Environment.NewLine +
                "-------------------------------" + Environment.NewLine +
                "Body Part|Wounds|Armor" + Environment.NewLine +
                "      Head:     " + evangelion.Body.Head.Wounds + "       |   " + evangelion.Body.Head.Armor + Environment.NewLine +
                "     Torso:     " + evangelion.Body.Torso.Wounds + "       |   " + evangelion.Body.Torso.Armor + Environment.NewLine +
                "     L.Arm:     " + evangelion.Body.LeftArm.Wounds + "       |   " + evangelion.Body.LeftArm.Armor + Environment.NewLine +
                "     R.Arm:     " + evangelion.Body.RightArm.Wounds + "       |   " + evangelion.Body.RightArm.Armor + Environment.NewLine +
                "     L.Leg:     " + evangelion.Body.LeftLeg.Wounds + "       |   " + evangelion.Body.LeftLeg.Armor + Environment.NewLine +
                "     R.Leg:     " + evangelion.Body.RightLeg.Wounds + "       |   " + evangelion.Body.RightLeg.Armor + Environment.NewLine +
                "---------Soul Effects----------" + Environment.NewLine +
                "Soul Name: " + evangelion.Soul.Name + Environment.NewLine +
                "Soul Effect: " + evangelion.Soul.Effect  + Environment.NewLine +
                "--------Mutation Effects-------" + Environment.NewLine;
            foreach (Mutation mutation in evangelion.Mutations)
            {
                EvangelionOutput.Text +=
                    "Mutation Name: " + mutation.Name + Environment.NewLine +
                    "Mutation Effect: " + Environment.NewLine +
                    mutation.Effect + Environment.NewLine +
                    "-------------------------------" + Environment.NewLine;
            }
            EvangelionOutput.Text += 
                "-----Construction Effects------" + Environment.NewLine;
            foreach (Construction construction in evangelion.Construction)
            {
                EvangelionOutput.Text +=
                    "Mutation Name: " + construction.Name + Environment.NewLine +
                    "Mutation Effect: " + Environment.NewLine +
                    construction.Effect + Environment.NewLine +
                    "-------------------------------" + Environment.NewLine;
            }
            EvangelionOutput.Text +=
              "---------History Effects--------" + Environment.NewLine +
                "History Name: " + evangelion.History.Name + Environment.NewLine +
                "History Effect: " + evangelion.History.Effect + Environment.NewLine;

        }
        private void initiateComboBox()
        {
            Evangelion evangelion = new Evangelion();
            foreach (Soul soul in evangelion.SoulList)
            {
                SoulSelect.Items.Add(soul.Name);
            }
            foreach (Mutation mutation in evangelion.MutationList)
            {
                MutationSelect.Items.Add(mutation.Name);
            }
            foreach (Construction construction in evangelion.ConstructionList)
            {
                ConstructionSelect.Items.Add(construction.Name);
            }
            foreach (History history in evangelion.HistoryList)
            {
                HistorySelect.Items.Add(history.Name);
            }
            foreach(String colorDescription in evangelion.ColorDescription)
            {
                MColor1Select.Items.Add(colorDescription);
                SColor1Select.Items.Add(colorDescription);
            }
            foreach(String mainColor in evangelion.MainColor)
            {
                MColor2Select.Items.Add(mainColor);
                SColor2Select.Items.Add(mainColor);
            }
        }

        #endregion

    }
}
