using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;


namespace C_作業
{
    public partial class Frm_Notepad : Form
    {
        public Frm_Notepad()
        {
            InitializeComponent();
        }

        private void 開啟ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = File.ReadAllText(openFileDialog1.FileName, Encoding.Default);

            }
        }

        private void 新增ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            textBox1.Clear();
        }

        private void 結束ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 另存新檔ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            File.WriteAllText(saveFileDialog1.FileName, textBox1.Text, Encoding.Default);
        }

        private void 儲存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.FileName == "")
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog1.FileName, textBox1.Text, Encoding.Default);
                }
            }
            else
            {
                File.WriteAllText(saveFileDialog1.FileName, textBox1.Text, Encoding.Default);
            }
        }

        private void 剪下ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void 複製CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void 貼上PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void 全選AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void 搜尋ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int f;
            if (textBox1.SelectionLength > 0)
            {
                f = textBox1.Text.IndexOf(textBox2.Text, textBox1.SelectionStart + 1);
            }
            else 
            { 
            f = textBox1.Text.IndexOf(textBox2.Text, textBox1.SelectionStart);
            }
            if (f < 0) {
                MessageBox.Show("找不到...");
            }
            else { 
            textBox1.SelectionStart = f;
                textBox1.SelectionLength = textBox2.TextLength;
                textBox1.Select();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.SelectedText = textBox3.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        int mdx, mdy;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left) {
                panel1.Left = panel1.Left + (e.X - mdx);
                panel1.Top = panel1.Top + (e.Y - mdy);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mdx = e.X;
            mdy = e.Y;
        }
    }
}
