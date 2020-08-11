using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BangKiemWebApp.ViewModels;

namespace BangKiemWebApp.Repository
{
    public interface IBenhNhanRepo
    {
        Task<BenhNhanViewModel> GetInfoBn(string maBn);
    }
}
