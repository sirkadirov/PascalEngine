using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LevelEditor
{
    public partial class lineControl : UserControl
    {
        public lineControl()
        {
            InitializeComponent();
        }

        private void lineControl_Load(object sender, EventArgs e)
        {

        }

        private void textBox64_Enter(object sender, EventArgs e)
        {
            try
            {
                ParentForm.Controls.Find("controlsPanel", true)[0].Enabled = true;
            }
            catch { }
        }

        private void textBox61_Leave(object sender, EventArgs e)
        {
            try
            {
                ParentForm.Controls.Find("controlsPanel", true)[0].Enabled = false;
            }
            catch { }
        }
    }
}
