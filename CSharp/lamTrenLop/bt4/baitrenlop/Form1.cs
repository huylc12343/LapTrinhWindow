using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitrenlop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            bangTTKH.Rows.Add("01", "Nguyen Van A", "Nam","PhongVip", "2");
        }

        private void btnThem_MouseClick(object sender, MouseEventArgs e)
        {
            bangTTKH.Rows.Add(bangTTKH.Rows.Count, txtTenKH.Text, rbNam.Checked == true ? "Nam" : "Nu",txtLoaiPhong.Text,txtSoPhongThue.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void bangTTKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTenKH.Text = bangTTKH.CurrentRow.Cells[1].Value.ToString();

        }

        private void btnTimKiem_MouseClick(object sender, MouseEventArgs e)
        {
            string searchValue = txtTen.Text;
            DataTable table = new DataTable();
            table.Columns.Add("stt", typeof(string));
            table.Columns.Add("Tên", typeof(string));
            table.Columns.Add("Giới tính", typeof(string));
            table.Columns.Add("Loại phòng", typeof(string));
            table.Columns.Add("Số lượng thuê", typeof(string));

            foreach (DataGridViewRow row in bangTTKH.Rows)
            {
                table.Rows.Add(row.Cells[0].Value, row.Cells[1].Value, row.Cells[2].Value, row.Cells[3].Value, row.Cells[4].Value);
            }
            var resultSearch = from row in table.AsEnumerable()
                               where row[1].ToString().Contains(searchValue)
                               select row;
            if (resultSearch.Count() > 0)
            {
                bangTTKH.Columns.Clear();
                bangTTKH.DataSource = resultSearch.CopyToDataTable();
            }
        }

        private void btnXoa_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
