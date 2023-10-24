using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtNhapTen_TextChanged(object sender, EventArgs e)
        {
            lblLapTrinh.Text = txtNhapTen.Text;
        }

        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            if(radRed.Checked)
            {
                lblLapTrinh.ForeColor = Color.Red;
            }
        }

        private void radGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (radGreen.Checked)
            {
                lblLapTrinh.ForeColor = Color.Green;
            }
        }

        private void radBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (radBlue.Checked)
            {
                lblLapTrinh.ForeColor = Color.Blue;
            }
        }

        private void radBlack_CheckedChanged(object sender, EventArgs e)
        {
            if (radBlack.Checked)
            {
                lblLapTrinh.ForeColor = Color.Black;
            }
        }

        private void cbBold_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.Font = new Font("Times New Roman", 10, FontStyle.Bold);
        }

        private void cbUnderline_CheckStateChanged(object sender, EventArgs e)
        {
            lblLapTrinh.Font = new Font(lblLapTrinh.Font.Name,
                                        lblLapTrinh.Font.Size,
                                        lblLapTrinh.Font.Style ^ FontStyle.Underline);


        }

        private void cbItalic_CheckStateChanged(object sender, EventArgs e)
        {
            lblLapTrinh.Font = new Font(lblLapTrinh.Font.Name,
                                         lblLapTrinh.Font.Size,
                                         lblLapTrinh.Font.Style ^ FontStyle.Italic);


        }

        private void cbBold_CheckStateChanged(object sender, EventArgs e)
        {
            lblLapTrinh.Font = new Font(lblLapTrinh.Font.Name,
                                         lblLapTrinh.Font.Size,
                                         lblLapTrinh.Font.Style ^ FontStyle.Bold);


        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        //private void SetFontStyle()
        //{

        //    FontStyle fontStyle = FontStyle.Regular;

        //    if (cbItalic.Checked)
        //    {
        //        fontStyle |= FontStyle.Italic;
        //    }
        //    if (cbBold.Checked)
        //    {
        //        fontStyle |= FontStyle.Bold;
        //    }
        //    if (cbUnderline.Checked)
        //    {
        //        fontStyle |= FontStyle.Underline;
        //    }

        //    lblLapTrinh.Font = new Font(lblLapTrinh.Font, fontStyle);
        //}
    }
}
