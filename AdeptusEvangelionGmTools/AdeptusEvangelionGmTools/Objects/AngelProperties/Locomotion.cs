using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdeptusEvangelionGmTools.Objects.AngelProperties
{
    public class Locomotion
    {
        public String Name { get; set; }
        public String Effect { get; set; }
        public Locomotion(string name, string effect)
        {
            Name = name;
            Effect = effect;
        }

    }
}
