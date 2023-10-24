using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace bai7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cbListSo.Items.Contains(txtNhapSo.Text))
            {
                MessageBox.Show("Chuỗi tồn tại trong ComboBox!", "thông báo", MessageBoxButtons.OK);
            }
            else
            {
                cbListSo.Items.Add(txtNhapSo.Text);
            }
        }

        private void cbListSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbUocSo.Items.Clear();
            string selectedItem = cbListSo.SelectedItem.ToString();
            int number;
            number = int.Parse(selectedItem);
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    lbUocSo.Items.Add(i);
                }
            }
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            int sum = 0;
            foreach (var item in lbUocSo.Items)
            {
                int num = int.Parse(item.ToString());
                sum += num;
            }

            MessageBox.Show($"Tổng các ước số là: {sum}", "Thông báo");
        }

        private void btnSumEvenNum_Click(object sender, EventArgs e)
        {
            int sum = 0;
            foreach (var item in lbUocSo.Items)
            {
                int num = int.Parse(item.ToString());
                if (num % 2 == 0)
                {
                    sum += num;

                }
            }

            MessageBox.Show($"Tổng các ước số chẵn là: {sum}", "Thông báo");
        }

        private void btnSumPrime_Click(object sender, EventArgs e)
        {
            int n = int.Parse(cbListSo.SelectedItem.ToString());
            int sum = 0;
            for (int num = 2; num < n; num++)
            {
                bool isPrime = true;
                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    sum += num;
                }
                MessageBox.Show($"Tổng các ước số nguyên tố là: {sum}", "Thông báo");

            }

        }

    }
}
