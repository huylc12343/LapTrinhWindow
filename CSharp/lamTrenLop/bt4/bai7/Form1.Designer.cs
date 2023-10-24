namespace bai7
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnSumEvenNum = new System.Windows.Forms.Button();
            this.btnSumPrime = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lbUocSo = new System.Windows.Forms.ListBox();
            this.txtNhapSo = new System.Windows.Forms.TextBox();
            this.cbListSo = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbListSo);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.txtNhapSo);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 86);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập số";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbUocSo);
            this.groupBox2.Location = new System.Drawing.Point(373, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(278, 141);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách các ước số";
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(373, 176);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(278, 27);
            this.btnSum.TabIndex = 2;
            this.btnSum.Text = "Tổng các ước số";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btnSumEvenNum
            // 
            this.btnSumEvenNum.Location = new System.Drawing.Point(373, 219);
            this.btnSumEvenNum.Name = "btnSumEvenNum";
            this.btnSumEvenNum.Size = new System.Drawing.Size(278, 27);
            this.btnSumEvenNum.TabIndex = 3;
            this.btnSumEvenNum.Text = "Số lượng các ước só chẵn";
            this.btnSumEvenNum.UseVisualStyleBackColor = true;
            this.btnSumEvenNum.Click += new System.EventHandler(this.btnSumEvenNum_Click);
            // 
            // btnSumPrime
            // 
            this.btnSumPrime.Location = new System.Drawing.Point(373, 261);
            this.btnSumPrime.Name = "btnSumPrime";
            this.btnSumPrime.Size = new System.Drawing.Size(278, 27);
            this.btnSumPrime.TabIndex = 4;
            this.btnSumPrime.Text = "Số lượng các ước số nguyên tố";
            this.btnSumPrime.UseVisualStyleBackColor = true;
            this.btnSumPrime.Click += new System.EventHandler(this.btnSumPrime_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(184, 261);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 27);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Thoát";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(154, 20);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(85, 20);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lbUocSo
            // 
            this.lbUocSo.FormattingEnabled = true;
            this.lbUocSo.Location = new System.Drawing.Point(7, 20);
            this.lbUocSo.Name = "lbUocSo";
            this.lbUocSo.Size = new System.Drawing.Size(265, 108);
            this.lbUocSo.TabIndex = 0;
            // 
            // txtNhapSo
            // 
            this.txtNhapSo.Location = new System.Drawing.Point(7, 20);
            this.txtNhapSo.Name = "txtNhapSo";
            this.txtNhapSo.Size = new System.Drawing.Size(127, 20);
            this.txtNhapSo.TabIndex = 0;
            // 
            // cbListSo
            // 
            this.cbListSo.FormattingEnabled = true;
            this.cbListSo.Location = new System.Drawing.Point(7, 47);
            this.cbListSo.Name = "cbListSo";
            this.cbListSo.Size = new System.Drawing.Size(232, 21);
            this.cbListSo.TabIndex = 7;
            this.cbListSo.SelectedIndexChanged += new System.EventHandler(this.cbListSo_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 311);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSumPrime);
            this.Controls.Add(this.btnSumEvenNum);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbListSo;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtNhapSo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbUocSo;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnSumEvenNum;
        private System.Windows.Forms.Button btnSumPrime;
        private System.Windows.Forms.Button btnClose;
    }
}

