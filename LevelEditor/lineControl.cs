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

        private void textBox64_Enter(object sender, EventArgs e) { }

        private void textBox61_Leave(object sender, EventArgs e) { }

        private void textBox31_TextChanged(object sender, EventArgs e)
        {
            foreach(TextBox tb in this.Controls)
            {
                switch (tb.Text)
                {
                    case "#":
                        tb.ForeColor = Color.Brown;
                        break;
                    case "@":
                        tb.ForeColor = Color.Orange;
                        break;
                    case "b":
                        tb.ForeColor = Color.DarkRed;
                        break;
                    case "B":
                        tb.ForeColor = Color.Red;
                        break;
                    case "%":
                        tb.ForeColor = Color.DarkRed;
                        break;
                    case "$":
                        tb.ForeColor = Color.Green;
                        break;
                    case "*":
                        tb.ForeColor = Color.Orange;
                        break;
                }
            }
        }
    }
}
