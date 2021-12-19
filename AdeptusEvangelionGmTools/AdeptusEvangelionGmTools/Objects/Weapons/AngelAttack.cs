using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdeptusEvangelionGmTools.Objects.Weapons
{
    public class AngelAttack
    {

        public String Name { get; set; }
        public String WeaponType { get; set; }
        public String DamageOne { get; set; }
        public String DamageTypeOne { get; set; }
        public String DamageTwo { get; set; }
        public String DamageTypeTwo { get; set; }
        public int Penetration { get; set; }
        public bool ATPenetration { get; set; }
        public int WeaponIndex { get; set; }
        public AngelAttack(int weaponIndex, string name, string weaponType, string damageOne, string damageTypeOne, int penetration, bool aTPenetration)
        {
            WeaponIndex = weaponIndex;
            Name = name;
            WeaponType = weaponType;
            DamageOne = damageOne;
            DamageTypeOne = damageTypeOne;
            Penetration = penetration;
            ATPenetration = aTPenetration;
        }

        public AngelAttack(int weaponIndex, string name, string weaponType, string damageOne, string damageTypeOne, string damageTwo, string damageTypeTwo, int penetration, bool aTPenetration)
        {
            WeaponIndex = weaponIndex;
            Name = name;
            WeaponType = weaponType;
            DamageOne = damageOne;
            DamageTypeOne = damageTypeOne;
            DamageTwo = damageTwo;
            DamageTypeTwo = damageTypeTwo;
            Penetration = penetration;
            ATPenetration = aTPenetration;
        }


    }
}
