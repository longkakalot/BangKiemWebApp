using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BangKiemWebApp.Models
{
    public class DanhMuc
    {
        public decimal Id { get; set; }
        public string Ten { get; set; }
        public int Hide { get; set; } 
        public DateTime NgayUd { get; set; }
    }
}
