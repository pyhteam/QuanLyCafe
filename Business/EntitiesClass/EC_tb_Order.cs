using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyCafe.Business.EntitiesClass
{
   public  class EC_tb_Order
    {
        private string maOrder;
        private int quantity;
        private string maBan;
        private string maSanPham;
        private DateTime thoiGian;
        private int tongTien;
        private int status;

        public string MaOrder { get => maOrder; set => maOrder = value; }
        public string MaBan { get => maBan; set => maBan = value; }
        public string MaSanPham { get => maSanPham; set => maSanPham = value; }
        public DateTime ThoiGian { get => thoiGian; set => thoiGian = value; }
        public int TongTien { get => tongTien; set => tongTien = value; }
        public int Quantity { get => quantity; set => quantity = value; }
       
        public int Status { get => status; set => status = value; }
    }
}
