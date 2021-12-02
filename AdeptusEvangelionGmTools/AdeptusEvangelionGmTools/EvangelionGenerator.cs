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

namespace AdeptusEvangelionGmTools
{
    public partial class EvangelionGenerator : Form
    {
        #region Properties
        #endregion

        #region Events
        public EvangelionGenerator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            Evangelion evangelion = new Evangelion(
                RandomSoul.Checked, 
                RandMutation.Checked, 
                RandConstruction.Checked, 
                RandHistory.Checked,
                RandColor.Checked);

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
        private void verifyRandoms()
        {

        }
        #endregion
    }
}
