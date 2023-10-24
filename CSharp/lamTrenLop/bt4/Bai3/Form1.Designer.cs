namespace Bai3
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
            this.txtVal1 = new System.Windows.Forms.TextBox();
            this.txtVal2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbChia = new System.Windows.Forms.RadioButton();
            this.rbNhan = new System.Windows.Forms.RadioButton();
            this.rbTru = new System.Windows.Forms.RadioButton();
            this.rbCong = new System.Windows.Forms.RadioButton();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtVal1
            // 
            this.txtVal1.Location = new System.Drawing.Point(221, 47);
            this.txtVal1.Name = "txtVal1";
            this.txtVal1.Size = new System.Drawing.Size(263, 20);
            this.txtVal1.TabIndex = 1;
            this.txtVal1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtVal2
            // 
            this.txtVal2.Location = new System.Drawing.Point(221, 90);
            this.txtVal2.Name = "txtVal2";
            this.txtVal2.Size = new System.Drawing.Size(263, 20);
            this.txtVal2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số 2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbChia);
            this.groupBox1.Controls.Add(this.rbNhan);
            this.groupBox1.Controls.Add(this.rbTru);
            this.groupBox1.Controls.Add(this.rbCong);
            this.groupBox1.Location = new System.Drawing.Point(101, 137);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(436, 73);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phép tính";
            // 
            // rbChia
            // 
            this.rbChia.AutoSize = true;
            this.rbChia.Location = new System.Drawing.Point(337, 29);
            this.rbChia.Name = "rbChia";
            this.rbChia.Size = new System.Drawing.Size(46, 17);
            this.rbChia.TabIndex = 3;
            this.rbChia.Text = "Chia";
            this.rbChia.UseVisualStyleBackColor = true;
            this.rbChia.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbChia_MouseClick);
            // 
            // rbNhan
            // 
            this.rbNhan.AutoSize = true;
            this.rbNhan.Location = new System.Drawing.Point(237, 29);
            this.rbNhan.Name = "rbNhan";
            this.rbNhan.Size = new System.Drawing.Size(54, 17);
            this.rbNhan.TabIndex = 2;
            this.rbNhan.Text = "Nhân ";
            this.rbNhan.UseVisualStyleBackColor = true;
            this.rbNhan.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbNhan_MouseClick);
            // 
            // rbTru
            // 
            this.rbTru.AutoSize = true;
            this.rbTru.Location = new System.Drawing.Point(134, 29);
            this.rbTru.Name = "rbTru";
            this.rbTru.Size = new System.Drawing.Size(41, 17);
            this.rbTru.TabIndex = 1;
            this.rbTru.Text = "Trừ";
            this.rbTru.UseVisualStyleBackColor = true;
            this.rbTru.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbTru_MouseClick);
            // 
            // rbCong
            // 
            this.rbCong.AutoSize = true;
            this.rbCong.Location = new System.Drawing.Point(40, 29);
            this.rbCong.Name = "rbCong";
            this.rbCong.Size = new System.Drawing.Size(53, 17);
            this.rbCong.TabIndex = 0;
            this.rbCong.Text = "Cộng ";
            this.rbCong.UseVisualStyleBackColor = true;
            this.rbCong.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbCong_MouseClick);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(221, 228);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(263, 20);
            this.txtResult.TabIndex = 6;
            this.txtResult.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kết quả";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 289);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtVal2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtVal1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVal1;
        private System.Windows.Forms.TextBox txtVal2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbChia;
        private System.Windows.Forms.RadioButton rbNhan;
        private System.Windows.Forms.RadioButton rbTru;
        private System.Windows.Forms.RadioButton rbCong;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label3;
    }
}

