using System;
using System.Windows.Forms;

namespace SimpleCode
{

    public partial class Menu : Form
    {

        public Menu()
        {
            InitializeComponent();
        }

        private void BStartGame_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            Hide();
            
        }
        public void Exit()
        {
            Application.Exit();
        }
        private void BExit_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void BHelp_Click(object sender, EventArgs e)
        {
            HelpMenu frm1 = new HelpMenu();
            frm1.Show();
            Hide();
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Exit();
        }
    }
}
