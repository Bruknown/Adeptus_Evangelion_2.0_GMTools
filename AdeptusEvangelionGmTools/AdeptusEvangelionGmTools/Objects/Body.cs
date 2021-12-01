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
        Head Head;
        Torso Torso;
        LeftArm LeftArm;
        RightArm RightArm;
        LeftLeg LeftLeg;
        RightLeg RightLeg;
        Core Core;
        #endregion

        #region Constructor
        public Body(int Toughness, String bodyType)
        {
            switch (bodyType)
            {
                case "Evangelion":
                    Head = new Head(Toughness / 10, 2, 0);
                    Torso = new Torso(Toughness / 10, 4, 0);
                    LeftArm = new LeftArm(Toughness / 10, 2, 0);
                    RightArm = new RightArm(Toughness / 10, 2, 0);
                    LeftLeg = new LeftLeg(Toughness / 10, 2, 0);
                    RightLeg = new RightLeg(Toughness / 10, 2, 0);
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
