using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdeptusEvangelionGmTools.Objects.AngelProperties
{
    public class BodyType
    {

        public String Name { get; set; }
        public String Effect { get; set; }
        public BodyType(string name, string effect)
        {
            Name = name;
            Effect = effect;
        }
    }
}
