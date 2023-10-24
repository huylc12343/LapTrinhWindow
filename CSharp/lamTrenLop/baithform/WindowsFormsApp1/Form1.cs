using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            Regex regex = new Regex("^[0-9]+$");
            if (!regex.IsMatch(txtNhapSo.Text))
            {
                MessageBox.Show("Chỉ được phép nhập số", "Thông báo");
            }
            else
            {
                int n = int.Parse(txtNhapSo.Text.ToString());
                //Số chính phương
                int[] numbers = Enumerable.Range(1, n).ToArray();
                int[] SquareNumber = numbers.Where(x => Math.Sqrt(x) % 1 == 0).ToArray();
                //Số nguyên tố
                bool[] PrimeNumbers = Enumerable.Repeat(true, n + 1).ToArray();
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (PrimeNumbers[i] == true)
                    {
                        for (int j = i * i; j <= n; j += i)
                        {
                            PrimeNumbers[j] = false;
                        }
                    }
                }

                List<int> PrintPrimeNumbers = new List<int>();
                for (int i = 2; i <= n; i++)
                {
                    if (PrimeNumbers[i] == true)
                    {
                        PrintPrimeNumbers.Add(i);
                    }
                }
                //số hoàn chỉnh
                List<int> CompleteNum = new List<int>();
                for (int i = 1; i < n; i++)
                {
                    if (check(i))
                    {
                        CompleteNum.Add(i);
                    }
                }
                string txt = string.Join(", ", PrintPrimeNumbers);
                string txtS = string.Join(", ", SquareNumber);
                string txtP = string.Join(", ", CompleteNum);

                lbSquareNum.Text = lbSquareNum.Text + " " + txtS;
                lbPrime.Text = lbPrime.Text + " " + txt;
                lbCompleteNum.Text = lbCompleteNum.Text + " " + txtP;
            }
            
        }
        private bool check(int n)
        {
            int sum = 0;//khai bao biem sum
            for (int i = 1; i <= n / 2; i++)
            {
                if (n % i == 0)
                    sum += i;
            }
            if (sum == n) return true; // tra ve true
            return false;
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtNhapSo_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex("^[0-9]+$");
            if (!regex.IsMatch(txtNhapSo.Text))
            {
                MessageBox.Show("Chỉ được phép nhập số", "Thông báo");
            }
        }

        private void txtNhapSo_Leave(object sender, EventArgs e)
        {
            string a = txtNhapSo.Text;
            if(a == "")
            {
                MessageBox.Show("Không được để trắng", "Thông báo");
            }
        }
    }
}
