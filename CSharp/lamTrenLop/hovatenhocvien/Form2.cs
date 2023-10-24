using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hovatenhocvien
{
    public partial class Form2 : Form
    {
        private Form1 form1;

        public Form2()
        {
            InitializeComponent();
        }
        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            form1.ForeColor = Color.White;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        private void btnChangeWhite_Click(object sender, EventArgs e)
        {
            form1.BackColor = Color.White;
        }

        private void btnChangePink_Click(object sender, EventArgs e)
        {
            form1.BackColor = Color.FromArgb(255, 192, 192);
        }
    }
}
