using QuanLyCafe.Business.EntitiesClass;
using QuanLyCafe.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyCafe.Business.Component
{
    class E_tb_Order
    {
        SQL_tb_Order order = new SQL_tb_Order();

        public void Insert(EC_tb_Order cf)
        {
            if (!order.checkMaOrder(cf.MaOrder))
            {
                order.InsertOrder(cf);
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
               MessageBox.Show("Order này đã tồn tại,xin chọn bàn khác", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
            }
        }
        public void Update(EC_tb_Order nv,string masanpham,string maban)
        {
            order.UpdateOrder(nv,masanpham,maban);
            MessageBox.Show("Order thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void UpdateToBill(string maban)
        {
            order.UpdateOrderBill(maban);
            MessageBox.Show("Đã thanh toán!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void Delete(EC_tb_Order nv)
        {
            order.DeleteOrder(nv);
        }
       

    }
}
