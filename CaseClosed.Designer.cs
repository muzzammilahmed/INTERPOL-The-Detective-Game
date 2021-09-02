namespace INTERPOL_The_Detective_Game
{
    partial class CaseClosed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaseClosed));
            this.BackToMain = new System.Windows.Forms.PictureBox();
            this.GoldMedal = new System.Windows.Forms.PictureBox();
            this.BronzeMedal = new System.Windows.Forms.PictureBox();
            this.SilverMedal = new System.Windows.Forms.PictureBox();
            this.congo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BackToMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoldMedal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BronzeMedal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SilverMedal)).BeginInit();
            this.SuspendLayout();
            // 
            // BackToMain
            // 
            this.BackToMain.BackColor = System.Drawing.Color.Transparent;
            this.BackToMain.Location = new System.Drawing.Point(1389, 727);
            this.BackToMain.Name = "BackToMain";
            this.BackToMain.Size = new System.Drawing.Size(193, 40);
            this.BackToMain.TabIndex = 0;
            this.BackToMain.TabStop = false;
            this.BackToMain.Click += new System.EventHandler(this.BackToMain_Click);
            // 
            // GoldMedal
            // 
            this.GoldMedal.BackColor = System.Drawing.Color.Transparent;
            this.GoldMedal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GoldMedal.BackgroundImage")));
            this.GoldMedal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GoldMedal.Location = new System.Drawing.Point(245, 12);
            this.GoldMedal.Name = "GoldMedal";
            this.GoldMedal.Size = new System.Drawing.Size(226, 259);
            this.GoldMedal.TabIndex = 1;
            this.GoldMedal.TabStop = false;
            // 
            // BronzeMedal
            // 
            this.BronzeMedal.BackColor = System.Drawing.Color.Transparent;
            this.BronzeMedal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BronzeMedal.BackgroundImage")));
            this.BronzeMedal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BronzeMedal.Location = new System.Drawing.Point(245, 12);
            this.BronzeMedal.Name = "BronzeMedal";
            this.BronzeMedal.Size = new System.Drawing.Size(226, 259);
            this.BronzeMedal.TabIndex = 2;
            this.BronzeMedal.TabStop = false;
            // 
            // SilverMedal
            // 
            this.SilverMedal.BackColor = System.Drawing.Color.Transparent;
            this.SilverMedal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SilverMedal.BackgroundImage")));
            this.SilverMedal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SilverMedal.Location = new System.Drawing.Point(245, 12);
            this.SilverMedal.Name = "SilverMedal";
            this.SilverMedal.Size = new System.Drawing.Size(226, 259);
            this.SilverMedal.TabIndex = 3;
            this.SilverMedal.TabStop = false;
            // 
            // congo
            // 
            this.congo.AutoSize = true;
            this.congo.BackColor = System.Drawing.Color.Transparent;
            this.congo.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.congo.ForeColor = System.Drawing.Color.White;
            this.congo.Location = new System.Drawing.Point(27, 291);
            this.congo.Name = "congo";
            this.congo.Size = new System.Drawing.Size(73, 25);
            this.congo.TabIndex = 4;
            this.congo.Text = "label1";
            this.congo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CaseClosed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1584, 821);
            this.Controls.Add(this.congo);
            this.Controls.Add(this.SilverMedal);
            this.Controls.Add(this.BronzeMedal);
            this.Controls.Add(this.GoldMedal);
            this.Controls.Add(this.BackToMain);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "CaseClosed";
            this.Text = "CaseClosed";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CaseClosed_FormClosing);
            this.Load += new System.EventHandler(this.CaseClosed_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BackToMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoldMedal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BronzeMedal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SilverMedal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BackToMain;
        private System.Windows.Forms.PictureBox GoldMedal;
        private System.Windows.Forms.PictureBox BronzeMedal;
        private System.Windows.Forms.PictureBox SilverMedal;
        private System.Windows.Forms.Label congo;
    }
}