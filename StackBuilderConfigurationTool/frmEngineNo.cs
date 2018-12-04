using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StackBuilderConfigurationTool
{
    public partial class frmEngineNo : Form
    {

        public int engineNo;

        public frmEngineNo(string config, string tab, string sceneCode, int engine)
        {
            InitializeComponent();

            engineNo = engine;
            lblConfig.Text = config;
            lblTab.Text = tab;
            lblSceneCode.Text = sceneCode;
            numericUpDown1.Value = engineNo;
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            engineNo = (int) numericUpDown1.Value;
        }
    }
}
