using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtResult.ReadOnly = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void rbCong_MouseClick(object sender, MouseEventArgs e)
        {
            var ketqua = double.Parse( txtVal1.Text.ToString()) + double.Parse(txtVal2.Text.ToString());
            txtResult.Text = ketqua.ToString();

        }

        private void rbTru_MouseClick(object sender, MouseEventArgs e)
        {
            var ketqua = double.Parse(txtVal1.Text.ToString()) - double.Parse(txtVal2.Text.ToString());
            txtResult.Text = ketqua.ToString();
        }

        private void rbNhan_MouseClick(object sender, MouseEventArgs e)
        {
            var ketqua = double.Parse(txtVal1.Text.ToString()) * double.Parse(txtVal2.Text.ToString());
            txtResult.Text = ketqua.ToString();
        }

        private void rbChia_MouseClick(object sender, MouseEventArgs e)
        {
            var ketqua = double.Parse(txtVal1.Text.ToString()) / double.Parse(txtVal2.Text.ToString());
            txtResult.Text = ketqua.ToString();
        }
    }
}
