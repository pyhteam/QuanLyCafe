using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyCafe.Business.EntitiesClass
{
    public class EC_tb_BanCafe
    {
        private string maban;

       
        private string tenban;
        private string trangthai;
        private DateTime ngaytao;

        public string Maban
        {
            get { return maban; }
            set
            {
                maban = value; if (maban == "")
                {
                    throw new Exception("Mã không được để trống");
                }
            }
        }
      

        public DateTime Ngaytao { get => ngaytao; set => ngaytao = value; }
        public string Tenban { get => tenban; set => tenban = value; }
        public string Trangthai { get => trangthai; set => trangthai = value; }
    }
}
