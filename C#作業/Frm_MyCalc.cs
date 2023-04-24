using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace C_作業
{
    
    public partial class Frm_MyCalc : Form
    {
        public Frm_MyCalc()
        {
            InitializeComponent();
        }

        public object TxtBox1 { get; private set; }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int x = 0;
            int y = 0;
            x = int.Parse(txtBox1.Text);
            y = int.Parse(txtBox2.Text);
           txtBoxAns.Text = Convert.ToString(x + y);

        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            int x = 0;
            int y = 0;
            x = int.Parse(txtBox1.Text);
            y = int.Parse(txtBox2.Text);
            txtBoxAns.Text = Convert.ToString(x - y);
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            int x = 0;
            int y = 0;
            x = int.Parse(txtBox1.Text);
            y = int.Parse(txtBox2.Text);
            txtBoxAns.Text = Convert.ToString(x * y);
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            int x = 0;
            int y = 0;
            x = int.Parse(txtBox1.Text);
            y = int.Parse(txtBox2.Text);
            txtBoxAns.Text = Convert.ToString(x / y);
        }
    }
}
