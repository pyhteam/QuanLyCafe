using Microsoft.Office.Interop.Excel;
using QuanLyCafe.Business.EntitiesClass;
using QuanLyCafe.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace QuanLyCafe.Presentation
{
    public partial class fmBill : Form
    {
        public fmBill()
        {
            InitializeComponent();
        }

        private void fmBill_Load(object sender, EventArgs e)
        {
            loadData();

            txtMaHoaDon.ReadOnly = true;
        }

        private void loadData()
        {
           var conectDB = new ConnectDB();
           string sql = "Select * from tb_bill";
           gvDanhSachHoaDon.DataSource = conectDB.taobang(sql);
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var bill = new SQL_bill();
            var getBill = new EC_tb_Bill();

            getBill.Mabill = txtMaHoaDon.Text;
            bill.DeleteBill(getBill);
            MessageBox.Show("xoa thanh công");
        }

        private void gvDanhSachHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.gvDanhSachHoaDon.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                txtMaHoaDon.Text = row.Cells[0].Value.ToString();
              
            }
        }
    }
}
