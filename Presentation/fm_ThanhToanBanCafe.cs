using QuanLyCafe.Business.Component;
using QuanLyCafe.Business.EntitiesClass;
using QuanLyCafe.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyCafe.Presentation
{
    public partial class fm_ThanhToanBanCafe : Form
    {
        string _maban;
       
        ConnectDB cn = new ConnectDB();
       

        string totalMoney = "";


        public fm_ThanhToanBanCafe(string maban)
        {
            InitializeComponent();
            _maban = maban;
        }

        private void fm_ThanhToanBanCafe_Load(object sender, EventArgs e)
        {
            
            showData();

        }

       

        private void showData()
        {
            SqlConnection con = cn.getcon();
            con.Open();
            try
            {
                string sql = @"SELECT tb_Order.maorder,tb_order.quantity, tb_Ban.tenban, tb_SanPham.tensp, tb_Sanpham.giaban As 'Đơn giá',tb_order.thoigian 
                FROM tb_Order,tb_Ban,tb_Sanpham 
                Where tb_Order.maban=tb_Ban.maban 
                AND tb_order.maban = '"+_maban+"' " +
                "AND tb_Sanpham.masp = tb_order.masanpham AND tb_Order.status ='1'";

         
            



                gvDanhSachOderBan.DataSource =  cn.taobang(sql);

                gvDanhSachOderBan.Columns[0].HeaderText = "Mã Order";
                gvDanhSachOderBan.Columns[1].HeaderText = "Số lượng";
                gvDanhSachOderBan.Columns[2].HeaderText = "Bàn";

                gvDanhSachOderBan.Columns[3].HeaderText = "Tên sản phẩm";
                gvDanhSachOderBan.Columns[4].HeaderText = "Đơn giá";
                gvDanhSachOderBan.Columns[5].HeaderText = "Thời gian";


                //Load tong tiền
                string sqlGetMoney = "SELECT tb_order.maorder,tb_order.quantity, tb_Ban.tenban, tb_SanPham.tensp, tb_Sanpham.giaban,tb_order.thoigian, SUM(tb_Sanpham.giaban*tb_order.quantity) over (partition by tb_Ban.tenban) as total  FROM tb_Order,tb_Ban,tb_Sanpham Where tb_Order.maban=tb_Ban.maban AND tb_order.maban = '"+_maban+ "' AND tb_Sanpham.masp = tb_order.masanpham AND tb_Order.status ='1' GROUP BY tb_order.maorder, tb_order.quantity, tb_Ban.tenban,tb_SanPham.tensp, tb_Sanpham.giaban,tb_order.thoigian";
                 totalMoney = cn.LoadLableCustom(sqlGetMoney, 6);

                if (gvDanhSachOderBan.RowCount > 0)
                {
                    txtTongTien.Text = string.Format("{0:#,0}", totalMoney) + "VND";

                }
                else
                    txtTongTien.Text ="NULL";





            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           
           con.Close();
           
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (gvDanhSachOderBan.RowCount > 0)
            {
                //try
                //{
                    var bill = new E_tb_bill();
                    var setBill = new EC_tb_Bill();

                    setBill.Mabill = RandomChar("BILL");
                    setBill.Maban = _maban;
                    setBill.Ngaytao = DateTime.Now;
                    setBill.Tongtien = Convert.ToInt32(totalMoney);

                    //InsertToBill
                    bill.Insert(setBill);

                    //reset Table
                    var table = new SQL_tb_BanCafe();
                    table.UpdateStatus(_maban);
                    //reset Order
                    var order = new E_tb_Order();
                    order.UpdateToBill(_maban);

                //}
                //catch (Exception ex)
                //{

                //    throw new Exception(ex.ToString());
                //}
               
            }
        }
        private string RandomChar(string v)
        {
            int length = 6;

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
