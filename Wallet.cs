using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INTERPOL_The_Detective_Game
{
    public partial class Wallet : Form
    {
        public Wallet()
        {
            InitializeComponent();
        }
        private void Wallet_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(1, 1);
        }

        private void Finish_Click(object sender, EventArgs e)
        {
            MainMenu m = new MainMenu();
            Console.Beep();
            this.Hide();
            m.ShowDialog();
        }

        private void Continue_Click(object sender, EventArgs e)
        {
            Level2 l2 = new Level2();
            Console.Beep();
            this.Hide();
            l2.ShowDialog();
        }

        private void Wallet_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        
    }
}
