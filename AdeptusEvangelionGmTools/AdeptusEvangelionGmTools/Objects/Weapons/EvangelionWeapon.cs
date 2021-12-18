using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdeptusEvangelionGmTools.Objects.Weapons
{
    public class EvangelionWeapon
    {
        public String Name { get; set; }
        public String Description { get; set; }
        public String SkillRequired { get; set; }
        public String Damage { get; set; }
        public String DamageType { get; set; }
        public String Penetration { get; set; }
        public String Properties { get; set; }
        public EvangelionWeapon(string name, string description, string skillRequired, string damage, string damageType, string penetration, string properties)
        {
            Name = name;
            Description = description;
            SkillRequired = skillRequired;
            Damage = damage;
            DamageType = damageType;
            Penetration = penetration;
            Properties = properties;
        }

    }
}
