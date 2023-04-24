namespace C_作業
{
    partial class Frm_Loan
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
            this.BTN_PMT = new System.Windows.Forms.Button();
            this.LabelAmount = new System.Windows.Forms.Label();
            this.Txt_Amount = new System.Windows.Forms.TextBox();
            this.LabelDue = new System.Windows.Forms.Label();
            this.LabelPercent = new System.Windows.Forms.Label();
            this.LabelFirstPay = new System.Windows.Forms.Label();
            this.Txt_Due = new System.Windows.Forms.TextBox();
            this.Txt_Percent = new System.Windows.Forms.TextBox();
            this.Txt_FirstPay = new System.Windows.Forms.TextBox();
            this.BTN_Total = new System.Windows.Forms.Button();
            this.BTN_Report = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTN_PMT
            // 
            this.BTN_PMT.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BTN_PMT.Location = new System.Drawing.Point(66, 263);
            this.BTN_PMT.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_PMT.Name = "BTN_PMT";
            this.BTN_PMT.Size = new System.Drawing.Size(134, 42);
            this.BTN_PMT.TabIndex = 0;
            this.BTN_PMT.Text = "PMT) 月付";
            this.BTN_PMT.UseVisualStyleBackColor = true;
            this.BTN_PMT.Click += new System.EventHandler(this.BTN_PMT_Click);
            // 
            // LabelAmount
            // 
            this.LabelAmount.AutoSize = true;
            this.LabelAmount.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LabelAmount.Location = new System.Drawing.Point(70, 51);
            this.LabelAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelAmount.Name = "LabelAmount";
            this.LabelAmount.Size = new System.Drawing.Size(110, 31);
            this.LabelAmount.TabIndex = 1;
            this.LabelAmount.Text = "貸款金額";
            // 
            // Txt_Amount
            // 
            this.Txt_Amount.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Txt_Amount.Location = new System.Drawing.Point(196, 43);
            this.Txt_Amount.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Amount.Name = "Txt_Amount";
            this.Txt_Amount.Size = new System.Drawing.Size(134, 29);
            this.Txt_Amount.TabIndex = 2;
            // 
            // LabelDue
            // 
            this.LabelDue.AutoSize = true;
            this.LabelDue.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LabelDue.Location = new System.Drawing.Point(70, 92);
            this.LabelDue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelDue.Name = "LabelDue";
            this.LabelDue.Size = new System.Drawing.Size(102, 31);
            this.LabelDue.TabIndex = 3;
            this.LabelDue.Text = "期限(年)";
            // 
            // LabelPercent
            // 
            this.LabelPercent.AutoSize = true;
            this.LabelPercent.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LabelPercent.Location = new System.Drawing.Point(70, 141);
            this.LabelPercent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelPercent.Name = "LabelPercent";
            this.LabelPercent.Size = new System.Drawing.Size(100, 31);
            this.LabelPercent.TabIndex = 5;
            this.LabelPercent.Text = "利率(%)";
            // 
            // LabelFirstPay
            // 
            this.LabelFirstPay.AutoSize = true;
            this.LabelFirstPay.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LabelFirstPay.Location = new System.Drawing.Point(70, 182);
            this.LabelFirstPay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelFirstPay.Name = "LabelFirstPay";
            this.LabelFirstPay.Size = new System.Drawing.Size(86, 31);
            this.LabelFirstPay.TabIndex = 7;
            this.LabelFirstPay.Text = "頭期款";
            // 
            // Txt_Due
            // 
            this.Txt_Due.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Txt_Due.Location = new System.Drawing.Point(196, 92);
            this.Txt_Due.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Due.Name = "Txt_Due";
            this.Txt_Due.Size = new System.Drawing.Size(134, 29);
            this.Txt_Due.TabIndex = 8;
            // 
            // Txt_Percent
            // 
            this.Txt_Percent.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Txt_Percent.Location = new System.Drawing.Point(196, 141);
            this.Txt_Percent.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Percent.Name = "Txt_Percent";
            this.Txt_Percent.Size = new System.Drawing.Size(134, 29);
            this.Txt_Percent.TabIndex = 9;
            // 
            // Txt_FirstPay
            // 
            this.Txt_FirstPay.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Txt_FirstPay.Location = new System.Drawing.Point(196, 187);
            this.Txt_FirstPay.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_FirstPay.Name = "Txt_FirstPay";
            this.Txt_FirstPay.Size = new System.Drawing.Size(134, 29);
            this.Txt_FirstPay.TabIndex = 10;
            // 
            // BTN_Total
            // 
            this.BTN_Total.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BTN_Total.Location = new System.Drawing.Point(214, 263);
            this.BTN_Total.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_Total.Name = "BTN_Total";
            this.BTN_Total.Size = new System.Drawing.Size(134, 42);
            this.BTN_Total.TabIndex = 11;
            this.BTN_Total.Text = "總付款";
            this.BTN_Total.UseVisualStyleBackColor = true;
            this.BTN_Total.Click += new System.EventHandler(this.BTN_Total_Click);
            // 
            // BTN_Report
            // 
            this.BTN_Report.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BTN_Report.Location = new System.Drawing.Point(414, 263);
            this.BTN_Report.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_Report.Name = "BTN_Report";
            this.BTN_Report.Size = new System.Drawing.Size(114, 42);
            this.BTN_Report.TabIndex = 12;
            this.BTN_Report.Text = "Report";
            this.BTN_Report.UseVisualStyleBackColor = true;
            this.BTN_Report.Click += new System.EventHandler(this.BTN_Report_Click);
            // 
            // Frm_Loan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.Controls.Add(this.BTN_Report);
            this.Controls.Add(this.BTN_Total);
            this.Controls.Add(this.Txt_FirstPay);
            this.Controls.Add(this.Txt_Percent);
            this.Controls.Add(this.Txt_Due);
            this.Controls.Add(this.LabelFirstPay);
            this.Controls.Add(this.LabelPercent);
            this.Controls.Add(this.LabelDue);
            this.Controls.Add(this.Txt_Amount);
            this.Controls.Add(this.LabelAmount);
            this.Controls.Add(this.BTN_PMT);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frm_Loan";
            this.Text = "Frm_Loan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_PMT;
        private System.Windows.Forms.Label LabelAmount;
        private System.Windows.Forms.Label LabelDue;
        private System.Windows.Forms.Label LabelPercent;
        private System.Windows.Forms.Label LabelFirstPay;
        private System.Windows.Forms.Button BTN_Total;
        private System.Windows.Forms.Button BTN_Report;
        public System.Windows.Forms.TextBox Txt_Amount;
        public System.Windows.Forms.TextBox Txt_Due;
        public System.Windows.Forms.TextBox Txt_Percent;
        public System.Windows.Forms.TextBox Txt_FirstPay;
    }
}