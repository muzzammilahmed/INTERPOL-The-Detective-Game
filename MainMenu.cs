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
    public partial class MainMenu : Form
    {
        WMPLib.WindowsMediaPlayer bgmusic = new WMPLib.WindowsMediaPlayer();
        ScoreSheet ss = new ScoreSheet();
        
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Icon icon = Icon.ExtractAssociatedIcon("C:\\Users\\Hp Elite Book\\Desktop\\devil.ico");
            //this.Icon = icon; 
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(1, 1);
            play.Cursor = Cursors.Hand;
            Score.Cursor = Cursors.Hand;
            exit.Cursor = Cursors.Hand;
            playsound.Cursor = Cursors.Hand;
            stopsound.Cursor = Cursors.Hand;
            bgmusic.URL = "levels sound.mp3";
            bgmusic.settings.setMode("loop", true);
            bgmusic.controls.play();
   
        }


        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            
        }


        private void Score_Click(object sender, EventArgs e)
        {
            Console.Beep();
            this.Hide();
            ss.ShowDialog();

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Console.Beep();
            System.Environment.Exit(1);
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Play_Click(object sender, EventArgs e)
        {
            Console.Beep();
            IputInfo form2 = new IputInfo();
            bgmusic.controls.stop();
            this.Hide();
            form2.ShowDialog();
        }

        private void Mute_Click(object sender, EventArgs e)
        {
            bgmusic.controls.pause();
        }

        private void PlayMusic_Click(object sender, EventArgs e)
        {
            bgmusic.controls.play();
             
        }
    }
}
