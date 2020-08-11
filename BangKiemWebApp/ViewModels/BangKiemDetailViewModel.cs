using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BangKiemWebApp.Models;

namespace BangKiemWebApp.ViewModels
{
    public class BangKiemDetailViewModel
    {
        public string MaBn { get; set; }
        public string HoTenBn { get; set; }
        public decimal NamSinh { get; set; }
        public string Phai { get; set; }
        public string MaIcd { get; set; }
        public string BenhChinh { get; set; }
        public string NgayGiamSat { get; set; }
        public string TenKhoaPhong { get; set; }
        public decimal MaQl { get; set; }
        public decimal MaVaoVien { get; set; }
        public string Username { get; set; }
        public List<NoiDung1> NoiDungs { get; set; }
        public int Status { get; set; }
    }

    public class NoiDung1
    {
        public decimal IdNoiDung { get; set; }
        public int Diem { get; set; }
        public int Status { get; set; }
    }

    
}
