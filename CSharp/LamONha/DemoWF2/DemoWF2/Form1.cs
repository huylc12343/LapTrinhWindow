using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoWF2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        long thanhtien = 0;

        private void button69_Click(object sender, EventArgs e)
        {
            Control a = (Control)sender;
         
            if (a.BackColor == Color.DarkRed) 
            {
                if (a.Text.Contains("A"))
                {
                    a.BackColor = Color.FromArgb(192, 255, 192);
                    thanhtien -= 25000;
                }
                else if (a.Text.Contains("B"))
                {
                    a.BackColor = Color.Cyan;
                    thanhtien -= 30000;
                }
                else if (a.Text.Contains("C"))
                {
                    a.BackColor = Color.FromArgb(255, 192, 192);
                    thanhtien -= 35000;
                }
                else if (a.Text.Contains("D"))
                {  
                    a.BackColor = Color.FromArgb(255, 255, 192);
                    thanhtien -= 40000;
                }
                else if (a.Text.Contains("E"))
                {
                    thanhtien += 50000;
                }
                else if (a.Text.Contains("F"))
                {
                    thanhtien += 45000;

                }

            }
            else
            {
                Color color = Color.DarkRed;
                a.BackColor = color;
                if (a.Text.Contains("A"))
                {
                    thanhtien += 25000;
                }
                else if (a.Text.Contains("B"))
                {
                    thanhtien += 30000;
                }
                else if (a.Text.Contains("C"))
                {
                    thanhtien += 35000;
                }
                else if (a.Text.Contains("D"))
                {
                    thanhtien += 40000;
                }
                else if (a.Text.Contains("E"))
                {
                    thanhtien += 50000;
                }
                else if (a.Text.Contains("F"))
                {
                    thanhtien += 45000;

                }
            }
            
            lblThanhTien.Text = thanhtien.ToString() + "đ";
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            DialogResult okay = MessageBox.Show("Bạn có xác nhận thanh toán hay không?","Thông báo",MessageBoxButtons.OKCancel);
            if (okay == DialogResult.OK)
            {
                foreach(Control a in tableLayoutPanel1.Controls) { 
                    if (a.BackColor == Color.DarkRed)
                    {
                        a.BackColor = Color.Green;
                        a.Enabled = false;
                        thanhtien = 0;
                        lblThanhTien.Text = thanhtien.ToString() + "đ";
                    }
                }
            }
        }
        //comboBox1.Text()

        private void lblTenPhim_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            lblTenPhim.Text = comboBox1.GetItemText(comboBox1.SelectedItem);
        }

    }
}
