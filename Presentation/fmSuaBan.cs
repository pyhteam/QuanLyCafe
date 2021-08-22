using QuanLyCafe.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyCafe.Presentation
{
    public partial class fmSuaBan : Form
    {
        string _maban;
        public fmSuaBan(string maban)
        {
            InitializeComponent();
            _maban = maban;
        }

        private void fmSuaBan_Load(object sender, EventArgs e)
        {

        }

        private void btnDoiten_Click(object sender, EventArgs e)
        {
            var changeNameTable = new SQL_tb_BanCafe();
            changeNameTable.ChangeName(txtTenBan.Text, _maban);
            MessageBox.Show("thanh cong");
        }
    }
}
