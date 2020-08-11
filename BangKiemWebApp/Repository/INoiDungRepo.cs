using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BangKiemWebApp.Models;
using BangKiemWebApp.ViewModels;

namespace BangKiemWebApp.Repository
{
    public interface INoiDungRepo
    {
        public Task<NoiDung> GetById(decimal id);
        public Task<IList<NoiDungViewModel>> GetAll();
        public Task<IList<NoiDungViewModel>> GetByIddm(decimal iddm);
        public Task<int> Insert(NoiDung objNoiDung);
        public Task<int> Delete(decimal id);
        public Task<int> Update(NoiDung objNoiDung);
    }
}
