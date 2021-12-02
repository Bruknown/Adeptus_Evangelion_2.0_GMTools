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
        #endregion

        #region Constructor
        public Body(int Toughness, String bodyType)
        {
            switch (bodyType)
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
    }
}
