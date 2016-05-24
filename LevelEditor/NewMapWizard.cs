using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LevelEditor
{
    public partial class NewMapWizard : Form
    {
        public static string levelName = null;
        public NewMapWizard()
        {
            InitializeComponent();
        }

        private void wizard_Cancel(object sender, CancelEventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure do you want to exit this wizard? All data you entered will be deleted!", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2);
            if (res == DialogResult.No)
                e.Cancel = true;
            else
                e.Cancel = false;
        }
    }
}
