namespace C_作業
{
    partial class Frm_MyPainter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.另存新檔ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.開新檔案ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.開啟舊ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.另存新檔ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.結束ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.開啟舊檔ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.顏色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.筆寬ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.另存新檔ToolStripMenuItem,
            this.開啟舊檔ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "我的小畫家";
            // 
            // 另存新檔ToolStripMenuItem
            // 
            this.另存新檔ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.開新檔案ToolStripMenuItem1,
            this.開啟舊ToolStripMenuItem,
            this.另存新檔ToolStripMenuItem1,
            this.結束ToolStripMenuItem2});
            this.另存新檔ToolStripMenuItem.Name = "另存新檔ToolStripMenuItem";
            this.另存新檔ToolStripMenuItem.Size = new System.Drawing.Size(53, 23);
            this.另存新檔ToolStripMenuItem.Text = "檔案";
            // 
            // 開新檔案ToolStripMenuItem1
            // 
            this.開新檔案ToolStripMenuItem1.Name = "開新檔案ToolStripMenuItem1";
            this.開新檔案ToolStripMenuItem1.Size = new System.Drawing.Size(152, 26);
            this.開新檔案ToolStripMenuItem1.Text = "開新檔案";
            this.開新檔案ToolStripMenuItem1.Click += new System.EventHandler(this.開新檔案ToolStripMenuItem1_Click);
            // 
            // 開啟舊ToolStripMenuItem
            // 
            this.開啟舊ToolStripMenuItem.Name = "開啟舊ToolStripMenuItem";
            this.開啟舊ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.開啟舊ToolStripMenuItem.Text = "開啟舊檔";
            this.開啟舊ToolStripMenuItem.Click += new System.EventHandler(this.開啟舊ToolStripMenuItem_Click);
            // 
            // 另存新檔ToolStripMenuItem1
            // 
            this.另存新檔ToolStripMenuItem1.Name = "另存新檔ToolStripMenuItem1";
            this.另存新檔ToolStripMenuItem1.Size = new System.Drawing.Size(152, 26);
            this.另存新檔ToolStripMenuItem1.Text = "另存新檔";
            this.另存新檔ToolStripMenuItem1.Click += new System.EventHandler(this.另存新檔ToolStripMenuItem1_Click);
            // 
            // 結束ToolStripMenuItem2
            // 
            this.結束ToolStripMenuItem2.Name = "結束ToolStripMenuItem2";
            this.結束ToolStripMenuItem2.Size = new System.Drawing.Size(152, 26);
            this.結束ToolStripMenuItem2.Text = "結束";
            this.結束ToolStripMenuItem2.Click += new System.EventHandler(this.結束ToolStripMenuItem2_Click);
            // 
            // 開啟舊檔ToolStripMenuItem
            // 
            this.開啟舊檔ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.顏色ToolStripMenuItem,
            this.筆寬ToolStripMenuItem});
            this.開啟舊檔ToolStripMenuItem.Name = "開啟舊檔ToolStripMenuItem";
            this.開啟舊檔ToolStripMenuItem.Size = new System.Drawing.Size(83, 23);
            this.開啟舊檔ToolStripMenuItem.Text = "畫筆設定";
            // 
            // 顏色ToolStripMenuItem
            // 
            this.顏色ToolStripMenuItem.Name = "顏色ToolStripMenuItem";
            this.顏色ToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.顏色ToolStripMenuItem.Text = "顏色";
            this.顏色ToolStripMenuItem.Click += new System.EventHandler(this.顏色ToolStripMenuItem_Click);
            // 
            // 筆寬ToolStripMenuItem
            // 
            this.筆寬ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1});
            this.筆寬ToolStripMenuItem.Name = "筆寬ToolStripMenuItem";
            this.筆寬ToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.筆寬ToolStripMenuItem.Text = "筆寬";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "5",
            "10",
            "20"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 27);
            this.toolStripComboBox1.Text = "1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(51, 66);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(411, 236);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "|*.jpg;*.gif;*.bmp";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "*jpg|*.jpg";
            // 
            // saveFileDialog2
            // 
            this.saveFileDialog2.Filter = "*jpg|*.jpg";
            // 
            // Frm_MyPainter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_MyPainter";
            this.Text = "偶的小畫家";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_MyPainter_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 另存新檔ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 開啟舊檔ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 開新檔案ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 開啟舊ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 另存新檔ToolStripMenuItem1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        private System.Windows.Forms.ToolStripMenuItem 結束ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 顏色ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 筆寬ToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}