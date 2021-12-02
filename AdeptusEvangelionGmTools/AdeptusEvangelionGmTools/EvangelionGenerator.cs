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
        public Evangelion eva;

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
                SoulSelect.Enabled = false;
            else
                SoulSelect.Enabled = true;
        }

        private void RandMutation_CheckedChanged(object sender, EventArgs e)
        {
            if (RandMutation.Checked)
                MutationSelect.Enabled = false;
            else
                MutationSelect.Enabled = true;
        }

        private void RandConstruction_CheckedChanged(object sender, EventArgs e)
        {
            if (RandConstruction.Checked)
                ConstructionSelect.Enabled = false;
            else
                ConstructionSelect.Enabled = true;
        }

        private void RandHistory_CheckedChanged(object sender, EventArgs e)
        {
            if (RandHistory.Checked)
                HistorySelect.Enabled = false;
            else
                HistorySelect.Enabled = true;
        }

        private void RandColor_CheckedChanged(object sender, EventArgs e)
        {
            if (RandColor.Checked)
            {
                MColor1Select.Enabled = false;
                MColor2Select.Enabled = false;
                SColor1Select.Enabled = false;
                SColor2Select.Enabled = false;
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
            selectedSoul = eva.SoulList.Where(x => x.Name.Equals(SoulSelect.SelectedItem.ToString())).FirstOrDefault();
        }

        private void MutationSelect_TextChanged(object sender, EventArgs e)
        {
            eva = new Evangelion();
            selectedMutation = eva.MutationList.Where(x => x.Name.Equals(MutationSelect.SelectedItem.ToString())).FirstOrDefault();
        }

        private void ConstructionSelect_TextChanged(object sender, EventArgs e)
        {
            eva = new Evangelion();
            selectedConstruction = eva.ConstructionList.Where(x => x.Name.Equals(ConstructionSelect.SelectedItem.ToString())).FirstOrDefault();
        }

        private void HistorySelect_TextChanged(object sender, EventArgs e)
        {
            eva = new Evangelion();
            selectedHistory = eva.HistoryList.Where(x => x.Name.Equals(HistorySelect.SelectedItem.ToString())).FirstOrDefault();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            if ((selectedConstruction == null && !RandConstruction.Checked) ||
                (selectedHistory == null && !RandHistory.Checked) ||
                (selectedMutation == null && !RandMutation.Checked) ||
                (selectedSoul == null && !RandomSoul.Checked))
            {
                string message = "Custom generated fields are not selected";
                string caption = "Error Detected in Evangelion Generation";
                MessageBoxButtons buttons = MessageBoxButtons.OK;

                MessageBox.Show(message, caption, buttons);
                return;
            }

            Evangelion evangelion = new Evangelion(
                RandomSoul.Checked, 
                RandMutation.Checked, 
                RandConstruction.Checked, 
                RandHistory.Checked,
                RandColor.Checked,
                selectedSoul,
                selectedMutation,
                selectedConstruction,
                selectedHistory
                );

            EvangelionOutput.Text = 
                "Evangelion Unit " + rand.Next(0, 101) + Environment.NewLine +
                "Soul: " + evangelion.Soul + Environment.NewLine +
                "Mutation(s): " + String.Join(", ", evangelion.Mutations.ToArray()) + Environment.NewLine +
                "Construction: " + String.Join(", ", evangelion.Construction.ToArray()) + Environment.NewLine +
                "History: " + evangelion.History + Environment.NewLine +
                "Primary Color: " + evangelion.PrimaryColor + Environment.NewLine +
                "Secondary Color: " + evangelion.SecondaryColor + Environment.NewLine +
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
                "     R.Leg:     " + evangelion.Body.RightLeg.Wounds + "       |   " + evangelion.Body.RightLeg.Armor;
                

        }
        #endregion

        #region PrivateMethods
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
        }

        #endregion

    }
}
