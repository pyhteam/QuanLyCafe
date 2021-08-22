using QuanLyCafe.Business.EntitiesClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyCafe.DataAccess
{
    class SQL_bill
    {
        ConnectDB cn = new ConnectDB();
        public bool checkMaBill(string mabill)
        {
            return cn.kiemtra("select count(*) from tb_Ban where maban=N'" + mabill + "'");
        }
       
        public void InsertBill(EC_tb_Bill bill)
        {
            string sql = "INSERT INTO tb_bill (mabill, maban, tongtien,ngaytao) VALUES(N'" + bill.Mabill + "',N'" + bill.Maban + "', " + bill.Tongtien + ", '" + bill.Ngaytao + "')";
            cn.ExcuteNonQuery(sql);
        }
        public void DeleteBill(EC_tb_Bill bill)
        {
             cn.ExcuteNonQuery("DELETE FROM tb_bill WHERE mabill=N'" + bill.Mabill + "'");
           
        }
    }
}
