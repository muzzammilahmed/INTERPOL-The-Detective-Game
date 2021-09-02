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
    public partial class ScoreCard2 : Form
    {
        public int Score { get; set; }
        public int Objects { get; set; }
        public int Time { get; set; }

        CaseClosed cc = new CaseClosed();
        int a;
        public ScoreCard2()
        {
            InitializeComponent();
        }
        private void ScoreCard2_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(1, 1);

            star1.Visible = false;
            star2.Visible = false;
            star3.Visible = false;
            star4.Visible = false;
            star5.Visible = false;

            Found_object_text.Text = Objects.ToString();
            Score_text.Text = Score.ToString();
            Time_Taken_text.Text = Time.ToString();

            if (Time <=180  && (Objects >= 1 && Objects <= 5))
            {
                //1 star
                star1.Visible = true;
                star2.Visible = false;
                star3.Visible = false;
                star4.Visible = false;
                star5.Visible = false;
            }

            else if (Time <= 180 && (Objects >= 6 && Objects <= 9))
            {
                //2 stars
                star1.Visible = true;
                star2.Visible = true;
                star3.Visible = false;
                star4.Visible = false;
                star5.Visible = false;
            }

            else if (Objects == 10 && (Time >= 0 && Time <= 36))
            {
                star1.Visible = true;
                star2.Visible = true;
                star3.Visible = true;
                star4.Visible = true;
                star5.Visible = true;
                a = 5;
                cc.ObStars2 = a;
            }
            else if (Objects == 10 && (Time >= 37 && Time <= 72))
            {
                star1.Visible = true;
                star2.Visible = true;
                star3.Visible = true;
                star4.Visible = true;
                star5.Visible = false;
                a = 4;
                cc.ObStars2 = a;
            }

            else if (Objects == 10 && (Time >= 73 && Time <= 108))
            {
                star1.Visible = true;
                star2.Visible = true;
                star3.Visible = true;
                star4.Visible = false;
                star5.Visible = false;
                a = 3;
                cc.ObStars2 = a;
            }
            else if (Objects == 10 && (Time >= 109 && Time <= 144))
            {
                star1.Visible = true;
                star2.Visible = true;
                star3.Visible = false;
                star4.Visible = false;
                star5.Visible = false;
                a = 2;
                cc.ObStars2 = a;
            }

            else if (Objects == 10 && (Time >= 145 && Time <= 180))
            {
                star1.Visible = true;
                star2.Visible = false;
                star3.Visible = false;
                star4.Visible = false;
                star5.Visible = false;
                a = 1;
                cc.ObStars2 = a;
            }
        }

        private void Continue_Click(object sender, EventArgs e)
        {
            Console.Beep();
            if (Found_object_text.Text == Convert.ToString("10"))
            {
                Diary d = new Diary();
                this.Hide();
                cc.ObStars2 = a;
                d.ShowDialog();
            }
            else
            {
                MessageBox.Show("SORRY YOU HAVE NOT FOUND ALL THE OBJECTS PRESS RETRY TO PLAY AGAIN OR CONTINUE TO MAIN MENU.");
                MainMenu m = new MainMenu();
                this.Hide();
                m.ShowDialog();

            }
        }

        private void retry_Click(object sender, EventArgs e)
        {
            Console.Beep();
            Level2 l2 = new Level2();
            this.Hide();
            l2.ShowDialog();
        }

        private void ScoreCard2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        
    }
}
