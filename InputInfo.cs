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
    public partial class IputInfo : Form
    {
        WMPLib.WindowsMediaPlayer bgmusic = new WMPLib.WindowsMediaPlayer();

        CaseClosed cc = new CaseClosed();
        public IputInfo()
        {
            InitializeComponent();
        }

        string name="";
        private void INPUTInfo_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(1, 1);

            bgmusic.URL = "levels sound.mp3";
            bgmusic.settings.setMode("loop", true);
            bgmusic.controls.play();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Console.Beep();
            if(textBox1.Text=="")
            {
                MessageBox.Show("Error! Please Enter Any Alias Name!");
            }
            else
            {
                name = textBox1.Text;
                cc.DetectiveName = name;
                Case c = new Case();
                bgmusic.controls.stop();
                this.Hide();
                c.ShowDialog();
            }
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Console.Beep();
            MainMenu mm = new MainMenu();
            this.Hide();
            mm.ShowDialog();
        }

        private void IputInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        
    }
}
