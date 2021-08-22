using QuanLyCafe.Business.EntitiesClass;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace QuanLyCafe.DataAccess
{
     class SQL_tb_BanCafe
    {
        ConnectDB cn = new ConnectDB();
        public bool kiemtrabancf(string maban)
        {
            return cn.kiemtra("select count(*) from tb_Ban where maban=N'" + maban + "'");
        }
        public int checkCount()
        {
           return    cn.returnscalarnumber("select count(*) from tb_Ban");
        }
        public void themmoibancf(EC_tb_BanCafe cf)
        {
            string sql = "INSERT INTO tb_Ban (maban, tenban, trangthai,ngaytao) VALUES(N'" + cf.Maban + "',N'" + cf.Tenban + "', '"+cf.Trangthai+"', '"+cf.Ngaytao+"')";
            cn.ExcuteNonQuery(sql);
        }
        public void xoabancf(string maban)
        {
            cn.ExcuteNonQuery("DELETE FROM tb_Ban WHERE maban=N'" + maban + "'");
        }

        public void suabancf(EC_tb_BanCafe cf)
        {
            string sql = (@"UPDATE    tb_Ban SET tenban =N'" + cf.Tenban + ", "+cf.Trangthai+" WHERE maban= "+cf.Maban+" '");
            cn.ExcuteNonQuery(sql);
        }
        public void ChangeName(string tenban, string maban)
        {
            string sql = (@"UPDATE    tb_Ban SET tenban =N'" +tenban+ "'  WHERE maban= '" + maban + " '");
            cn.ExcuteNonQuery(sql);
            
        }
        public void UpdateStatus(string maban)
        {
             string sql = ("UPDATE tb_Ban SET trangthai ='0' WHERE maban= '" + maban + "' ");
            cn.ExcuteNonQuery(sql);
        }
        public void UpdateStatusOrder(string maban)
        {
            string sql = ("UPDATE tb_Ban SET trangthai ='1' WHERE maban= '" + maban + "' ");
            cn.ExcuteNonQuery(sql);
        }

        public void layDanhSach()
        {
            string sql = "Select * From tb_Ban";
            cn.taobang(sql);


        }




    }
}
