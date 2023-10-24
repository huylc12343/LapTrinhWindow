using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("ban co chac chan thoat khong?", "thong bao!", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnShow_MouseClick(object sender, MouseEventArgs e)
        {
            var ten = txtYourName.Text;
            var nam = txtYear.Text;
            if (ten == ""|| nam == "")
            {
                MessageBox.Show($"Vui long nhap thong tin", "Thông báo", MessageBoxButtons.OK);

            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txtYourName.Text, ".[a-zA-Z ]"))
            {
                MessageBox.Show("Tên không chứa số","Thông báo",MessageBoxButtons.OK);
                txtYourName.Text.Remove(txtYourName.Text.Length - 1);
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(txtYourName.Text, ".[a-zA-Z ]"))
            {
                MessageBox.Show("Năm sinh chỉ chứa số", "Thông báo", MessageBoxButtons.OK);
                txtYourName.Text.Remove(txtYourName.Text.Length - 1);
            }
            else
            {
                MessageBox.Show($"Ten: {ten}\nNam sinh: {nam}", "Thông tin");

            }
        }

        private void btnClear_MouseClick(object sender, MouseEventArgs e)
        {
            txtYourName.Text = "";
            txtYear.Text = "";
        }

        private void btnExit_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
    }
}
