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
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(1, 1);
            string myvideo = @"C:\Users\Hp Elite Book\Desktop\hasan\IMAGE VIDEO FINAL.avi";
            axWindowsMediaPlayer1.URL = myvideo;
            axWindowsMediaPlayer1.Ctlcontrols.play();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(progressBar.Value==100)
            {
                timer1.Stop();
                MainMenu mm = new MainMenu();
                this.Hide();
                mm.ShowDialog();
            }
            else
            {
                progressBar.Increment(1);
                progressBar.BackColor = Color.Gray;
                progressBar.ForeColor = Color.Black;
                label1.Text = progressBar.Value.ToString() + "%";
            }
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }
    }
}
