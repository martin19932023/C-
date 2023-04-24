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
    public partial class Frm_MyPainter : Form
    {

        public Frm_MyPainter()
        {
            InitializeComponent();
        }

        private void 開新檔案ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(800,600 );
            Graphics g = Graphics.FromImage(pictureBox1.Image);
            g.Clear(Color.White);
        }

        private void Frm_MyPainter_Load(object sender, EventArgs e)
        {
            開新檔案ToolStripMenuItem1_Click(sender, e );
        }

        private void 開啟舊ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }

        private void 另存新檔ToolStripMenuItem1_Click(object sender, EventArgs e)
         {
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Bitmap bmp = new Bitmap(pictureBox1.Image);
                bmp.Save(saveFileDialog1.FileName);
             }
        }

        private void 結束ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int x0, y0;

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                Graphics g = Graphics.FromImage(pictureBox1.Image);
                Pen p = new Pen(colorDialog1.Color, int.Parse(toolStripComboBox1.Text));
                g.DrawLine(p, x0, y0, e.X, e.Y );
                x0 = e.X;
                y0 = e.Y;
                pictureBox1.Refresh();
            }
        }

        private void 顏色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            x0 = e.X;
            y0 = e.Y;

        }
    }
}
