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
    public partial class Diary : Form
    {
        public Diary()
        {
            InitializeComponent();
        }

        private void Diary_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(1, 1);
            retry.Cursor = Cursors.Hand;
            Continue.Cursor = Cursors.Hand;
        }

        private void Continue_Click(object sender, EventArgs e)
        {
            Comic com = new Comic();
            Console.Beep();
            this.Hide();
            com.ShowDialog();
        }


        private void Finish_Click(object sender, EventArgs e)
        {
            Level2 l2 = new Level2();
            Console.Beep();
            this.Hide();
            l2.ShowDialog();
        }

        private void Diary_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
