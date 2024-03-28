using System;
using System.Windows.Forms;

namespace SimpleCode
{
    public partial class HelpMenu : Form
    {
        Menu menu = new Menu();

        public HelpMenu()
        {
            InitializeComponent();
        }

        private void BBackToMenu_Click(object sender, EventArgs e)
        {
            
            Close();
        }

        private void HelpMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            menu.Show();
        }
    }
}
