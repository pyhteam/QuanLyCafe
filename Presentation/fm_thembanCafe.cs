using QuanLyCafe.Business.Component;
using QuanLyCafe.Business.EntitiesClass;
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
    public partial class fm_thembanCafe : Form
    {
        E_tb_BanCafe thucthi = new E_tb_BanCafe();
        ConnectDB cn = new ConnectDB();
        EC_tb_BanCafe b = new EC_tb_BanCafe();
        bool themmoi;
        int dong = 0;
        public fm_thembanCafe()
        {
            InitializeComponent();
        }
         private void insertTableCoffe()
        {

            b.Maban = txtMaban.Text;
            b.Tenban = txtTenBan.Text;
            b.Trangthai = "0";
            b.Ngaytao = DateTime.Now;

            //Insert to database
           thucthi.themoibancafe(b);
           

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            insertTableCoffe();
            txtTenBan.Text = "";
            txtMaban.Text = "";
        }
    }
}
