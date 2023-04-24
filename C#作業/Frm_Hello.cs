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
    public partial class Frm_Hello : Form
    {
        public Frm_Hello()
        {
            InitializeComponent();
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            String Name = textChinese.Text;
            String EngName = textEnglish.Text;
            String Gender = textGender.Text;
            String Sign = textSign.Text;
            MessageBox.Show("Hello, 我是" + Name + "," + "\n英文名字是" + EngName + "," + "\n性別是" + Gender + "," + "\n星座是" + Sign + "," + "\n很高興認識你!!");
        }

        private void btnHi_Click(object sender, EventArgs e)
        {
            String Name = textChinese.Text;
            String EngName = textEnglish.Text;
            String Gender = textGender.Text;
            String Sign = textSign.Text;
            MessageBox.Show("Hi, 我是" + Name + "," + "\n英文名字是" + EngName + "," + "\n性別是" + Gender + "," + "\n星座是" + Sign + "," + "\n很高興認識你!!");
        }
    }
}
