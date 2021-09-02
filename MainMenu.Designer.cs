namespace INTERPOL_The_Detective_Game
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.play = new System.Windows.Forms.PictureBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.stopsound = new System.Windows.Forms.PictureBox();
            this.playsound = new System.Windows.Forms.PictureBox();
            this.Score = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopsound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playsound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Score)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            this.SuspendLayout();
            // 
            // play
            // 
            this.play.BackColor = System.Drawing.Color.Transparent;
            this.play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.play.Location = new System.Drawing.Point(1323, 411);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(238, 38);
            this.play.TabIndex = 0;
            this.play.TabStop = false;
            this.play.Click += new System.EventHandler(this.Play_Click);
            this.play.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(1448, 43);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(24, 25);
            this.axWindowsMediaPlayer1.TabIndex = 1;
            // 
            // stopsound
            // 
            this.stopsound.BackColor = System.Drawing.Color.Transparent;
            this.stopsound.Location = new System.Drawing.Point(1440, 31);
            this.stopsound.Name = "stopsound";
            this.stopsound.Size = new System.Drawing.Size(32, 37);
            this.stopsound.TabIndex = 2;
            this.stopsound.TabStop = false;
            this.stopsound.Click += new System.EventHandler(this.Mute_Click);
            // 
            // playsound
            // 
            this.playsound.BackColor = System.Drawing.Color.Transparent;
            this.playsound.Location = new System.Drawing.Point(1511, 31);
            this.playsound.Name = "playsound";
            this.playsound.Size = new System.Drawing.Size(36, 37);
            this.playsound.TabIndex = 3;
            this.playsound.TabStop = false;
            this.playsound.Click += new System.EventHandler(this.PlayMusic_Click);
            // 
            // Score
            // 
            this.Score.BackColor = System.Drawing.Color.Transparent;
            this.Score.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Score.Location = new System.Drawing.Point(1323, 501);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(238, 39);
            this.Score.TabIndex = 4;
            this.Score.TabStop = false;
            this.Score.Click += new System.EventHandler(this.Score_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Location = new System.Drawing.Point(1334, 588);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(238, 39);
            this.exit.TabIndex = 5;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1584, 821);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.playsound);
            this.Controls.Add(this.stopsound);
            this.Controls.Add(this.play);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenu_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopsound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playsound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Score)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox play;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.PictureBox stopsound;
        private System.Windows.Forms.PictureBox playsound;
        private System.Windows.Forms.PictureBox Score;
        private System.Windows.Forms.PictureBox exit;


    }
}

