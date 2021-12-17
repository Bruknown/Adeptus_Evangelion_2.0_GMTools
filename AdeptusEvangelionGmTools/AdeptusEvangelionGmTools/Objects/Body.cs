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
            Random rnd = new Random();
            BaseToughness = Toughness;
            BodyType = bodyType;
            switch (BodyType)
            {
                case "Evangelion":
                    Head = new Head(Toughness / 10, 2, 0);
                    Torso = new Torso(Toughness / 10*2+3, 4, 0);
                    LeftArm = new LeftArm((Toughness / 10)+2, 2, 0);
                    RightArm = new RightArm((Toughness / 10) + 2, 2, 0);
                    LeftLeg = new LeftLeg((Toughness / 10) + 2, 2, 0);
                    RightLeg = new RightLeg((Toughness / 10) + 2, 2, 0);
                    break;
                case "Bipedal":
                    Head = new Head((Toughness / 10)-2, 0, 0);
                    LeftArm = new LeftArm(Toughness / 10, 0, 0);
                    RightArm = new RightArm(Toughness / 10, 0, 0);
                    Core = new Core((Toughness / 10) + rnd.Next(1,11), 0, 0);
                    Torso = new Torso((Toughness / 10 * 2) + rnd.Next(1, 6), 0, 0);
                    RightLeg = new RightLeg(Toughness / 10, 0, 0);
                    LeftLeg = new LeftLeg(Toughness / 10, 0, 0);
                    break;
                case "Insectile":
                    if (rnd.Next(1,11) != 8 || rnd.Next(1, 11) != 9 || rnd.Next(1, 11) != 10)
                    {
                        LeftArm = new LeftArm(Toughness / 10, 0, 0);
                        RightArm = new RightArm(Toughness / 10, 0, 0);
                    }
                    Head = new Head((Toughness / 10) - 2, 0, 0);
                    Core = new Core((Toughness / 10) + rnd.Next(1, 11), 0, 0);
                    Torso = new Torso(Toughness / 10 * 2, 0, 0);
                    RightLeg = new RightLeg(Toughness / 10, 0, 0);
                    LeftLeg = new LeftLeg(Toughness / 10, 0, 0);
                    break;
                case "Orbital":
                    Core = new Core((Toughness / 10) + rnd.Next(1, 11), 0, 0);
                    Torso = new Torso((Toughness / 10 * 3) + rnd.Next(1, 11), 0, 0);
                    break;
                case "Bestial":
                    Head = new Head((Toughness / 10) - 2, 0, 0);
                    LeftArm = new LeftArm(Toughness / 10, 0, 0);
                    RightArm = new RightArm(Toughness / 10, 0, 0);
                    Core = new Core((Toughness / 10) + rnd.Next(1, 11), 0, 0);
                    Torso = new Torso((Toughness / 10 * 2) + rnd.Next(1, 6), 0, 0);
                    RightLeg = new RightLeg(Toughness / 10, 0, 0);
                    LeftLeg = new LeftLeg(Toughness / 10, 0, 0);
                    break;
                case "Artificial":
                    if (rnd.Next(1,11) != 7 || rnd.Next(1, 11) != 8 || rnd.Next(1, 11) != 9)
                    {
                        Head = new Head((Toughness / 10) - 2, 0, 0);
                    }
                    Core = new Core((Toughness / 10) + rnd.Next(1, 11), 0, 0);
                    Torso = new Torso((Toughness / 10 * 2) + rnd.Next(1, 6), 0, 0);
                    RightLeg = new RightLeg(Toughness / 10, 0, 0);
                    LeftLeg = new LeftLeg(Toughness / 10, 0, 0);
                    break;
                case "Amorphous":
                    Torso = new Torso((Toughness / 10 * 3) + rnd.Next(1, 11), 0, 0);
                    break;
                case "Pilot":
                    break;
            }
        }
        #endregion

        #region public methods
        public void armorHandling(Head head, Torso torso)
        {

        }
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
