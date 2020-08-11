using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BangKiemWebApp.Models
{
    public class NoiDung
    {
        public decimal Id { get; set; }
        public decimal Iddm { get; set; }
        public string Ten { get; set; }
        public int Stt { get; set; }
        public DateTime NgayUd { get; set; }
        public int Hide { get; set; }

        public int Style { get; set; }
        public string Username { get; set; }
    }
}
