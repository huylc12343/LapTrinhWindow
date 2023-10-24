using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace testWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            drKH.Rows.Add("01", "Nguyễn Văn A", "Nam", "Phòng Đơn", "2");
            drKH.Rows.Add("02", "Nguyễn Văn B", "Nữ", "Phòng Đôi", "1");

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtTenKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void drKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            txtTenKH.Text = drKH.CurrentRow.Cells[1].Value.ToString();
            string gt = drKH.CurrentRow.Cells[2].Value.ToString();
            if(gt == "Nam")
            {
                rdNam.Checked = true;
            }
            else
            {
                rdNu.Checked = true;
            }
            comboBox1.Text = drKH.CurrentRow.Cells[3].Value.ToString();
            txtSoLuongThu.Text = drKH.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnThem_MouseClick(object sender, MouseEventArgs e)
        {
            drKH.Rows.Add(drKH.Rows.Count, txtTenKH.Text,rdNam.Checked == true ?"Nam":"Nữ" , comboBox1.Text, txtSoLuongThu.Text);

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string searchValue = txtTen.Text;
            DataTable table = new DataTable();
            table.Columns.Add("A",typeof(string));
            table.Columns.Add("B", typeof(string));
            table.Columns.Add("C", typeof(string));
            table.Columns.Add("D", typeof(string));
            table.Columns.Add("E", typeof(string));
            foreach(DataGridViewRow row in drKH.Rows)
            {
                table.Rows.Add(row.Cells[0].Value, row.Cells[1].Value, row.Cells[2].Value, row.Cells[3].Value, row.Cells[4].Value);
            }
            var resulSearch = from row in ((DataTable)drKH.DataSource).AsEnumerable()
                              where row[1].ToString().Contains(searchValue)
                              select row;
            drKH.DataSource = resulSearch.CopyToDataTable();
        }

        
    }
}
