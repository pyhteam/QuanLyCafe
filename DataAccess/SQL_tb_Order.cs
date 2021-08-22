using QuanLyCafe.Business.EntitiesClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyCafe.DataAccess
{
    class SQL_tb_Order
    {
        ConnectDB cn = new ConnectDB();
        public bool checkMaOrder(string order)
        {
            return cn.kiemtra("select count(*) from tb_Order where maorder=N'" + order + "'");
        }
        public bool checkMaSanPham(string sp,string maban)
        {
            return cn.kiemtra("select count(*) from tb_Order where masanpham=N'" + sp + "' AND maban='"+maban+"'");
        }

        public int checkCount()
        {
            return cn.returnscalarnumber("select count(*) from tb_Order");
        }
        public void InsertOrder(EC_tb_Order order)
        {
            string sql = "INSERT INTO tb_Order (maorder,quantity, maban, masanpham,thoigian,tongtien,status) VALUES(N'" + order.MaOrder + "',"+order.Quantity+",N'" + order.MaBan + "', N'" + order.MaSanPham + "', '" + order.ThoiGian + "',"+order.TongTien+","+order.Status+" )";
            cn.ExcuteNonQuery(sql);
        }
        public void DeleteOrder(EC_tb_Order order)
        {
            cn.ExcuteNonQuery("DELETE FROM tb_Order WHERE maorder=N'" + order.MaOrder + "'");
        }

        public void UpdateOrder(EC_tb_Order order,string masanpham, string maban)
        {
            string sql = ("UPDATE tb_Order SET quantity=quantity+"+order.Quantity+", tongtien=tongtien+"+order.TongTien+"  WHERE masanpham= '" + masanpham + "' AND maban='"+maban+"' ");
            cn.ExcuteNonQuery(sql);
        }

        public void UpdateOrderBill(string maban)
        {
            string sql = ("UPDATE tb_Order SET status=0 WHERE maban='"+maban+"'");
            cn.ExcuteNonQuery(sql);
        }



    }
}
