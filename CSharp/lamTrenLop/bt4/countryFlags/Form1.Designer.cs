namespace countryFlags
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
            this.rdVN = new System.Windows.Forms.RadioButton();
            this.rdUSA = new System.Windows.Forms.RadioButton();
            this.rdItaly = new System.Windows.Forms.RadioButton();
            this.rdPhillip = new System.Windows.Forms.RadioButton();
            this.countryFlags = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.countryFlags)).BeginInit();
            this.SuspendLayout();
            // 
            // rdVN
            // 
            this.rdVN.AutoSize = true;
            this.rdVN.Checked = true;
            this.rdVN.Location = new System.Drawing.Point(36, 56);
            this.rdVN.Name = "rdVN";
            this.rdVN.Size = new System.Drawing.Size(68, 17);
            this.rdVN.TabIndex = 1;
            this.rdVN.TabStop = true;
            this.rdVN.Text = "Việt Nam";
            this.rdVN.UseVisualStyleBackColor = true;
            this.rdVN.CheckedChanged += new System.EventHandler(this.rdVN_CheckedChanged);
            this.rdVN.Click += new System.EventHandler(this.rdVN_Click);
            // 
            // rdUSA
            // 
            this.rdUSA.AutoSize = true;
            this.rdUSA.Location = new System.Drawing.Point(36, 116);
            this.rdUSA.Name = "rdUSA";
            this.rdUSA.Size = new System.Drawing.Size(47, 17);
            this.rdUSA.TabIndex = 2;
            this.rdUSA.Text = "USA";
            this.rdUSA.UseVisualStyleBackColor = true;
            this.rdUSA.Click += new System.EventHandler(this.rdUSA_Click);
            // 
            // rdItaly
            // 
            this.rdItaly.AutoSize = true;
            this.rdItaly.Location = new System.Drawing.Point(36, 176);
            this.rdItaly.Name = "rdItaly";
            this.rdItaly.Size = new System.Drawing.Size(55, 17);
            this.rdItaly.TabIndex = 3;
            this.rdItaly.Text = "ITALY";
            this.rdItaly.UseVisualStyleBackColor = true;
            this.rdItaly.Click += new System.EventHandler(this.rdItaly_Click);
            // 
            // rdPhillip
            // 
            this.rdPhillip.AutoSize = true;
            this.rdPhillip.Location = new System.Drawing.Point(36, 236);
            this.rdPhillip.Name = "rdPhillip";
            this.rdPhillip.Size = new System.Drawing.Size(66, 17);
            this.rdPhillip.TabIndex = 4;
            this.rdPhillip.Text = "Phillipine";
            this.rdPhillip.UseVisualStyleBackColor = true;
            this.rdPhillip.Click += new System.EventHandler(this.rdPhillip_Click);
            // 
            // countryFlags
            // 
            this.countryFlags.Location = new System.Drawing.Point(280, 56);
            this.countryFlags.Name = "countryFlags";
            this.countryFlags.Size = new System.Drawing.Size(334, 207);
            this.countryFlags.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.countryFlags.TabIndex = 5;
            this.countryFlags.TabStop = false;
            this.countryFlags.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 339);
            this.Controls.Add(this.countryFlags);
            this.Controls.Add(this.rdPhillip);
            this.Controls.Add(this.rdItaly);
            this.Controls.Add(this.rdUSA);
            this.Controls.Add(this.rdVN);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.countryFlags)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdVN;
        private System.Windows.Forms.RadioButton rdUSA;
        private System.Windows.Forms.RadioButton rdItaly;
        private System.Windows.Forms.RadioButton rdPhillip;
        private System.Windows.Forms.PictureBox countryFlags;
    }
}

