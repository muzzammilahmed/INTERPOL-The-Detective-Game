namespace INTERPOL_The_Detective_Game
{
    partial class ScoreSheet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScoreSheet));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.main_table_btn = new System.Windows.Forms.Button();
            this.level1_table_btn = new System.Windows.Forms.Button();
            this.level2_table_btn = new System.Windows.Forms.Button();
            this.level3_table_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(253, 424);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1177, 398);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(1451, 759);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "MAIN";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // main_table_btn
            // 
            this.main_table_btn.BackColor = System.Drawing.Color.Transparent;
            this.main_table_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_table_btn.ForeColor = System.Drawing.Color.Black;
            this.main_table_btn.Location = new System.Drawing.Point(312, 304);
            this.main_table_btn.Name = "main_table_btn";
            this.main_table_btn.Size = new System.Drawing.Size(117, 71);
            this.main_table_btn.TabIndex = 2;
            this.main_table_btn.Text = "MAIN TABLE";
            this.main_table_btn.UseVisualStyleBackColor = false;
            this.main_table_btn.Click += new System.EventHandler(this.main_table_btn_Click);
            // 
            // level1_table_btn
            // 
            this.level1_table_btn.BackColor = System.Drawing.Color.Transparent;
            this.level1_table_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.level1_table_btn.ForeColor = System.Drawing.Color.Black;
            this.level1_table_btn.Location = new System.Drawing.Point(628, 304);
            this.level1_table_btn.Name = "level1_table_btn";
            this.level1_table_btn.Size = new System.Drawing.Size(117, 71);
            this.level1_table_btn.TabIndex = 3;
            this.level1_table_btn.Text = "LEVEL 1";
            this.level1_table_btn.UseVisualStyleBackColor = false;
            this.level1_table_btn.Click += new System.EventHandler(this.level1_table_btn_Click);
            // 
            // level2_table_btn
            // 
            this.level2_table_btn.BackColor = System.Drawing.Color.Transparent;
            this.level2_table_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.level2_table_btn.ForeColor = System.Drawing.Color.Black;
            this.level2_table_btn.Location = new System.Drawing.Point(950, 304);
            this.level2_table_btn.Name = "level2_table_btn";
            this.level2_table_btn.Size = new System.Drawing.Size(117, 71);
            this.level2_table_btn.TabIndex = 4;
            this.level2_table_btn.Text = "LEVEL 2";
            this.level2_table_btn.UseVisualStyleBackColor = false;
            this.level2_table_btn.Click += new System.EventHandler(this.level2_table_btn_Click);
            // 
            // level3_table_btn
            // 
            this.level3_table_btn.BackColor = System.Drawing.Color.Transparent;
            this.level3_table_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.level3_table_btn.ForeColor = System.Drawing.Color.Black;
            this.level3_table_btn.Location = new System.Drawing.Point(1249, 304);
            this.level3_table_btn.Name = "level3_table_btn";
            this.level3_table_btn.Size = new System.Drawing.Size(117, 71);
            this.level3_table_btn.TabIndex = 5;
            this.level3_table_btn.Text = "LEVEL 3";
            this.level3_table_btn.UseVisualStyleBackColor = false;
            this.level3_table_btn.Click += new System.EventHandler(this.level3_table_btn_Click);
            // 
            // ScoreSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1584, 821);
            this.Controls.Add(this.level3_table_btn);
            this.Controls.Add(this.level2_table_btn);
            this.Controls.Add(this.level1_table_btn);
            this.Controls.Add(this.main_table_btn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "ScoreSheet";
            this.Text = "ScoreSheet";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ScoreSheet_FormClosing);
            this.Load += new System.EventHandler(this.ScoreSheet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button main_table_btn;
        private System.Windows.Forms.Button level1_table_btn;
        private System.Windows.Forms.Button level2_table_btn;
        private System.Windows.Forms.Button level3_table_btn;
    }
}