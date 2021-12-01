using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdeptusEvangelionGmTools.Objects.BodyParts
{
    class Torso
    {
        #region Properties
        int Wounds { get; set; }
        int Armor { get; set; }
        int CriticalWounds { get; set; }
        Boolean Destroyed { get; set; }
        #endregion
        #region Constructor
        public Torso()
        {
            Wounds = 1;
            Armor = 0;
            CriticalWounds = 0;
            Destroyed = false;
        }
        public Torso(int wounds, int armor, int criticalWounds)
        {
            Wounds = wounds;
            Armor = armor;
            CriticalWounds = criticalWounds;
            Destroyed = false;

        }
        #endregion
    }
}
