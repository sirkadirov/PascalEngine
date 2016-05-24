using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace LevelEditor
{
    public partial class LevelEditorMainWindow : Form
    {
        public static string levelFileName = null;
        public static TextBox tmpActiveTB;
        public static int width = 40;

        public LevelEditorMainWindow()
        {
            InitializeComponent();
        }

        private void OpenLevel(string fileName)
        {
            try
            {
                this.Opacity = 0.5;
                mapEditor.Controls.Clear();
                string[] levelLines = File.ReadAllLines(fileName, Encoding.UTF8);
                levelFileName = fileName.ToString();
                int maxLineSize = 40;
                if (maxLineSize != 40)
                    throw new Exception("Lines in opened file is too short or too big. Their required size is 59 characters.");
                foreach(string str in levelLines)
                {
                    lineControl lCtrl = new lineControl();
                    mapEditor.Controls.Add(lCtrl);
                    for (int i = 0; i < str.Length; i++)
                        lCtrl.Controls[str.Length-i-1].Text = str[i].ToString();
                }
                this.Opacity = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception");
                Application.Restart();
            }
        }

        private void SaveLevel()
        {
            try
            {
                this.Opacity = 0.5;
                string[] allLines = new string[mapEditor.Controls.Count];
                int num = 0;
                foreach (lineControl ctrl in mapEditor.Controls)
                {
                    for (int i = 39; i >= 0; i--)
                        allLines[num] += ctrl.Controls[i].Text;
                    num++;
                }
                File.WriteAllLines(levelFileName, allLines);
                this.Opacity = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "FATAL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Application.Restart();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutWnd aboutWnd = new AboutWnd();
            aboutWnd.ShowDialog(this);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Creating a new map
            try
            {
                NewMapWizard newMapWiz = new NewMapWizard();
                if (newMapWiz.ShowDialog(this) != DialogResult.Cancel)
                {
                    string[] allLines = new string[Convert.ToInt32(newMapWiz.mapHeight.Value)];
                    for (int i = 0; i <= Convert.ToInt32(newMapWiz.mapHeight.Value-1); i++)
                        allLines[i] = "                                        ";
                    File.WriteAllLines(newMapWiz.mapName.Text + ".lvl", allLines);
                    OpenLevel(newMapWiz.mapName.Text + ".lvl");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "EXCEPTION CATCHED!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Application.Restart();
            }
        }

        private void LevelEditorMainWindow_Load(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult openResult = levelOpenDialog.ShowDialog(this);
            if(openResult != DialogResult.Cancel)
            {
                OpenLevel(levelOpenDialog.FileName);
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.5;
            mapEditor.Controls.Clear();
            levelFileName = null;
            this.Opacity = 1;
        }

        private void clearMapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(lineControl ctrl in mapEditor.Controls)
                foreach (TextBox tb in ctrl.Controls)
                    tb.Text = " ";
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveLevel();
        }
    }
}
