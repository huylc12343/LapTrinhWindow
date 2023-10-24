namespace WindowsFormsApp1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNhapSo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbPrime = new System.Windows.Forms.Label();
            this.lbSquareNum = new System.Windows.Forms.Label();
            this.lbCompleteNum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập số n:";
            // 
            // txtNhapSo
            // 
            this.txtNhapSo.Location = new System.Drawing.Point(94, 12);
            this.txtNhapSo.Name = "txtNhapSo";
            this.txtNhapSo.Size = new System.Drawing.Size(100, 20);
            this.txtNhapSo.TabIndex = 1;
            this.txtNhapSo.TextChanged += new System.EventHandler(this.txtNhapSo_TextChanged);
            this.txtNhapSo.Leave += new System.EventHandler(this.txtNhapSo_Leave);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(296, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Hiển thị";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // lbPrime
            // 
            this.lbPrime.AutoSize = true;
            this.lbPrime.Location = new System.Drawing.Point(15, 62);
            this.lbPrime.Name = "lbPrime";
            this.lbPrime.Size = new System.Drawing.Size(144, 13);
            this.lbPrime.TabIndex = 3;
            this.lbPrime.Text = "Các số nguyên tố nhỏ hơn n:";
            // 
            // lbSquareNum
            // 
            this.lbSquareNum.AutoSize = true;
            this.lbSquareNum.Location = new System.Drawing.Point(15, 90);
            this.lbSquareNum.Name = "lbSquareNum";
            this.lbSquareNum.Size = new System.Drawing.Size(164, 13);
            this.lbSquareNum.TabIndex = 4;
            this.lbSquareNum.Text = "Các số chính phương nhỏ hơn n:";
            // 
            // lbCompleteNum
            // 
            this.lbCompleteNum.AutoSize = true;
            this.lbCompleteNum.Location = new System.Drawing.Point(15, 116);
            this.lbCompleteNum.Name = "lbCompleteNum";
            this.lbCompleteNum.Size = new System.Drawing.Size(150, 13);
            this.lbCompleteNum.TabIndex = 5;
            this.lbCompleteNum.Text = "Các số hoàn chỉnh nhỏ hơn n:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 193);
            this.Controls.Add(this.lbCompleteNum);
            this.Controls.Add(this.lbSquareNum);
            this.Controls.Add(this.lbPrime);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtNhapSo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNhapSo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbPrime;
        private System.Windows.Forms.Label lbSquareNum;
        private System.Windows.Forms.Label lbCompleteNum;
    }
}

