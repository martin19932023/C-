using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace C_作業
{
    public partial class Frm_Student_Grade : Form
    {
        public Frm_Student_Grade()
        {
            InitializeComponent();
        }

        string Name = "";
        double ch, en, ma = 0;

        private void BTN_Grade_Click(object sender, EventArgs e)
        {
            double[] arr = { ch, en, ma };
            textBox_TL.Text = "最高分:" + arr.Max() + "\n" + "最低分:" + arr.Min();
        }

        private void BTN_Show_Click(object sender, EventArgs e)
        {
            textBox_Grade.Text = "我的姓名:" + Name + "\r\n" + "國文:" + ch + "\r\n" + "英文:" + en + "\r\n" + "數學:" + ma;
        }

        private void BTN_Save_Click(object sender, EventArgs e)
        {
            //this.button1.Click += new System.EventHandler(this.button1_Click);
            BTN_Save.Click += new EventHandler(BTN_Save_Click);
            BTN_Show.Click += BTN_Show_Click;

            Name = Text_Name.Text;
            ch = double.Parse(Text_Chi.Text);
            en = double.Parse(Text_Eng.Text);
            ma = double.Parse(Text_Math.Text);

        }
    }
}
