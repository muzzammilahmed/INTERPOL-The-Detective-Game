using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace DetectiveGame
{
    public partial class Form1 : Form
    {
        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer(); 
        
        public Form1()
        {
            InitializeComponent();
         
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        

        

        private void timer1_Tick(object sender, EventArgs e)
        {
         
            progressbar.Increment(1);
            progressbar.BackColor = Color.Gray;
            progressbar.ForeColor = Color.Black;
            label1.Text = progressbar.Value.ToString()+"%";
        }

        private void p_Click(object sender, EventArgs e)
        {

        }
    }
}
