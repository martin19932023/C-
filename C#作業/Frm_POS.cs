using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace C_作業
{
    public partial class Frm_POS : Form
    {
        public Frm_POS()
        {
            InitializeComponent();
        }

        int Fries = 0;
        int FriesQ = 0;
        string BTN = "";

        private void btnFries_Click(object sender, EventArgs e)
        {
            Fries += 90;
            FriesQ += 1;
            //BTN += "薯條1*" + FriesQ + ",NTD" + Fries + "\r\n";
            TxtList.Text += "薯條1*" + FriesQ + ",NTD" + Fries + "\r\n";
            textBoxPrice.Text = "NTD:" + (Fries + Coke + Ham + Chi);

        }
        int Coke = 0;
        int CokeQ = 0;

        private void BTN_Coke_Click(object sender, EventArgs e)
        {
            Coke += 40;
            CokeQ += 1;
            BTN += "可樂1*" + CokeQ + ",NTD" + Coke + "\r\n";
            TxtList.Text = BTN;
            textBoxPrice.Text = "NTD:" + (Fries + Coke + Ham + Chi);
        }
        int Ham = 0;
        int HamQ = 0;

        private void BTN_Ham_Click(object sender, EventArgs e)
        {
            Ham += 150;
            HamQ += 1;
            BTN += "漢堡1*" + HamQ + ",NTD" + Ham + "\r\n";
            TxtList.Text = BTN;
            textBoxPrice.Text = "NTD:" + (Fries + Coke + Ham + Chi);
        }
        int Chi = 0;
        int ChiQ = 0;

        private void BTN_Chic_Click(object sender, EventArgs e)
        {
            Chi += 200;
            ChiQ += 1;
            BTN += "炸雞1*" + ChiQ + ",NTD" + Ham + "\r\n";
            TxtList.Text = BTN;
            textBoxPrice.Text = "NTD:" + (Fries + Coke + Ham + Chi);
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            MessageBox.Show("總共:" + (Fries + Coke + Ham + Chi));
        }

        private void btnCredit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("總共:" + (Fries + Coke + Ham + Chi )* 0.9);
        }

        private void BTN_Clear_Click(object sender, EventArgs e)
        {
            TxtList.Text = "";
            textBoxPrice.Text = "NTD 0";
        }
    }
}
