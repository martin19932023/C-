using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_作業
{
    public partial class Frm_XOGame : Form
    {
        bool isX = true;

        public Frm_XOGame()
        {
            InitializeComponent();
        }
        private void testWin()
        {
            if (btn1.Text == "X" && btn2.Text == "X" && btn3.Text == "X") MessageBox.Show("X手獲勝，好棒棒!!");
            if (btn1.Text == "X" && btn4.Text == "X" && btn7.Text == "X") MessageBox.Show("X手獲勝，好棒棒!!");
            if (btn1.Text == "X" && btn5.Text == "X" && btn9.Text == "X") MessageBox.Show("X手獲勝，好棒棒!!");
            if (btn2.Text == "X" && btn5.Text == "X" && btn8.Text == "X") MessageBox.Show("X手獲勝，好棒棒!!");
            if (btn3.Text == "X" && btn5.Text == "X" && btn7.Text == "X") MessageBox.Show("X手獲勝，好棒棒!!");
            if (btn3.Text == "X" && btn6.Text == "X" && btn9.Text == "X") MessageBox.Show("X手獲勝，好棒棒!!");
            if (btn4.Text == "X" && btn5.Text == "X" && btn6.Text == "X") MessageBox.Show("X手獲勝，好棒棒!!");
            if (btn7.Text == "X" && btn8.Text == "X" && btn9.Text == "X") MessageBox.Show("X手獲勝，好棒棒!!");

            if (btn1.Text == "O" && btn2.Text == "O" && btn3.Text == "O") MessageBox.Show("O手獲勝，好棒棒!!");
            if (btn1.Text == "O" && btn4.Text == "O" && btn7.Text == "O") MessageBox.Show("O手獲勝，好棒棒!!");
            if (btn1.Text == "O" && btn5.Text == "O" && btn9.Text == "O") MessageBox.Show("O手獲勝，好棒棒!!");
            if (btn2.Text == "O" && btn5.Text == "O" && btn8.Text == "O") MessageBox.Show("O手獲勝，好棒棒!!");
            if (btn3.Text == "O" && btn5.Text == "O" && btn7.Text == "O") MessageBox.Show("O手獲勝，好棒棒!!");
            if (btn3.Text == "O" && btn6.Text == "O" && btn9.Text == "O") MessageBox.Show("O手獲勝，好棒棒!!");
            if (btn4.Text == "O" && btn5.Text == "O" && btn6.Text == "O") MessageBox.Show("O手獲勝，好棒棒!!");
            if (btn7.Text == "O" && btn8.Text == "O" && btn9.Text == "O") MessageBox.Show("O手獲勝，好棒棒!!");
        }
        


        private void btn1_Click(object sender, EventArgs e)
        {
            if (isX == true)
            {
                btn1.Text = "X";
                isX = false;
            }
            else 
            {
                btn1.Text = "O";
                isX = true; 
            }
            testWin();
            int count = 9;
            btn1.Enabled = false;


        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (isX == true)
            {
                btn2.Text = "X";
                isX = false;
            }
            else
            {
                btn2.Text = "O";
                isX = true;
            }
            testWin();
            int count = 9;
            btn2.Enabled = false;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (isX == true)
            {
                btn3.Text = "X";
                isX = false;
            }
            else
            {
                btn3.Text = "O";
                isX = true;
            }
            testWin();
            int count = 9;
            btn3.Enabled = false;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (isX == true)
            {
                btn4.Text = "X";
                isX = false;
            }
            else
            {
                btn4.Text = "O";
                isX = true;
            }
            testWin();
            int count = 9;
            btn4.Enabled = false;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (isX == true)
            {
                btn5.Text = "X";
                isX = false;
            }
            else
            {
                btn5.Text = "O";
                isX = true;
            }
            testWin();
            int count = 9;
            btn5.Enabled = false;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (isX == true)
            {
                btn6.Text = "X";
                isX = false;
            }
            else
            {
                btn6.Text = "O";
                isX = true;
            }
            testWin();
            int count = 9;
            btn6.Enabled = false;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (isX == true)
            {
                btn7.Text = "X";
                isX = false;
            }
            else
            {
                btn7.Text = "O";
                isX = true;
            }
            testWin();
            int count = 9;
            btn7.Enabled = false;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (isX == true)
            {
                btn8.Text = "X";
                isX = false;
            }
            else
            {
                btn8.Text = "O";
                isX = true;
            }
            testWin();
            int count = 9;
            btn8.Enabled = false;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (isX == true)
            {
                btn9.Text = "X";
                isX = false;
            }
            else
            {
                btn9.Text = "O";
                isX = true;
            }
            testWin();
            int count = 9;
            btn9.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            
        }
    }
}
   
