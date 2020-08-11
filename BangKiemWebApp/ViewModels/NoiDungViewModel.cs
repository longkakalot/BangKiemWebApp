using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BangKiemWebApp.ViewModels
{
    public class NoiDungViewModel
    {
        public decimal Id { get; set; }
        public decimal Iddm { get; set; }
        public string TenBangKiem { get; set; }
        public string Ten { get; set; }
        public int Stt { get; set; }
        public DateTime NgayUd { get; set; }
        public int HideNoiDung { get; set; }
        public int HideBangKiem { get; set; }
        public int Style { get; set; }
        public string Username { get; set; }
    }
}
