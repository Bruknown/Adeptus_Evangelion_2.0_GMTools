using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdeptusEvangelionGmTools.Objects.EvaProperties
{
    public class Soul
    {
        #region properties
        public String Name { get; set; }
        public int Id { get; set; }
        public String Effect { get; set; }
        #endregion
        #region Constructors
        public Soul(String name, int id, String effect)
        {
            Name = name;
            Id = id;
            Effect = effect;
        }
        #endregion
    }
}
