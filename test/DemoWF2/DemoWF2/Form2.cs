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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            foreach(var i in this.MdiChildren)
            {
                i.Close();
                
            }
            form1.MdiParent = this; // this = form2
            form1.Show();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
