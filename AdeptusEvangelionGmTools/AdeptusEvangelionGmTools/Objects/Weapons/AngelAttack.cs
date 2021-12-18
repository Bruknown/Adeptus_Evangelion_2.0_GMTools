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
        public String Description { get; set; }
        public String SkillRequired { get; set; }
        public List<String> Damage { get; set; }
        public List<String> DamageType { get; set; }
        public String Penetration { get; set; }
        public String Properties { get; set; }

        public AngelAttack(string name, string description, string skillRequired, List<string> damage, List<string> damageType, string penetration, string properties)
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
