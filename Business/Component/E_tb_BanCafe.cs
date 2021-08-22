using QuanLyCafe.Business.EntitiesClass;
using QuanLyCafe.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyCafe.Business.Component
{
    class E_tb_BanCafe
    {
        SQL_tb_BanCafe nvsql = new SQL_tb_BanCafe();

        public void themoibancafe(EC_tb_BanCafe cf)
        {
            if (!nvsql.kiemtrabancf(cf.Maban))
            {
                nvsql.themmoibancf(cf);
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Bàn này đã tồn tại,xin chọn bàn khác", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void suabancf(EC_tb_BanCafe nv)
        {
            nvsql.suabancf(nv);
        }
        public void xoabancf(string ma)
        {
            nvsql.xoabancf(ma);
        }

        public void getList()
        {
            if (nvsql.checkCount() > 0)
                nvsql.layDanhSach();
            else
                throw new Exception("Không có dữ liệu");
        }

        

    }
}
