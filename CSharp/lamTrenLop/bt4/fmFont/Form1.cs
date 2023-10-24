using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fmFont
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtVanBan.Font = new Font("Times new roman",
                                        20,
                                        txtVanBan.Font.Style ^ FontStyle.Regular);

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtVanBan.Font = new Font("Times new roman",
                                        txtVanBan.Font.Size,
                                        txtVanBan.Font.Style ^ FontStyle.Regular);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txtVanBan.Font = new Font("Arial",
                                        txtVanBan.Font.Size,
                                        txtVanBan.Font.Style ^ FontStyle.Regular);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            txtVanBan.Font = new Font("Tahoma",
                                        txtVanBan.Font.Size,
                                        txtVanBan.Font.Style ^ FontStyle.Regular);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            txtVanBan.Font = new Font("Courier new",
                                        txtVanBan.Font.Size,
                                        txtVanBan.Font.Style ^ FontStyle.Regular);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
