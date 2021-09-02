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
    public partial class CriminalFound : Form
    {
        public CriminalFound()
        {
            InitializeComponent();
        }
        private void CriminalFound_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(1, 1);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CaseClosed cc = new CaseClosed();
            this.Hide();
            timer1.Stop();
            cc.ShowDialog();

        }

        private void CriminalFound_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        
    }
}
