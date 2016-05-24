using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace PascalEngineLauncher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void openLevelListEditorBtn_Click(object sender, EventArgs e)
        {
            levelListEditor lvlLstEditor = new levelListEditor();
            lvlLstEditor.ShowDialog(this);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AboutWnd aboutWnd = new AboutWnd();
            aboutWnd.ShowDialog(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Website link
        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://sirkadirov.itch.io/pascalengine"));
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://github.com/sirkadirov/PascalEngine/wiki"));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://github.com/sirkadirov/PascalEngine/releases"));
        }

        private void openLevelEditorBtn_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("LevelEditor.exe"));
        }
    }
}
