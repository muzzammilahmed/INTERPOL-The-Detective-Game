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
    public partial class Comic : Form
    {
        public Comic()
        {
            InitializeComponent();
        }

        private void Comic_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(1, 1);
            italy.Visible = false;
            investigate.Visible = false;
            lift.Visible = false;
            arrest.Visible = false;
            timer1.Start();
            timer2.Start();
            timer3.Start();
            timer4.Start();
            timer5.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            italy.Visible = true;
            timer1.Stop();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lift.Visible = true;
            timer2.Stop();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            arrest.Visible = true;
            timer3.Stop();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            investigate.Visible = true;
            timer4.Stop();  
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            FinalLevel l3 = new FinalLevel();
            timer5.Stop();
            this.Hide();
            l3.ShowDialog();
        }
    }
}
