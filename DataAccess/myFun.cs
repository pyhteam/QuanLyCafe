using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyCafe
{
    public static class myFun
    {
        public static string RandomChar(string matuchon)
        {
            int length = 7;

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
            return matuchon + "_" + str_build.ToString();
        }
    }
}
