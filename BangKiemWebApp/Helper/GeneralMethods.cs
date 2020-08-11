using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BangKiemWebApp.Helper
{
    public static class GeneralMethods
    {
        public static string CreateIdRandom()
        {
            var rd = new Random();
            var id = DateTime.Now.ToString("yyMMddHHmmssfffff") + rd.Next(99999999);
            return id;
        }

        public static string GetUsername()
        {
            return "Long";
        }

    }
}
