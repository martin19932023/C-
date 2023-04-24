using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_作業
{
    public partial class Frm_Screen_Saver : Form
    {
        public Frm_Screen_Saver()
        {
            InitializeComponent();
        }

        private void Frm_Screen_Saver_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //labelTime.Text = DateTime.Now.ToString();
            //labelTime.Left += 5;
            //if (labelTime.Right < 0) { labelTime.Left = this.ClientSize.Width; }
            PBAV.Left += 5;
            if (PBAV.Right < 0) { PBAV.Left = this.ClientSize.Width; }
        }

        private void Frm_Screen_Saver_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void PBAV_Click(object sender, EventArgs e)
        {

        }
    }
}
