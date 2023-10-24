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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        // cach2: 
        public string getTextLabel() { return textBox1.Text; }
        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            Form4 form4 = new Form4(this);
            form4.Show();
            
        }
    }
}
