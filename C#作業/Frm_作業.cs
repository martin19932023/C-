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
    public partial class Frm_作業 : Form
    {
        public Frm_作業()
        {
            InitializeComponent();
        }

        private void btn_hello_Click(object sender, EventArgs e)
        {
            Frm_Hello frm = new Frm_Hello();
            frm.Show();
        }

        private void btn_XOGame_Click(object sender, EventArgs e)
        {
            Frm_XOGame frm = new Frm_XOGame();
            frm.Show();
        }

        private void BTNMyCalc_Click(object sender, EventArgs e)
        {
            Frm_MyCalc frm = new Frm_MyCalc();
            frm.Show();
        }

        private void BTNSS_Click(object sender, EventArgs e)
        {
            Frm_Screen_Saver frm = new Frm_Screen_Saver();
            frm.Show();
        }

        private void BTNPOS_Click(object sender, EventArgs e)
        {
            Frm_POS frm = new Frm_POS();
            frm.Show();
        }

        private void BTNLoan_Click(object sender, EventArgs e)
        {
            Frm_Loan frm = new Frm_Loan();
            frm.Show();
        }

        private void BTN_StudentGrade_Click(object sender, EventArgs e)
        {
            Frm_Student_Grade frm = new Frm_Student_Grade();
            frm.Show();
        }


        private void BTN_MyPainter_Click(object sender, EventArgs e)
        {
            Frm_MyPainter frm = new Frm_MyPainter();
            frm.Show();
        }

        private void BTN_Notepad_Click(object sender, EventArgs e)
        {
            Frm_Notepad frm = new Frm_Notepad();
            frm.Show();
        }

        private void Frm_作業_Load(object sender, EventArgs e)
        {

        }
    }
    }
