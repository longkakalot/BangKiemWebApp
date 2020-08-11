using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BangKiemWebApp.ViewModels;

namespace BangKiemWebApp.Repository
{
    public interface IBaoCaoRepo
    {
        Task<IList<string>> GetListKhoaPhong();
        Task<IList<BangKiemInfo>> GetBangKiemByKhoa(string tenKhoaPhong);
        Task<IList<BangKiemInfo>> GetAllBangKiem();
        Task<IList<BangKiemDetailInfo>> GetBangKiemDetailByKhoaByBangKiem(string tenKhoaPhong, decimal idBangKiem);

    }
}
