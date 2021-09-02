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
    public partial class Level2 : Form
    {
        WMPLib.WindowsMediaPlayer bgmusic = new WMPLib.WindowsMediaPlayer();
        System.Timers.Timer t;
        ScoreCard2 sc = new ScoreCard2();
        int seconds = 0;
        DateTime time = DateTime.Parse("00:03:00");

        public Level2()
        {
            InitializeComponent();
        }
        public int count = 0, NumObject = 0;

        private void Level2_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(1, 1);
            bgmusic.URL = "levels sound.mp3";
            bgmusic.settings.setMode("loop", true);
            bgmusic.controls.play();
            CustomMsgBox.Show(" --> Object to be found = 10." + Environment.NewLine + " --> Total time is 3 Minutes." + Environment.NewLine + " --> Wrong click will result in penalty of 10 seconds." + Environment.NewLine + " --> Failure to find all objects within given time will not proceed.", "LEVEL 2 RULES:", "OK");
            object_1.Enabled = false;
            object_2.Enabled = false;
            object_3.Enabled = false;
            object_4.Enabled = false;
            object_5.Enabled = false;
            object_6.Enabled = false;
            object_7.Enabled = false;
            object_8.Enabled = false;
            object_9.Enabled = false;
            object_10.Enabled = false;
            count = 0;
            NumObject = 0;

            t = new System.Timers.Timer();
            t.Interval = 1000;
            t.Elapsed += OnTimerEvent;

            t.Start();
        }
        private void OnTimerEvent(object sender, System.Timers.ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                if (time.Minute == 0 && time.Second == 0)
                {
                    t.Stop();
                    MessageBox.Show("SORRY YOUR TIME IS UP !!");
                    this.Hide();
                    bgmusic.controls.stop();
                    sc.Time = seconds;
                    sc.Score = count;
                    sc.Objects = NumObject;
                    sc.ShowDialog();
                }
                else if (NumObject == 10)
                {
                    t.Stop();
                    MessageBox.Show("You Have Completed this level in " + seconds + " seconds");
                    bgmusic.controls.stop();
                    this.Hide();
                    sc.Time = seconds;
                    sc.Score = count;
                    sc.Objects = NumObject;
                    sc.ShowDialog();
                }
                else
                {
                    time = time.AddSeconds(-1);
                    seconds++;
                }
                Countdown.Text = time.ToString("mm:ss");

            }));
        }

        

          



        private void replay_Click_1(object sender, EventArgs e)
        {
            t.Stop();
            Console.Beep();
            Level2 l2 = new Level2();
            this.Hide();
            l2.ShowDialog();
        }

        private void finish_Click_1(object sender, EventArgs e)
        {
            t.Stop();
            Console.Beep();
            bgmusic.controls.stop();
            this.Hide();
            sc.Time = seconds;
            sc.Score = count;
            sc.Objects = NumObject;
            sc.ShowDialog();
        }

        private void object_Click(object sender, EventArgs e)
        {
            if (sender.GetType().ToString().Equals("System.Windows.Forms.PictureBox"))
            {
                // disable code
                PictureBox picBox = (PictureBox)sender;
                picBox.Visible = false;
                string picIndex = picBox.Name.Split('_')[1];
                TextBox obj_txt = (TextBox)this.Controls.Find("object_" + picIndex, true)[0];
                obj_txt.BackColor = Color.Gray;
                count += 10;
                NumObject++;
                textBox1.Text = Convert.ToString(count);
            }
            else
            {

                if ((time.Minute == 0 && Int32.Parse(time.ToString("ss")) <= 10))
                {
                    t.Stop();
                    MessageBox.Show("SORRY YOUR TIME IS UP !!");
                    bgmusic.controls.stop();
                    this.Hide();
                    if (seconds > 180)
                    {
                        int a = 180;
                        seconds = a;
                    }
                    sc.Time = seconds;
                    sc.Score = count;
                    sc.Objects = NumObject;
                    sc.ShowDialog();
                }
                else
                {
                    time = time.AddSeconds(-9);
                    seconds += 9;
                }
            }
        }

        private void Level2_Click(object sender, EventArgs e)
        {

        }

        private void Level2_FormClosing(object sender, FormClosingEventArgs e)
        {
            t.Stop();
            Application.Exit();
        }

        private void musicpause_Click(object sender, EventArgs e)
        {
            bgmusic.controls.pause();
        }

        private void musicstart_Click(object sender, EventArgs e)
        {
            bgmusic.controls.play();
        }

    }
}
