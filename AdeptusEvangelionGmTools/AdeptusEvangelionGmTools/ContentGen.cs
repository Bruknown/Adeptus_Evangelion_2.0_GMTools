using System;
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
    public partial class ContentGen : Form
    {
        public ContentGen()
        {
            InitializeComponent();
        }

        private void EvaGen_Click(object sender, EventArgs e)
        {
            EvangelionGenerator EG = new EvangelionGenerator();
            EG.Show();
        }

        private void AngelGen_Click(object sender, EventArgs e)
        {
            AngelGenerator AG = new AngelGenerator();
            AG.Show();
        }
    }
}
