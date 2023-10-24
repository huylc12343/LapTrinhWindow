using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace countryFlags
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void rdVN_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdVN_Click(object sender, EventArgs e)
        {
            countryFlags.Image = new Bitmap(Application.StartupPath + "\\Resources\\VN-Vietnam-Flag-icon.png");
        }

        private void rdUSA_Click(object sender, EventArgs e)
        {
            countryFlags.Image = new Bitmap(Application.StartupPath + "\\Resources\\istockphoto-898274350-612x612.jpg");

        }

        private void rdItaly_Click(object sender, EventArgs e)
        {
            countryFlags.Image = new Bitmap(Application.StartupPath + "\\Resources\\Flag_of_Italy.svg.png");

        }

        private void rdPhillip_Click(object sender, EventArgs e)
        {
            countryFlags.Image = new Bitmap(Application.StartupPath + "\\Resources\\rp-lgflag.jpg");

        }
    }
}
