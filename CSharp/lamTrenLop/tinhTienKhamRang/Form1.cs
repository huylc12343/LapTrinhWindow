using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tinhTienKhamRang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        long tongtien = 0;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            

        }
        private long TinhTienHanRang()
        {
            int SoLuong = int.Parse(numHanRang.Text.ToString());
            return (SoLuong*90000);
        }

        

        private void chBCaoVoi_Click(object sender, EventArgs e)
        {
            
        }

        private void chBTayTrang_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            tongtien = 0;
            if (chBCaoVoi.Checked == true)
            {
                tongtien += 100000;
            }
            if (chBTayTrang.Checked == true)
            {
                tongtien += 1200000;
            }
            if (chBChupHinh.Checked == true)
            {
                tongtien += 150000;
            }
            if (chBLayCao.Checked == true)
            {
                tongtien += 100000;
            }
            long hanrang = TinhTienHanRang();
            tongtien += hanrang;
            txtBoxTongTien.Text = tongtien.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
