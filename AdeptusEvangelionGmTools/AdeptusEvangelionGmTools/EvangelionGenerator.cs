using System;
using AdeptusEvangelionGmTools.Objects;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdeptusEvangelionGmTools
{
    public partial class EvangelionGenerator : Form
    {
        #region Properties
        #endregion

        #region Events
        public EvangelionGenerator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Evangelion evangelion = new Evangelion();

        }
        #endregion

        #region PrivateMethods
        private void verifyRandoms()
        {

        }
        #endregion
    }
}
