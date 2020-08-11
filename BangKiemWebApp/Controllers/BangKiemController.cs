using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BangKiemWebApp.Repository;
using BangKiemWebApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BangKiemWebApp.Controllers
{
    public class BangKiemController : Controller
    {
        private readonly ILogger<BangKiemController> _logger;
        private readonly IDanhMucRepo _iDanhMucRepo;
        private readonly INoiDungRepo _iNoiDungRepo;
        private readonly IBenhNhanRepo _iBenhNhanRepo;
        private readonly IBangKiemRepo _iBangKiemRepo;

        public BangKiemController(ILogger<BangKiemController> logger, IDanhMucRepo iDanhMucRepo, INoiDungRepo iNoiDungRepo, IBenhNhanRepo iBenhNhanRepo, IBangKiemRepo iBangKiemRepo)
        {
            _logger = logger;
            _iDanhMucRepo = iDanhMucRepo;
            _iNoiDungRepo = iNoiDungRepo;
            _iBenhNhanRepo = iBenhNhanRepo;
            _iBangKiemRepo = iBangKiemRepo;
        }

        public async Task<IActionResult> Index()
        {
            try
            {
                var sw = Stopwatch.StartNew();
                
                
                Console.WriteLine("Time elapsed: " + sw.ElapsedMilliseconds);


                var listDanhMucResult = await _iDanhMucRepo.GetAll();
                var listDanhMuc = listDanhMucResult.ToList();
                sw.Stop();
                ViewBag.ActiveBk = "active";
                ViewBag.time = sw.ElapsedMilliseconds;
                return View(listDanhMuc);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task<IActionResult> NhapBangKiem(decimal id)
        {
            try
            {
                //var abc = await GetInfoBn("20064089");
                
                var listNoiDungBkResult = await _iNoiDungRepo.GetByIddm(id);
                var listNoiDungBk = listNoiDungBkResult.ToList();
                return View(listNoiDungBk);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task<IActionResult> GetInfoBn(string maBn)
        {
            var bnInfoResult = await _iBenhNhanRepo.GetInfoBn(maBn);

            if (bnInfoResult.DotDieuTris.Count == 0)
            {
                return Content("0");
            }
            return PartialView("_InfoBn", bnInfoResult);

            //var bk = _bangKiemRepo.GetInfoBnAsync(maBn);

            //BangKiemListViewModel bkListVm = new BangKiemListViewModel
            //{
            //    DotDieuTris = bk.DotDieuTris,
            //    BnInfo = bk.BnInfo,
            //    KetQuaNhomMaus = _bangKiemRepo.GetResultBloodGroupByPid(maBn).KetQuaNhomMaus
            //};
            //return bkListVm;

        }

        public async Task<IActionResult> Insert(BangKiemDetailViewModel obj, List<NoiDung1> objNoiDungs)
        {
            //var obj1 = obj.Select(m => m.NoiDungs).ToList();
            try
            {
                obj.NoiDungs = objNoiDungs;

            
                var kqResult = await _iBangKiemRepo.Insert(obj);
                return Content(kqResult.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return Content("0");
            }

            
        }
    }
}