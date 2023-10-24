namespace tinhTienKhamRang
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
            this.txtBoxTenKH = new System.Windows.Forms.TextBox();
            this.chBCaoVoi = new System.Windows.Forms.CheckBox();
            this.chBTayTrang = new System.Windows.Forms.CheckBox();
            this.chBChupHinh = new System.Windows.Forms.CheckBox();
            this.chBLayCao = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numHanRang = new System.Windows.Forms.NumericUpDown();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.grBBangGIa = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBoxTongTien = new System.Windows.Forms.TextBox();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numHanRang)).BeginInit();
            this.grBBangGIa.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên khách hàng";
            // 
            // txtBoxTenKH
            // 
            this.txtBoxTenKH.Location = new System.Drawing.Point(123, 10);
            this.txtBoxTenKH.Name = "txtBoxTenKH";
            this.txtBoxTenKH.Size = new System.Drawing.Size(100, 20);
            this.txtBoxTenKH.TabIndex = 1;
            this.txtBoxTenKH.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // chBCaoVoi
            // 
            this.chBCaoVoi.AutoSize = true;
            this.chBCaoVoi.Location = new System.Drawing.Point(6, 23);
            this.chBCaoVoi.Name = "chBCaoVoi";
            this.chBCaoVoi.Size = new System.Drawing.Size(62, 17);
            this.chBCaoVoi.TabIndex = 3;
            this.chBCaoVoi.Text = "Cạo vôi";
            this.chBCaoVoi.UseVisualStyleBackColor = true;
            // 
            // chBTayTrang
            // 
            this.chBTayTrang.AutoSize = true;
            this.chBTayTrang.Location = new System.Drawing.Point(6, 46);
            this.chBTayTrang.Name = "chBTayTrang";
            this.chBTayTrang.Size = new System.Drawing.Size(71, 17);
            this.chBTayTrang.TabIndex = 4;
            this.chBTayTrang.Text = "Tẩy tráng";
            this.chBTayTrang.UseVisualStyleBackColor = true;
            // 
            // chBChupHinh
            // 
            this.chBChupHinh.AutoSize = true;
            this.chBChupHinh.Location = new System.Drawing.Point(6, 69);
            this.chBChupHinh.Name = "chBChupHinh";
            this.chBChupHinh.Size = new System.Drawing.Size(74, 17);
            this.chBChupHinh.TabIndex = 5;
            this.chBChupHinh.Text = "Chụp hình";
            this.chBChupHinh.UseVisualStyleBackColor = true;
            // 
            // chBLayCao
            // 
            this.chBLayCao.AutoSize = true;
            this.chBLayCao.Location = new System.Drawing.Point(6, 92);
            this.chBLayCao.Name = "chBLayCao";
            this.chBLayCao.Size = new System.Drawing.Size(64, 17);
            this.chBLayCao.TabIndex = 6;
            this.chBLayCao.Text = "Lấy cao";
            this.chBLayCao.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Hàn răng";
            // 
            // numHanRang
            // 
            this.numHanRang.Location = new System.Drawing.Point(62, 117);
            this.numHanRang.Name = "numHanRang";
            this.numHanRang.Size = new System.Drawing.Size(46, 20);
            this.numHanRang.TabIndex = 8;
            this.numHanRang.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // grBBangGIa
            // 
            this.grBBangGIa.Controls.Add(this.label7);
            this.grBBangGIa.Controls.Add(this.label6);
            this.grBBangGIa.Controls.Add(this.label5);
            this.grBBangGIa.Controls.Add(this.label4);
            this.grBBangGIa.Controls.Add(this.label2);
            this.grBBangGIa.Controls.Add(this.chBChupHinh);
            this.grBBangGIa.Controls.Add(this.label3);
            this.grBBangGIa.Controls.Add(this.chBCaoVoi);
            this.grBBangGIa.Controls.Add(this.numHanRang);
            this.grBBangGIa.Controls.Add(this.chBLayCao);
            this.grBBangGIa.Controls.Add(this.chBTayTrang);
            this.grBBangGIa.Location = new System.Drawing.Point(16, 49);
            this.grBBangGIa.Name = "grBBangGIa";
            this.grBBangGIa.Size = new System.Drawing.Size(310, 179);
            this.grBBangGIa.TabIndex = 9;
            this.grBBangGIa.TabStop = false;
            this.grBBangGIa.Text = "Bàng giá";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(160, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "90000VNĐ/Cái";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(160, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "100000VNĐ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(160, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "150000VNĐ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "1200000VNĐ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "100000VNĐ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 241);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Tổng tiền";
            // 
            // txtBoxTongTien
            // 
            this.txtBoxTongTien.Location = new System.Drawing.Point(143, 238);
            this.txtBoxTongTien.Name = "txtBoxTongTien";
            this.txtBoxTongTien.ReadOnly = true;
            this.txtBoxTongTien.Size = new System.Drawing.Size(136, 20);
            this.txtBoxTongTien.TabIndex = 15;
            this.txtBoxTongTien.Text = "0";
            this.txtBoxTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.Location = new System.Drawing.Point(24, 293);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(75, 23);
            this.btnTinhTien.TabIndex = 16;
            this.btnTinhTien.Text = "Tính tiền";
            this.btnTinhTien.UseVisualStyleBackColor = true;
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(204, 293);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 17;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 328);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTinhTien);
            this.Controls.Add(this.txtBoxTongTien);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.grBBangGIa);
            this.Controls.Add(this.txtBoxTenKH);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numHanRang)).EndInit();
            this.grBBangGIa.ResumeLayout(false);
            this.grBBangGIa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxTenKH;
        private System.Windows.Forms.CheckBox chBCaoVoi;
        private System.Windows.Forms.CheckBox chBTayTrang;
        private System.Windows.Forms.CheckBox chBChupHinh;
        private System.Windows.Forms.CheckBox chBLayCao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numHanRang;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.GroupBox grBBangGIa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBoxTongTien;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.Button btnThoat;
    }
}

