using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BangKiemWebApp.Models;

namespace BangKiemWebApp.Repository
{
    public interface IDanhMucRepo
    {
        public Task<DanhMuc> GetById(decimal id);
        public Task<IList<DanhMuc>> GetAll();
        public Task<int> Insert(DanhMuc objDanhMuc);
        public Task<int> Delete(decimal id);
        public Task<int> Update(DanhMuc objDanhMuc);


    }
}
