namespace C_作業
{
    partial class Frm_MyCalc
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
            this.labelNum1 = new System.Windows.Forms.Label();
            this.labelNum2 = new System.Windows.Forms.Label();
            this.txtBox1 = new System.Windows.Forms.TextBox();
            this.txtBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelAns = new System.Windows.Forms.Label();
            this.txtBoxAns = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNum1
            // 
            this.labelNum1.AutoSize = true;
            this.labelNum1.Location = new System.Drawing.Point(105, 54);
            this.labelNum1.Name = "labelNum1";
            this.labelNum1.Size = new System.Drawing.Size(64, 15);
            this.labelNum1.TabIndex = 0;
            this.labelNum1.Text = "Number1:";
            // 
            // labelNum2
            // 
            this.labelNum2.AutoSize = true;
            this.labelNum2.Location = new System.Drawing.Point(105, 96);
            this.labelNum2.Name = "labelNum2";
            this.labelNum2.Size = new System.Drawing.Size(64, 15);
            this.labelNum2.TabIndex = 1;
            this.labelNum2.Text = "Number2:";
            // 
            // txtBox1
            // 
            this.txtBox1.Location = new System.Drawing.Point(203, 51);
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.Size = new System.Drawing.Size(128, 25);
            this.txtBox1.TabIndex = 2;
            // 
            // txtBox2
            // 
            this.txtBox2.Location = new System.Drawing.Point(203, 93);
            this.txtBox2.Name = "txtBox2";
            this.txtBox2.Size = new System.Drawing.Size(128, 25);
            this.txtBox2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(399, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "= = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =\r\n";
            // 
            // labelAns
            // 
            this.labelAns.AutoSize = true;
            this.labelAns.Location = new System.Drawing.Point(105, 175);
            this.labelAns.Name = "labelAns";
            this.labelAns.Size = new System.Drawing.Size(54, 15);
            this.labelAns.TabIndex = 5;
            this.labelAns.Text = "Answer:";
            // 
            // txtBoxAns
            // 
            this.txtBoxAns.Enabled = false;
            this.txtBoxAns.Location = new System.Drawing.Point(203, 165);
            this.txtBoxAns.Name = "txtBoxAns";
            this.txtBoxAns.Size = new System.Drawing.Size(128, 25);
            this.txtBoxAns.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(386, 51);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(57, 24);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnMin
            // 
            this.btnMin.Location = new System.Drawing.Point(386, 81);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(57, 24);
            this.btnMin.TabIndex = 8;
            this.btnMin.Text = "-";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnMul
            // 
            this.btnMul.Location = new System.Drawing.Point(386, 114);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(57, 24);
            this.btnMul.TabIndex = 9;
            this.btnMul.Text = "*";
            this.btnMul.UseVisualStyleBackColor = true;
            this.btnMul.Click += new System.EventHandler(this.btnMul_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(386, 170);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(57, 24);
            this.btnDiv.TabIndex = 10;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // Frm_MyCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 284);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMul);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtBoxAns);
            this.Controls.Add(this.labelAns);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBox2);
            this.Controls.Add(this.txtBox1);
            this.Controls.Add(this.labelNum2);
            this.Controls.Add(this.labelNum1);
            this.Name = "Frm_MyCalc";
            this.Text = "Frm_MyCalc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNum1;
        private System.Windows.Forms.Label labelNum2;
        private System.Windows.Forms.TextBox txtBox1;
        private System.Windows.Forms.TextBox txtBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelAns;
        private System.Windows.Forms.TextBox txtBoxAns;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btnDiv;
    }
}