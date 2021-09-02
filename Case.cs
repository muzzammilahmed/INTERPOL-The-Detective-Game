using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication4;
using WMPLib;

namespace INTERPOL_The_Detective_Game
{
    public partial class Case : Form
    {
        WMPLib.WindowsMediaPlayer bgmusic = new WMPLib.WindowsMediaPlayer();
        
        public Case()
        {
            InitializeComponent();
        }
        private void Case_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(1, 1);
            Continue.Cursor = Cursors.Hand;
            bgmusic.URL = "levels sound.mp3";
            bgmusic.settings.setMode("loop", true);
            bgmusic.controls.play();

        }

        private void Continue_Click(object sender, EventArgs e)
        {
            Console.Beep();
            Level1 form = new Level1();
            bgmusic.controls.stop();
            this.Hide();
            form.ShowDialog();

        }

        private void Case_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        
    }
}
