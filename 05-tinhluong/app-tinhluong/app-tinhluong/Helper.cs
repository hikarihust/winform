using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app_tinhluong
{
    class Helper
    {
        public static string FormatNumber(int value)
        {
            return String.Format("{0:n0}", value) + "đ";
        }
    }
}
