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

        public LevelEditorMainWindow()
        {
            InitializeComponent();
        }

        enum EntityType
        {
            wall,
            spawnpoint,
            money,
            xp,
            water,
            bot_horizontal,
            bot_vertical,
            bot_advanced,
            easteregg_money
        }

        private void OpenLevel(string fileName)
        {
            try
            {
                this.Opacity = 0.5;
                mapEditor.Controls.Clear();
                string[] levelLines = File.ReadAllLines(fileName, Encoding.UTF8);
                levelFileName = fileName.ToString();
                int maxLineSize = 59;
                if (maxLineSize != 59)
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
        
        private bool AddEntityToMap(EntityType type)
        {
            switch (type)
            {
                case EntityType.wall:
                    
                    break;
                case EntityType.spawnpoint:

                    break;
                case EntityType.money:

                    break;
                case EntityType.xp:

                    break;
                case EntityType.water:

                    break;
                case EntityType.bot_horizontal:

                    break;
                case EntityType.bot_vertical:

                    break;
                case EntityType.bot_advanced:

                    break;
                case EntityType.easteregg_money:

                    break;
            }
            return true;
        }
        
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutWnd aboutWnd = new AboutWnd();
            aboutWnd.ShowDialog(this);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Creating a new map
            NewMapWizard newMapWiz = new NewMapWizard();
            if(newMapWiz.ShowDialog(this) != DialogResult.Cancel)
            {
                MessageBox.Show("Success!");
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
    }
}
