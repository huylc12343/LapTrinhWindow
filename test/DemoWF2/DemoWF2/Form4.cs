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
    public partial class Form4 : Form
    {
        // Cach 2: truyen Form3, goi phuong thuc duoc dinh nghia trong form3
        public Form4(Form3 a)
        {
            InitializeComponent();
            this.form3.textBox1.Text  =  a.textBox1.Text;

            label1.Text = form3.textBox1.Text;
            form3.textBox1.Text = "qqqq";
        }

        //Form3 form3;
        Form3 form3 = new Form3();
        private void label1_Click(object sender, EventArgs e)
        {
            

        }
    }
}
