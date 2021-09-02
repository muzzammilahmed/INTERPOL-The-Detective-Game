namespace INTERPOL_The_Detective_Game
{
    partial class Comic
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Comic));
            this.italy = new System.Windows.Forms.Label();
            this.arrest = new System.Windows.Forms.Label();
            this.lift = new System.Windows.Forms.Label();
            this.investigate = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // italy
            // 
            this.italy.AutoSize = true;
            this.italy.BackColor = System.Drawing.Color.Transparent;
            this.italy.Font = new System.Drawing.Font("Monotype Corsiva", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.italy.Location = new System.Drawing.Point(49, 366);
            this.italy.Name = "italy";
            this.italy.Size = new System.Drawing.Size(266, 60);
            this.italy.TabIndex = 0;
            this.italy.Text = "    FINALLY IN ITALY!!\r\n\r\nHOPE TO SEE YOU SOON Mr.X...";
            // 
            // arrest
            // 
            this.arrest.AutoSize = true;
            this.arrest.BackColor = System.Drawing.Color.Transparent;
            this.arrest.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arrest.Location = new System.Drawing.Point(86, 750);
            this.arrest.Name = "arrest";
            this.arrest.Size = new System.Drawing.Size(432, 33);
            this.arrest.TabIndex = 1;
            this.arrest.Text = "HANDS ON YOUR HEAD MISTER!!";
            this.arrest.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lift
            // 
            this.lift.AutoSize = true;
            this.lift.BackColor = System.Drawing.Color.Transparent;
            this.lift.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lift.Location = new System.Drawing.Point(983, 102);
            this.lift.Name = "lift";
            this.lift.Size = new System.Drawing.Size(280, 84);
            this.lift.TabIndex = 2;
            this.lift.Text = "ROOM NUMBER PxD-306\r\nHENRY CHAMBER\r\nITALIA.";
            this.lift.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // investigate
            // 
            this.investigate.AutoSize = true;
            this.investigate.BackColor = System.Drawing.Color.Transparent;
            this.investigate.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.investigate.Location = new System.Drawing.Point(973, 573);
            this.investigate.Name = "investigate";
            this.investigate.Size = new System.Drawing.Size(169, 125);
            this.investigate.TabIndex = 3;
            this.investigate.Text = "   SUSPECT \r\n  ARRESTED!!\r\n\r\n   \"TIME TO \r\n  INVESTIGATE\"\r\n";
            this.investigate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 4000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 6000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Interval = 8000;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // timer5
            // 
            this.timer5.Interval = 9000;
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // Comic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1584, 821);
            this.Controls.Add(this.investigate);
            this.Controls.Add(this.lift);
            this.Controls.Add(this.arrest);
            this.Controls.Add(this.italy);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "Comic";
            this.Text = "Comic";
            this.Load += new System.EventHandler(this.Comic_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label italy;
        private System.Windows.Forms.Label arrest;
        private System.Windows.Forms.Label lift;
        private System.Windows.Forms.Label investigate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer5;
    }
}