namespace INTERPOL_The_Detective_Game
{
    partial class Wallet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Wallet));
            this.Continue = new System.Windows.Forms.Label();
            this.Finish = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Continue
            // 
            this.Continue.AutoSize = true;
            this.Continue.BackColor = System.Drawing.Color.Transparent;
            this.Continue.Location = new System.Drawing.Point(1415, 685);
            this.Continue.Name = "Continue";
            this.Continue.Size = new System.Drawing.Size(157, 39);
            this.Continue.TabIndex = 0;
            this.Continue.Text = "                                                \r\n                               " +
    "                 \r\n                                                  ";
            this.Continue.Click += new System.EventHandler(this.Continue_Click);
            // 
            // Finish
            // 
            this.Finish.AutoSize = true;
            this.Finish.BackColor = System.Drawing.Color.Transparent;
            this.Finish.Location = new System.Drawing.Point(3, 685);
            this.Finish.Name = "Finish";
            this.Finish.Size = new System.Drawing.Size(157, 39);
            this.Finish.TabIndex = 1;
            this.Finish.Text = "                                                \r\n                               " +
    "                 \r\n                                                  ";
            this.Finish.Click += new System.EventHandler(this.Finish_Click);
            // 
            // Wallet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1584, 821);
            this.Controls.Add(this.Finish);
            this.Controls.Add(this.Continue);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "Wallet";
            this.Text = "Wallet";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Wallet_FormClosing);
            this.Load += new System.EventHandler(this.Wallet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Continue;
        private System.Windows.Forms.Label Finish;
    }
}