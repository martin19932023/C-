namespace C_作業
{
    partial class Frm_POS
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
            this.groupBoxManu = new System.Windows.Forms.GroupBox();
            this.BTN_Chic = new System.Windows.Forms.Button();
            this.BTN_Ham = new System.Windows.Forms.Button();
            this.BTN_Coke = new System.Windows.Forms.Button();
            this.BTN_Fries = new System.Windows.Forms.Button();
            this.groupBoxPrice = new System.Windows.Forms.GroupBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.groupBoxPayment = new System.Windows.Forms.GroupBox();
            this.labelCredit = new System.Windows.Forms.Label();
            this.btnCredit = new System.Windows.Forms.Button();
            this.btnCash = new System.Windows.Forms.Button();
            this.groupBoxBuyList = new System.Windows.Forms.GroupBox();
            this.BTN_Clear = new System.Windows.Forms.Button();
            this.TxtList = new System.Windows.Forms.TextBox();
            this.groupBoxManu.SuspendLayout();
            this.groupBoxPrice.SuspendLayout();
            this.groupBoxPayment.SuspendLayout();
            this.groupBoxBuyList.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxManu
            // 
            this.groupBoxManu.Controls.Add(this.BTN_Chic);
            this.groupBoxManu.Controls.Add(this.BTN_Ham);
            this.groupBoxManu.Controls.Add(this.BTN_Coke);
            this.groupBoxManu.Controls.Add(this.BTN_Fries);
            this.groupBoxManu.Location = new System.Drawing.Point(18, 26);
            this.groupBoxManu.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxManu.Name = "groupBoxManu";
            this.groupBoxManu.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxManu.Size = new System.Drawing.Size(211, 285);
            this.groupBoxManu.TabIndex = 0;
            this.groupBoxManu.TabStop = false;
            this.groupBoxManu.Text = "菜單Manu";
            // 
            // BTN_Chic
            // 
            this.BTN_Chic.Location = new System.Drawing.Point(113, 162);
            this.BTN_Chic.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_Chic.Name = "BTN_Chic";
            this.BTN_Chic.Size = new System.Drawing.Size(82, 102);
            this.BTN_Chic.TabIndex = 6;
            this.BTN_Chic.Text = "炸雞\r\nFried Chicken\r\nNT$ 200";
            this.BTN_Chic.UseVisualStyleBackColor = true;
            this.BTN_Chic.Click += new System.EventHandler(this.BTN_Chic_Click);
            // 
            // BTN_Ham
            // 
            this.BTN_Ham.Location = new System.Drawing.Point(14, 162);
            this.BTN_Ham.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_Ham.Name = "BTN_Ham";
            this.BTN_Ham.Size = new System.Drawing.Size(82, 102);
            this.BTN_Ham.TabIndex = 5;
            this.BTN_Ham.Text = "漢堡\r\nHamberger\r\nNT$ 150";
            this.BTN_Ham.UseVisualStyleBackColor = true;
            this.BTN_Ham.Click += new System.EventHandler(this.BTN_Ham_Click);
            // 
            // BTN_Coke
            // 
            this.BTN_Coke.Location = new System.Drawing.Point(113, 44);
            this.BTN_Coke.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_Coke.Name = "BTN_Coke";
            this.BTN_Coke.Size = new System.Drawing.Size(82, 102);
            this.BTN_Coke.TabIndex = 4;
            this.BTN_Coke.Text = "可樂\r\n Coke Cola\r\nNT$ 40\r\n";
            this.BTN_Coke.UseVisualStyleBackColor = true;
            this.BTN_Coke.Click += new System.EventHandler(this.BTN_Coke_Click);
            // 
            // BTN_Fries
            // 
            this.BTN_Fries.Location = new System.Drawing.Point(14, 44);
            this.BTN_Fries.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_Fries.Name = "BTN_Fries";
            this.BTN_Fries.Size = new System.Drawing.Size(82, 102);
            this.BTN_Fries.TabIndex = 0;
            this.BTN_Fries.Text = "大薯\r\nFrench Fries\r\nNT$ 90\r\n";
            this.BTN_Fries.UseVisualStyleBackColor = true;
            this.BTN_Fries.Click += new System.EventHandler(this.btnFries_Click);
            // 
            // groupBoxPrice
            // 
            this.groupBoxPrice.Controls.Add(this.textBoxPrice);
            this.groupBoxPrice.Location = new System.Drawing.Point(246, 34);
            this.groupBoxPrice.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxPrice.Name = "groupBoxPrice";
            this.groupBoxPrice.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxPrice.Size = new System.Drawing.Size(161, 80);
            this.groupBoxPrice.TabIndex = 1;
            this.groupBoxPrice.TabStop = false;
            this.groupBoxPrice.Text = "總金額 Total Price";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(21, 30);
            this.textBoxPrice.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(120, 22);
            this.textBoxPrice.TabIndex = 0;
            // 
            // groupBoxPayment
            // 
            this.groupBoxPayment.Controls.Add(this.labelCredit);
            this.groupBoxPayment.Controls.Add(this.btnCredit);
            this.groupBoxPayment.Controls.Add(this.btnCash);
            this.groupBoxPayment.Location = new System.Drawing.Point(248, 162);
            this.groupBoxPayment.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxPayment.Name = "groupBoxPayment";
            this.groupBoxPayment.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxPayment.Size = new System.Drawing.Size(170, 118);
            this.groupBoxPayment.TabIndex = 2;
            this.groupBoxPayment.TabStop = false;
            this.groupBoxPayment.Text = "付款方式 ";
            // 
            // labelCredit
            // 
            this.labelCredit.AutoSize = true;
            this.labelCredit.Location = new System.Drawing.Point(62, 87);
            this.labelCredit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCredit.Name = "labelCredit";
            this.labelCredit.Size = new System.Drawing.Size(109, 12);
            this.labelCredit.TabIndex = 2;
            this.labelCredit.Text = "信用卡享九折優惠!!";
            // 
            // btnCredit
            // 
            this.btnCredit.Location = new System.Drawing.Point(82, 26);
            this.btnCredit.Margin = new System.Windows.Forms.Padding(2);
            this.btnCredit.Name = "btnCredit";
            this.btnCredit.Size = new System.Drawing.Size(64, 46);
            this.btnCredit.TabIndex = 1;
            this.btnCredit.Text = "信用卡";
            this.btnCredit.UseVisualStyleBackColor = true;
            this.btnCredit.Click += new System.EventHandler(this.btnCredit_Click);
            // 
            // btnCash
            // 
            this.btnCash.Location = new System.Drawing.Point(13, 26);
            this.btnCash.Margin = new System.Windows.Forms.Padding(2);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(64, 46);
            this.btnCash.TabIndex = 0;
            this.btnCash.Text = "現金";
            this.btnCash.UseVisualStyleBackColor = true;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // groupBoxBuyList
            // 
            this.groupBoxBuyList.Controls.Add(this.TxtList);
            this.groupBoxBuyList.Controls.Add(this.BTN_Clear);
            this.groupBoxBuyList.Location = new System.Drawing.Point(418, 48);
            this.groupBoxBuyList.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxBuyList.Name = "groupBoxBuyList";
            this.groupBoxBuyList.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxBuyList.Size = new System.Drawing.Size(204, 262);
            this.groupBoxBuyList.TabIndex = 3;
            this.groupBoxBuyList.TabStop = false;
            this.groupBoxBuyList.Text = "購物清單 List";
            // 
            // BTN_Clear
            // 
            this.BTN_Clear.Location = new System.Drawing.Point(83, 228);
            this.BTN_Clear.Name = "BTN_Clear";
            this.BTN_Clear.Size = new System.Drawing.Size(83, 34);
            this.BTN_Clear.TabIndex = 1;
            this.BTN_Clear.Text = "清除清單";
            this.BTN_Clear.UseVisualStyleBackColor = true;
            this.BTN_Clear.Click += new System.EventHandler(this.BTN_Clear_Click);
            // 
            // TxtList
            // 
            this.TxtList.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TxtList.Location = new System.Drawing.Point(18, 25);
            this.TxtList.Multiline = true;
            this.TxtList.Name = "TxtList";
            this.TxtList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtList.Size = new System.Drawing.Size(170, 188);
            this.TxtList.TabIndex = 4;
            // 
            // Frm_POS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 410);
            this.Controls.Add(this.groupBoxBuyList);
            this.Controls.Add(this.groupBoxPayment);
            this.Controls.Add(this.groupBoxPrice);
            this.Controls.Add(this.groupBoxManu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frm_POS";
            this.Text = "Frm_POS";
            this.groupBoxManu.ResumeLayout(false);
            this.groupBoxPrice.ResumeLayout(false);
            this.groupBoxPrice.PerformLayout();
            this.groupBoxPayment.ResumeLayout(false);
            this.groupBoxPayment.PerformLayout();
            this.groupBoxBuyList.ResumeLayout(false);
            this.groupBoxBuyList.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxManu;
        private System.Windows.Forms.GroupBox groupBoxPrice;
        private System.Windows.Forms.GroupBox groupBoxPayment;
        private System.Windows.Forms.Label labelCredit;
        private System.Windows.Forms.Button btnCredit;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.Button BTN_Ham;
        private System.Windows.Forms.Button BTN_Chic;
        private System.Windows.Forms.Button BTN_Clear;
        public System.Windows.Forms.Button BTN_Fries;
        public System.Windows.Forms.TextBox textBoxPrice;
        public System.Windows.Forms.Button BTN_Coke;
        private System.Windows.Forms.TextBox TxtList;
        public System.Windows.Forms.GroupBox groupBoxBuyList;
    }
}