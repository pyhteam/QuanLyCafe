using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyCafe.Business.EntitiesClass
{
    public class EC_tb_Bill
    {
        private string mabill;
        private string maban;
        private int tongtien;
        private DateTime ngaytao;

        public string Mabill { get => mabill; set => mabill = value; }
        public string Maban { get => maban; set => maban = value; }
        public int Tongtien { get => tongtien; set => tongtien = value; }
        public DateTime Ngaytao { get => ngaytao; set => ngaytao = value; }
    }
}
