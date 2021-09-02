using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace INTERPOL_The_Detective_Game
{
    public partial class CaseClosed : Form
    {
        WMPLib.WindowsMediaPlayer bgmusic = new WMPLib.WindowsMediaPlayer();
        public int ObStars1 { get; set; }
        public int ObStars2 { get; set; }
        public int ObStars3 { get; set; }

        public string DetectiveName { get; set; }

        int avg;
        public CaseClosed()
        {
            InitializeComponent();
        }

        
        /*public CaseClosed(string detective_name)
        {
            InitializeComponent();
            dn = detective_name.ToString();
            
        }*/
        

        private void BackToMain_Click(object sender, EventArgs e)
        {
            Console.Beep();
            MainMenu m = new MainMenu();
            bgmusic.controls.stop();
            this.Hide();
            m.ShowDialog();
        }

        private void CaseClosed_Load(object sender, EventArgs e)
        {
            
            avg = ((ObStars1 + ObStars2 + ObStars3) / 3);

            bgmusic.URL = "levels sound.mp3";
            bgmusic.settings.setMode("loop", true);
            bgmusic.controls.play();
            
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(1, 1);
            GoldMedal.Visible = false;
            SilverMedal.Visible = false;
            BronzeMedal.Visible = false;
            BackToMain.Cursor = Cursors.Hand;

            if (avg <=2 )
            {
                BronzeMedal.Visible = true;
                congo.ForeColor = Color.Brown;
                congo.Text = "CONGRATULATION!!" + Environment.NewLine + " YOU HAVE BEEN REWARDED WITH A BRONZE MEDAL" ;
            }

            else if (avg>2 && avg<=3)
            {
                SilverMedal.Visible = true;
                congo.ForeColor = Color.Silver;
                congo.Text = "CONGRATULATION!!"+Environment.NewLine+" YOU HAVE BEEN REWARDED WITH A SILVER MEDAL";
            }

            else
            {
                GoldMedal.Visible = true;
                congo.ForeColor = Color.Gold;
                congo.Text = "CONGRATULATION!!" + Environment.NewLine + " YOU HAVE BEEN REWARDED WITH A GOLD MEDAL";
            }
        }

        private void CaseClosed_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
