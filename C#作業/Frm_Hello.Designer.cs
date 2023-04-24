namespace C_作業
{
    partial class Frm_Hello
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Hello));
            this.btnHi = new System.Windows.Forms.Button();
            this.textSign = new System.Windows.Forms.TextBox();
            this.textGender = new System.Windows.Forms.TextBox();
            this.labelSign = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.textEnglish = new System.Windows.Forms.TextBox();
            this.labelEnglish = new System.Windows.Forms.Label();
            this.labelChinese = new System.Windows.Forms.Label();
            this.textChinese = new System.Windows.Forms.TextBox();
            this.btnHello = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHi
            // 
            this.btnHi.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnHi.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnHi.Location = new System.Drawing.Point(215, 270);
            this.btnHi.Margin = new System.Windows.Forms.Padding(4);
            this.btnHi.Name = "btnHi";
            this.btnHi.Size = new System.Drawing.Size(144, 46);
            this.btnHi.TabIndex = 19;
            this.btnHi.Text = "Say Hi!";
            this.btnHi.UseVisualStyleBackColor = false;
            this.btnHi.Click += new System.EventHandler(this.btnHi_Click);
            // 
            // textSign
            // 
            this.textSign.Location = new System.Drawing.Point(215, 205);
            this.textSign.Margin = new System.Windows.Forms.Padding(4);
            this.textSign.Name = "textSign";
            this.textSign.Size = new System.Drawing.Size(175, 25);
            this.textSign.TabIndex = 18;
            // 
            // textGender
            // 
            this.textGender.Location = new System.Drawing.Point(215, 149);
            this.textGender.Margin = new System.Windows.Forms.Padding(4);
            this.textGender.Name = "textGender";
            this.textGender.Size = new System.Drawing.Size(175, 25);
            this.textGender.TabIndex = 17;
            // 
            // labelSign
            // 
            this.labelSign.AutoSize = true;
            this.labelSign.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSign.Location = new System.Drawing.Point(44, 201);
            this.labelSign.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSign.Name = "labelSign";
            this.labelSign.Size = new System.Drawing.Size(62, 25);
            this.labelSign.TabIndex = 16;
            this.labelSign.Text = "星座: ";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGender.Location = new System.Drawing.Point(44, 145);
            this.labelGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(62, 25);
            this.labelGender.TabIndex = 15;
            this.labelGender.Text = "性別: ";
            // 
            // textEnglish
            // 
            this.textEnglish.Location = new System.Drawing.Point(215, 89);
            this.textEnglish.Margin = new System.Windows.Forms.Padding(4);
            this.textEnglish.Name = "textEnglish";
            this.textEnglish.Size = new System.Drawing.Size(175, 25);
            this.textEnglish.TabIndex = 14;
            // 
            // labelEnglish
            // 
            this.labelEnglish.AutoSize = true;
            this.labelEnglish.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnglish.Location = new System.Drawing.Point(44, 89);
            this.labelEnglish.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEnglish.Name = "labelEnglish";
            this.labelEnglish.Size = new System.Drawing.Size(152, 25);
            this.labelEnglish.TabIndex = 13;
            this.labelEnglish.Text = "English name: ";
            // 
            // labelChinese
            // 
            this.labelChinese.AutoSize = true;
            this.labelChinese.BackColor = System.Drawing.SystemColors.Control;
            this.labelChinese.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChinese.Location = new System.Drawing.Point(44, 38);
            this.labelChinese.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelChinese.Name = "labelChinese";
            this.labelChinese.Size = new System.Drawing.Size(62, 25);
            this.labelChinese.TabIndex = 12;
            this.labelChinese.Text = "姓名: ";
            // 
            // textChinese
            // 
            this.textChinese.Location = new System.Drawing.Point(215, 36);
            this.textChinese.Margin = new System.Windows.Forms.Padding(4);
            this.textChinese.Name = "textChinese";
            this.textChinese.Size = new System.Drawing.Size(175, 25);
            this.textChinese.TabIndex = 11;
            // 
            // btnHello
            // 
            this.btnHello.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnHello.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnHello.Location = new System.Drawing.Point(39, 270);
            this.btnHello.Margin = new System.Windows.Forms.Padding(4);
            this.btnHello.Name = "btnHello";
            this.btnHello.Size = new System.Drawing.Size(144, 46);
            this.btnHello.TabIndex = 10;
            this.btnHello.Text = "Say Hello!";
            this.btnHello.UseVisualStyleBackColor = false;
            this.btnHello.Click += new System.EventHandler(this.btnHello_Click);
            // 
            // Frm_Hello
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(698, 440);
            this.Controls.Add(this.btnHi);
            this.Controls.Add(this.textSign);
            this.Controls.Add(this.textGender);
            this.Controls.Add(this.labelSign);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.textEnglish);
            this.Controls.Add(this.labelEnglish);
            this.Controls.Add(this.labelChinese);
            this.Controls.Add(this.textChinese);
            this.Controls.Add(this.btnHello);
            this.Name = "Frm_Hello";
            this.Text = "Frm_Hello";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHi;
        private System.Windows.Forms.TextBox textSign;
        private System.Windows.Forms.TextBox textGender;
        private System.Windows.Forms.Label labelSign;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.TextBox textEnglish;
        private System.Windows.Forms.Label labelEnglish;
        private System.Windows.Forms.Label labelChinese;
        private System.Windows.Forms.TextBox textChinese;
        private System.Windows.Forms.Button btnHello;
    }
}