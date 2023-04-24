namespace C_作業
{
    partial class Frm_Student_Grade
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
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelChinese = new System.Windows.Forms.Label();
            this.LabelEnglish = new System.Windows.Forms.Label();
            this.LabelMath = new System.Windows.Forms.Label();
            this.BTN_Save = new System.Windows.Forms.Button();
            this.BTN_Show = new System.Windows.Forms.Button();
            this.GroupBox_Show = new System.Windows.Forms.GroupBox();
            this.GroupBox_Show2 = new System.Windows.Forms.GroupBox();
            this.BTN_Grade = new System.Windows.Forms.Button();
            this.Text_Name = new System.Windows.Forms.TextBox();
            this.Text_Chi = new System.Windows.Forms.TextBox();
            this.Text_Eng = new System.Windows.Forms.TextBox();
            this.Text_Math = new System.Windows.Forms.TextBox();
            this.textBox_Grade = new System.Windows.Forms.TextBox();
            this.textBox_TL = new System.Windows.Forms.TextBox();
            this.GroupBox_Show.SuspendLayout();
            this.GroupBox_Show2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LabelName.Location = new System.Drawing.Point(44, 34);
            this.LabelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(67, 24);
            this.LabelName.TabIndex = 0;
            this.LabelName.Text = "姓名:";
            // 
            // LabelChinese
            // 
            this.LabelChinese.AutoSize = true;
            this.LabelChinese.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LabelChinese.Location = new System.Drawing.Point(44, 79);
            this.LabelChinese.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelChinese.Name = "LabelChinese";
            this.LabelChinese.Size = new System.Drawing.Size(67, 24);
            this.LabelChinese.TabIndex = 1;
            this.LabelChinese.Text = "國文:";
            // 
            // LabelEnglish
            // 
            this.LabelEnglish.AutoSize = true;
            this.LabelEnglish.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LabelEnglish.Location = new System.Drawing.Point(44, 124);
            this.LabelEnglish.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelEnglish.Name = "LabelEnglish";
            this.LabelEnglish.Size = new System.Drawing.Size(67, 24);
            this.LabelEnglish.TabIndex = 2;
            this.LabelEnglish.Text = "英文:";
            // 
            // LabelMath
            // 
            this.LabelMath.AutoSize = true;
            this.LabelMath.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LabelMath.Location = new System.Drawing.Point(44, 163);
            this.LabelMath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelMath.Name = "LabelMath";
            this.LabelMath.Size = new System.Drawing.Size(67, 24);
            this.LabelMath.TabIndex = 3;
            this.LabelMath.Text = "數學:";
            // 
            // BTN_Save
            // 
            this.BTN_Save.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BTN_Save.Location = new System.Drawing.Point(32, 225);
            this.BTN_Save.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_Save.Name = "BTN_Save";
            this.BTN_Save.Size = new System.Drawing.Size(91, 38);
            this.BTN_Save.TabIndex = 4;
            this.BTN_Save.Text = "儲存";
            this.BTN_Save.UseVisualStyleBackColor = true;
            this.BTN_Save.Click += new System.EventHandler(this.BTN_Save_Click);
            // 
            // BTN_Show
            // 
            this.BTN_Show.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BTN_Show.Location = new System.Drawing.Point(134, 225);
            this.BTN_Show.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_Show.Name = "BTN_Show";
            this.BTN_Show.Size = new System.Drawing.Size(129, 38);
            this.BTN_Show.TabIndex = 5;
            this.BTN_Show.Text = "顯示儲存內容";
            this.BTN_Show.UseVisualStyleBackColor = true;
            this.BTN_Show.Click += new System.EventHandler(this.BTN_Show_Click);
            // 
            // GroupBox_Show
            // 
            this.GroupBox_Show.Controls.Add(this.textBox_Grade);
            this.GroupBox_Show.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GroupBox_Show.Location = new System.Drawing.Point(289, 34);
            this.GroupBox_Show.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GroupBox_Show.Name = "GroupBox_Show";
            this.GroupBox_Show.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GroupBox_Show.Size = new System.Drawing.Size(245, 141);
            this.GroupBox_Show.TabIndex = 6;
            this.GroupBox_Show.TabStop = false;
            this.GroupBox_Show.Text = "成績";
            // 
            // GroupBox_Show2
            // 
            this.GroupBox_Show2.Controls.Add(this.textBox_TL);
            this.GroupBox_Show2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GroupBox_Show2.Location = new System.Drawing.Point(290, 179);
            this.GroupBox_Show2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GroupBox_Show2.Name = "GroupBox_Show2";
            this.GroupBox_Show2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GroupBox_Show2.Size = new System.Drawing.Size(244, 123);
            this.GroupBox_Show2.TabIndex = 7;
            this.GroupBox_Show2.TabStop = false;
            // 
            // BTN_Grade
            // 
            this.BTN_Grade.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BTN_Grade.Location = new System.Drawing.Point(356, 306);
            this.BTN_Grade.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_Grade.Name = "BTN_Grade";
            this.BTN_Grade.Size = new System.Drawing.Size(166, 38);
            this.BTN_Grade.TabIndex = 8;
            this.BTN_Grade.Text = "最高分/最低分科目";
            this.BTN_Grade.UseVisualStyleBackColor = true;
            this.BTN_Grade.Click += new System.EventHandler(this.BTN_Grade_Click);
            // 
            // Text_Name
            // 
            this.Text_Name.Location = new System.Drawing.Point(134, 36);
            this.Text_Name.Name = "Text_Name";
            this.Text_Name.Size = new System.Drawing.Size(100, 22);
            this.Text_Name.TabIndex = 9;
            // 
            // Text_Chi
            // 
            this.Text_Chi.Location = new System.Drawing.Point(134, 81);
            this.Text_Chi.Name = "Text_Chi";
            this.Text_Chi.Size = new System.Drawing.Size(100, 22);
            this.Text_Chi.TabIndex = 10;
            // 
            // Text_Eng
            // 
            this.Text_Eng.Location = new System.Drawing.Point(134, 126);
            this.Text_Eng.Name = "Text_Eng";
            this.Text_Eng.Size = new System.Drawing.Size(100, 22);
            this.Text_Eng.TabIndex = 11;
            // 
            // Text_Math
            // 
            this.Text_Math.Location = new System.Drawing.Point(134, 165);
            this.Text_Math.Name = "Text_Math";
            this.Text_Math.Size = new System.Drawing.Size(100, 22);
            this.Text_Math.TabIndex = 12;
            // 
            // textBox_Grade
            // 
            this.textBox_Grade.Location = new System.Drawing.Point(4, 27);
            this.textBox_Grade.Multiline = true;
            this.textBox_Grade.Name = "textBox_Grade";
            this.textBox_Grade.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Grade.Size = new System.Drawing.Size(236, 109);
            this.textBox_Grade.TabIndex = 0;
            // 
            // textBox_TL
            // 
            this.textBox_TL.Location = new System.Drawing.Point(5, 1);
            this.textBox_TL.Multiline = true;
            this.textBox_TL.Name = "textBox_TL";
            this.textBox_TL.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_TL.Size = new System.Drawing.Size(234, 109);
            this.textBox_TL.TabIndex = 1;
            // 
            // Frm_Student_Grade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.Controls.Add(this.Text_Math);
            this.Controls.Add(this.Text_Eng);
            this.Controls.Add(this.Text_Chi);
            this.Controls.Add(this.Text_Name);
            this.Controls.Add(this.BTN_Grade);
            this.Controls.Add(this.GroupBox_Show2);
            this.Controls.Add(this.GroupBox_Show);
            this.Controls.Add(this.BTN_Show);
            this.Controls.Add(this.BTN_Save);
            this.Controls.Add(this.LabelMath);
            this.Controls.Add(this.LabelEnglish);
            this.Controls.Add(this.LabelChinese);
            this.Controls.Add(this.LabelName);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Frm_Student_Grade";
            this.Text = "Frm_Student_Grade";
            this.GroupBox_Show.ResumeLayout(false);
            this.GroupBox_Show.PerformLayout();
            this.GroupBox_Show2.ResumeLayout(false);
            this.GroupBox_Show2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelChinese;
        private System.Windows.Forms.Label LabelEnglish;
        private System.Windows.Forms.Label LabelMath;
        private System.Windows.Forms.Button BTN_Save;
        private System.Windows.Forms.Button BTN_Show;
        private System.Windows.Forms.GroupBox GroupBox_Show;
        private System.Windows.Forms.GroupBox GroupBox_Show2;
        private System.Windows.Forms.Button BTN_Grade;
        private System.Windows.Forms.TextBox Text_Name;
        private System.Windows.Forms.TextBox Text_Chi;
        private System.Windows.Forms.TextBox Text_Eng;
        private System.Windows.Forms.TextBox Text_Math;
        private System.Windows.Forms.TextBox textBox_Grade;
        private System.Windows.Forms.TextBox textBox_TL;
    }
}