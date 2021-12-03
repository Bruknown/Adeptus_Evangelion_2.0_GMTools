using AdeptusEvangelionGmTools.Objects.BodyParts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdeptusEvangelionGmTools.Objects
{
    public class Body
    {
        #region Properties
        public Head Head;
        public Torso Torso;
        public LeftArm LeftArm;
        public RightArm RightArm;
        public LeftLeg LeftLeg;
        public RightLeg RightLeg;
        public Core Core;
        public int BaseToughness;
        public String BodyType;
        #endregion

        #region Constructor
        public Body(int Toughness, String bodyType)
        {
            BaseToughness = Toughness;
            BodyType = bodyType;
            switch (BodyType)
            {
                case "Evangelion":
                    Head = new Head(Toughness / 10, 2, 0);
                    Torso = new Torso((Toughness / 10)*2+3, 4, 0);
                    LeftArm = new LeftArm((Toughness / 10)+2, 2, 0);
                    RightArm = new RightArm((Toughness / 10) + 2, 2, 0);
                    LeftLeg = new LeftLeg((Toughness / 10) + 2, 2, 0);
                    RightLeg = new RightLeg((Toughness / 10) + 2, 2, 0);
                    break;
                case "Angel":
                    break;
                case "Pilot":
                    break;
            }
        }
        #endregion
        #region public methods
        public void woundIncrease(String BodyType, int mod)
        {
            switch (BodyType)
            {
                case "Evangelion":
                    Head.Wounds += mod;
                    Torso.Wounds += mod;
                    LeftArm.Wounds += mod;
                    LeftLeg.Wounds += mod;
                    RightArm.Wounds += mod;
                    RightLeg.Wounds += mod;
                    break;
                case "Angel":
                    break;
                case "Pilot":
                    break;
            }
        }
        public void armorIncrease(String BodyType, int mod)
        {
            switch (BodyType)
            {
                case "Evangelion":
                    Head.Armor += mod;
                    Torso.Armor += mod;
                    LeftArm.Armor += mod;
                    LeftLeg.Armor += mod;
                    RightArm.Armor += mod;
                    RightLeg.Armor += mod;
                    break;
                case "Angel":
                    break;
                case "Pilot":
                    break;
            }
        }
        #endregion
    }
}
