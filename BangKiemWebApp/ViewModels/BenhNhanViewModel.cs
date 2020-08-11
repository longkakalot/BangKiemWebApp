using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BangKiemWebApp.ViewModels
{
    public class BenhNhanViewModel
    {
        public bool Success { get; set; }
        public List<BenhNhanInfo> BnInfo { get; set; }
        public List<DotDieuTri> DotDieuTris { get; set; }
        public DateTime NgayGiamSat { get; set; }
        public DateTime NgayUd { get; set; }
        public int Status { get; set; }
    }

    public class DotDieuTri
    {
        public string Ngay { get; set; }
        public string TenKhoaPhong { get; set; }
        public decimal MaQl { get; set; }
        public decimal MaVaoVien { get; set; }
    }

    public class BenhNhanInfo
    {
        public string MaBn { get; set; }
        public string HoTenBn { get; set; }
        public decimal NamSinh { get; set; }
        public string Phai { get; set; }
        public string MaIcd { get; set; }
        public string BenhChinh { get; set; }
    }
}
