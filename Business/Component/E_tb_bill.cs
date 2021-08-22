using QuanLyCafe.Business.EntitiesClass;
using QuanLyCafe.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyCafe.Business.Component
{
    class E_tb_bill
    {
        SQL_bill nvsql = new SQL_bill();

        public void Insert(EC_tb_Bill cf)
        {
            if (!nvsql.checkMaBill(cf.Mabill))
            {
                nvsql.InsertBill(cf);
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Bill này đã tồn tại,xin chọn bàn khác", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
        public void xoabancf(EC_tb_Bill nv)
        {
            nvsql.DeleteBill(nv);
        }
    }
}
