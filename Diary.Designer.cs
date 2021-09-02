namespace INTERPOL_The_Detective_Game
{
    partial class Diary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Diary));
            this.retry = new System.Windows.Forms.Label();
            this.Continue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // retry
            // 
            this.retry.AutoSize = true;
            this.retry.BackColor = System.Drawing.Color.Transparent;
            this.retry.Location = new System.Drawing.Point(12, 714);
            this.retry.Name = "retry";
            this.retry.Size = new System.Drawing.Size(157, 39);
            this.retry.TabIndex = 3;
            this.retry.Text = "                                                \r\n                               " +
    "                 \r\n                                                  ";
            this.retry.Click += new System.EventHandler(this.Finish_Click);
            // 
            // Continue
            // 
            this.Continue.AutoSize = true;
            this.Continue.BackColor = System.Drawing.Color.Transparent;
            this.Continue.Location = new System.Drawing.Point(1404, 703);
            this.Continue.Name = "Continue";
            this.Continue.Size = new System.Drawing.Size(157, 39);
            this.Continue.TabIndex = 2;
            this.Continue.Text = "                                                \r\n                               " +
    "                 \r\n                                                  ";
            this.Continue.Click += new System.EventHandler(this.Continue_Click);
            // 
            // Diary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1584, 821);
            this.Controls.Add(this.retry);
            this.Controls.Add(this.Continue);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "Diary";
            this.Text = "Diary";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Diary_FormClosing);
            this.Load += new System.EventHandler(this.Diary_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label retry;
        private System.Windows.Forms.Label Continue;
    }
}