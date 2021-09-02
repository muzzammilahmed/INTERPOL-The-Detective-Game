using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace INTERPOL_The_Detective_Game
{
    public partial class ScoreCard1 : Form
    {
        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Hp Elite Book\Desktop\INTERPOL-The Detective Game\INTERPOL1.accdb");

        public int Score { get; set; }
        public int Objects { get; set; }
        public int Time { get; set; }

        CaseClosed cc = new CaseClosed();
        int a;
        public ScoreCard1()
        {
            InitializeComponent();
        }

        private void ScoreCard_Load(object sender, EventArgs e)
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

            if (Time <= 300 && (Objects >= 1 && Objects <= 5))
            {
                //1 star
                star1.Visible = true;
                star2.Visible = false;
                star3.Visible = false;
                star4.Visible = false;
                star5.Visible = false;
            }

            else if (Time <= 300 && (Objects >= 6 && Objects <= 9))
            {
                //2 stars
                star1.Visible = true;
                star2.Visible = true;
                star3.Visible = false;
                star4.Visible = false;
                star5.Visible = false;
            }

            else if (Objects == 10 && (Time >= 0 && Time <= 60))
            {
                star1.Visible = true;
                star2.Visible = true;
                star3.Visible = true;
                star4.Visible = true;
                star5.Visible = true;
                a=5;
                cc.ObStars1 = a; 

            }
            else if (Objects == 10 && (Time >= 61 && Time <= 120))
            {
                star1.Visible = true;
                star2.Visible = true;
                star3.Visible = true;
                star4.Visible = true;
                star5.Visible = false;
                a = 4;
                cc.ObStars1 = a;
            }

            else if (Objects == 10 && (Time >= 121 && Time <= 180))
            {
                star1.Visible = true;
                star2.Visible = true;
                star3.Visible = true;
                star4.Visible = false;
                star5.Visible = false;
                a = 3;
                cc.ObStars1 = a;
            }
            else if (Objects == 10 && (Time >= 181 && Time <= 240))
            {
                star1.Visible = true;
                star2.Visible = true;
                star3.Visible = false;
                star4.Visible = false;
                star5.Visible = false;
                a = 2;
                cc.ObStars1 = a;
            }

            else if (Objects == 10 && (Time >= 341 && Time <= 300))
            {
                star1.Visible = true;
                star2.Visible = false;
                star3.Visible = false;
                star4.Visible = false;
                star5.Visible = false;
                a = 1;
                cc.ObStars1 = a;
            }
                

        }

        private void Found_object_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void No_Hints_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void Score_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void Continue_Click(object sender, EventArgs e)
        {
            Console.Beep();
            if(Found_object_text.Text==Convert.ToString("10"))
            {
                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    command.CommandText = "insert into Level1([Police_ID],[Objects],[time_taken],[Stars],[Score],[Level_Cleared]) values('" + "5" + "','" + Found_object_text.Text + "','" + Time_Taken_text.Text + "','" + a + "','" + Score_text.Text + "','" + "yes" + "')";
                    command.ExecuteNonQuery();
                    MessageBox.Show("Record Successfully Inserted");
                    connection.Close();

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error" + ex);

                }
                Wallet w = new Wallet();
                this.Hide();
                cc.ObStars1 = a;
                w.ShowDialog();
            }
            else
            {
                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    command.CommandText = "insert into Level1([Police_ID],[Objects],[time_taken],[Stars],[Score],[Level_Cleared]) values('" + "5" + "','" + Found_object_text.Text + "','" + Time_Taken_text.Text + "','" + a + "','" + Score_text.Text + "','" + "yes" + "')";
                    command.ExecuteNonQuery();
                    MessageBox.Show("Record Successfully Inserted");
                    connection.Close();

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error" + ex);

                }
                MessageBox.Show("SORRY YOU HAVE NOT FOUND ALL THE OBJECTS PRESS RETRY TO PLAY AGAIN OR CONTINUE TO MAIN MENU.");
                MainMenu m = new MainMenu();
                this.Hide();
                m.ShowDialog();

            }

            

        }

        private void retry_Click(object sender, EventArgs e)
        {
            Level1 l1 = new Level1();
            Console.Beep();
            this.Hide();
            l1.ShowDialog();
        }

        private void ScoreCard1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
