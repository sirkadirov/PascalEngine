using System.Windows.Forms;
using System.Diagnostics;

namespace LevelEditor
{
    public partial class AboutWnd : Form
    {
        public AboutWnd()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("http://sirkadirov.com"));
        }
    }
}
