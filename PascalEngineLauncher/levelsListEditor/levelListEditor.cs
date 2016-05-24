using System;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace PascalEngineLauncher
{
    public partial class levelListEditor : Form
    {
        public levelListEditor()
        {
            InitializeComponent();
        }

        private void levelListEditor_Load(object sender, EventArgs e)
        {
            try
            {
                string[] levelsArr = File.ReadAllLines("levels.dat", Encoding.UTF8);
                levelsList.Items.AddRange(levelsArr);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "An error occured: levels lis file is not found in the main directory!", "CRITICAL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (levelsList.SelectedItems.Count > 0)
                levelsList.Items.Remove(levelsList.SelectedItem);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addLvlItemWnd addLvlWnd = new addLvlItemWnd();
            DialogResult lvlAddRes = addLvlWnd.ShowDialog(this);
            if (lvlAddRes == DialogResult.OK && addLvlWnd.lvlName.Text != null)
                levelsList.Items.Add(addLvlWnd.lvlName.Text);
        }
    }
}
