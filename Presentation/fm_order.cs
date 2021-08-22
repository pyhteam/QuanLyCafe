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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyCafe.Presentation
{
    public partial class fm_order : Form
    {
        string _maban;

        E_tb_Sanpham thucthi = new E_tb_Sanpham();
        SQL_tb_Sanpham thucthi1 = new SQL_tb_Sanpham();

        ConnectDB cn = new ConnectDB();
        EC_tb_Order order = new EC_tb_Order();
        E_tb_Order getOrder = new E_tb_Order();
        SQL_tb_Order sqlOrder = new SQL_tb_Order();
        //ConnectDB cn = new ConnectDB();
        //EC_tb_Nhanvien ck = new EC_tb_Nhanvien();
        public fm_order(string maban)
        {
            InitializeComponent();
            _maban = maban;
        }

        private void fm_order_Load(object sender, EventArgs e)
        {
            thucthi.getListToCombobox(cbbSanPham);
            txtSoluong.Value = 1;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string masp = cbbSanPham.SelectedValue.ToString();
            if (string.IsNullOrEmpty(cbbSanPham.Text))
            {
                MessageBox.Show("No Item is Selected");

            }
            else
            {
               
                
                    int quantity = Convert.ToInt32(txtSoluong.Value);
                    order.MaOrder = RandomChar("ORDER");
                    order.Quantity = quantity;
                    order.MaBan = _maban;
                    order.MaSanPham = masp;
                    order.ThoiGian = DateTime.Now;

                    order.TongTien = Convert.ToInt32(getTotalMoney(masp)) * quantity;
                    order.Status = 1;
                    getOrder.Insert(order);

                //Update table
                var table = new SQL_tb_BanCafe();
                table.UpdateStatusOrder(_maban);
                
                
               
               
                

            }
        }
        private string getTotalMoney(string masp)
        {
            string tongtien = cn.LoadLable("SELECT giaban From tb_SanPham where masp= N'" + masp + "'");
            return tongtien;
        }
        private string RandomChar(string v)
        {
            int length = 7;

            // creating a StringBuilder object()
            StringBuilder str_build = new StringBuilder();
            Random random = new Random();

            char letter;

            for (int i = 0; i < length; i++)
            {
                double flt = random.NextDouble();
                int shift = Convert.ToInt32(Math.Floor(25 * flt));
                letter = Convert.ToChar(shift + 65);
                str_build.Append(letter);
            }
            return v + "_" + str_build.ToString();
        }
    }
}
