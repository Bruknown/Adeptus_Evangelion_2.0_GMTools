using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdeptusEvangelionGmTools.Objects.BodyParts
{
    public class Head
    {
        #region Properties
        public int Wounds { get; set; }
        public int Armor { get; set; }
        public int CriticalWounds { get; set; }
        public Boolean Destroyed { get; set; }
        #endregion
        #region Constructor
        public Head()
        {
            Wounds = 1;
            Armor = 0;
            CriticalWounds = 0;
            Destroyed = false;
        }
        public Head(int wounds, int armor, int criticalWounds)
        {
            Wounds = wounds;
            Armor = armor;
            CriticalWounds = criticalWounds;
            Destroyed = false;

        }
        #endregion
    }
}
