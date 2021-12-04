using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdeptusEvangelionGmTools.Objects.AngelProperties
{
    class BodySize
    {
        public String Name { get; set; }
        public String Effect { get; set; }
        public BodySize(string name, string effect)
        {
            Name = name;
            Effect = effect;
        }

    }
}
