namespace C_作業
{
    partial class Frm_Screen_Saver
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
            this.components = new System.ComponentModel.Container();
            this.labelTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PBAV = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBAV)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.BackColor = System.Drawing.Color.Silver;
            this.labelTime.Font = new System.Drawing.Font("微軟正黑體", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelTime.Image = global::C_作業.Properties.Resources.av_debut;
            this.labelTime.Location = new System.Drawing.Point(115, 89);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(0, 101);
            this.labelTime.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PBAV
            // 
            this.PBAV.BackColor = System.Drawing.Color.Black;
            this.PBAV.Image = global::C_作業.Properties.Resources.av_debut;
            this.PBAV.Location = new System.Drawing.Point(189, 37);
            this.PBAV.Name = "PBAV";
            this.PBAV.Size = new System.Drawing.Size(326, 427);
            this.PBAV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBAV.TabIndex = 1;
            this.PBAV.TabStop = false;
            this.PBAV.Click += new System.EventHandler(this.PBAV_Click);
            // 
            // Frm_Screen_Saver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(889, 522);
            this.Controls.Add(this.PBAV);
            this.Controls.Add(this.labelTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Screen_Saver";
            this.Text = "Frm_Screen_Saver";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_Screen_Saver_Load);
            this.Click += new System.EventHandler(this.Frm_Screen_Saver_Click);
            ((System.ComponentModel.ISupportInitialize)(this.PBAV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox PBAV;
    }
}