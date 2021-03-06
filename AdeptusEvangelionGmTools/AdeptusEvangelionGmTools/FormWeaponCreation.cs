using AdeptusEvangelionGmTools.Objects;
using AdeptusEvangelionGmTools.Objects.Weapons;
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
    public partial class FormWeaponCreation : Form
    {
        #region Attributes
        public AngelGenerator angelGen { get; set; }
        List<String> WeaponTypes { get; set; }
        List<String> WeaponProperties { get; set; }
        List<String> WeaponDamageDice { get; set; }
        List<String> WeaponDamageType { get; set; }
        int penetration { get; set; }
        int damageBonus1 { get; set; }
        int damageBonus2 { get; set; }
        String weaponDamage1 { get; set; }
        String weaponDamage2 { get; set; }
        AngelAttack angelAttack { get; set; }
        int chosenWeaponSlot { get; set; }
        #endregion

        #region Constructors
        public FormWeaponCreation(AngelGenerator chosenAngel, int weaponSlot)
        {
            InitializeComponent();
            initiateCombobox();
            angelGen = chosenAngel;
            chosenWeaponSlot = weaponSlot;
        }

        #endregion

        #region Events
        private void button2_Click(object sender, EventArgs e)
        {
            String Name;
            String WeaponType;
            String DamageOne;
            String DamageTypeOne;
            String DamageTwo;
            String DamageTypeTwo;
            String WeaponProperty;
            int Penetration;
            bool ATPenetration;

            if (WeaponPropertyCombo.SelectedItem != null && WeaponTypeCombo.SelectedItem != null && typeOfDiceOneCombo.SelectedItem != null && diceQuantityOne.Value > 0 && WeaponDamageTypeOneCombo.SelectedItem != null)
            {
                Name = weaponName.Text;
                WeaponType = WeaponTypeCombo.SelectedItem.ToString();
                DamageOne = diceQuantityOne.Value + typeOfDiceOneCombo.SelectedItem.ToString() + " + " + damageBonusOne.Value;
                DamageTypeOne = WeaponDamageTypeOneCombo.SelectedItem.ToString();
                Penetration = decimalToInt(WeaponPenetration.Value);
                ATPenetration = AtPen.Checked;
                WeaponProperty = WeaponPropertyCombo.SelectedItem.ToString();

                richTextBox1.Text = "Name: " + Name + Environment.NewLine +
                                "Weapon Type: " + WeaponType + Environment.NewLine +
                                "Weapon Property: " + WeaponProperty + Environment.NewLine +
                                "Weapon Damage 1: " + DamageOne + " Damage Type: " + DamageTypeOne + Environment.NewLine;
                if (typeOfDiceTwoCombo.SelectedItem != null && diceQuantityTwo.Value > 0 && WeaponDamageTypeTwoCombo.SelectedItem != null)
                {
                    DamageTwo = diceQuantityTwo.Value + typeOfDiceTwoCombo.SelectedItem.ToString() + " + " + damageBonusTwo.Value;
                    DamageTypeTwo = WeaponDamageTypeTwoCombo.SelectedItem.ToString();
                    richTextBox1.Text += "Weapon Damage 2: " + DamageTwo + " Damage Type: " + DamageTypeTwo + Environment.NewLine;
                    richTextBox1.Text += "Penetration: " + Penetration + Environment.NewLine +
                        "A.T Penetration: " + ATPenetration.ToString();
                    angelAttack = new AngelAttack(chosenWeaponSlot, Name, WeaponType, DamageOne, DamageTypeOne, DamageTwo, DamageTypeTwo, Penetration, ATPenetration);
                }
                else
                {
                    richTextBox1.Text += "Penetration: " + Penetration + Environment.NewLine +
                        "A.T Penetration: " + ATPenetration.ToString();
                    angelAttack = new AngelAttack(chosenWeaponSlot, Name, WeaponType, DamageOne, DamageTypeOne, Penetration, ATPenetration);
                }
            }
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != null)
            {
                angelGen.setAttacks(angelAttack, richTextBox1.Text, chosenWeaponSlot);
            }
        }
        private void WeaponTypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (WeaponTypeCombo.SelectedItem.ToString())
            {
                case "Melee":
                    break;
                case "Ranged":
                    break;
                case "AT Power":
                    break; 
            }
        }
        #endregion

        #region Private Methods
        private void initiateCombobox()
        {
            WeaponDamageType = new List<String> { "Impact", "Energy", "Explosive", "Rending" };
            WeaponTypes = new List<String> { "Melee", "Ranged", "A.T Power" };
            WeaponProperties = new List<String> { "Unbalanced", "Power Field", "Flexible", "Tearing", "Innacurate", "Toxic", "Blast()", "Scatter" };
            WeaponDamageDice = new List<String> { "d5", "d10", "d12", "d16", "d20", "d100" };

            WeaponTypeCombo.Items.AddRange(WeaponTypes.ToArray());
            WeaponPropertyCombo.Items.AddRange(WeaponProperties.ToArray());
            WeaponDamageTypeOneCombo.Items.AddRange(WeaponDamageType.ToArray());
            WeaponDamageTypeTwoCombo.Items.AddRange(WeaponDamageType.ToArray());
            typeOfDiceOneCombo.Items.AddRange(WeaponDamageDice.ToArray());
            typeOfDiceTwoCombo.Items.AddRange(WeaponDamageDice.ToArray());

        }
        private int decimalToInt(decimal dec)
        {
            return Convert.ToInt32(dec);
        }
        #endregion

    }
}
