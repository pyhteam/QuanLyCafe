using QuanLyCafe.Business.Component;
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
    public partial class fm_TuyChon : Form
    {
        string _maban; string _trangthai;
        public fm_TuyChon( string maban, string trangthai)
        {
            InitializeComponent();
            _maban = maban;
            _trangthai = trangthai;
        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            fm_order fm = new fm_order(_maban);
            fm.ShowDialog();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            fm_ThanhToanBanCafe fm = new fm_ThanhToanBanCafe(_maban);
            fm.ShowDialog();
        }

        private void fm_TuyChon_Load(object sender, EventArgs e)
        {
            if (Convert.ToInt32(_trangthai) == 0)
            {
                btnThanhToan.Visible = false;
            }
            else 
                btnThanhToan.Visible = true;
        }

        private void btnSuaBan_Click(object sender, EventArgs e)
        {
            fmSuaBan fm = new fmSuaBan(_maban);
            fm.ShowDialog();
        }

        private void btnChuyenBan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Update new version!!!!");
        }

        private void btnXoaBan_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure to delete row?", "Confirmation", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                var removeTable = new SQL_tb_BanCafe();
                removeTable.xoabancf(_maban);
                MessageBox.Show("da xoa");
            }
            else if (DialogResult == DialogResult.No)
            {
                MessageBox.Show("Not thing :))");
            }

        }
    }
}
