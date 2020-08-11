using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BangKiemWebApp.Models;
using BangKiemWebApp.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BangKiemWebApp.Controllers
{
    public class DanhMucController : Controller
    {
        private readonly IDanhMucRepo _iDanhMucRepo;

        public DanhMucController(IDanhMucRepo iDanhMucRepo)
        {
            _iDanhMucRepo = iDanhMucRepo;
        }

        public IActionResult Index()
        {
            ViewBag.ActiveDanhMuc = "active";
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(DanhMuc objDanhMuc)
        {
            try
            {
                var kq = await _iDanhMucRepo.Insert(objDanhMuc);

                return Content(kq.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return Content("0");
            }
        }

        public async Task<IActionResult> Update(DanhMuc objDanhMuc)
        {
            try
            {
                var kq = await _iDanhMucRepo.Update(objDanhMuc);
                return Content(kq.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return Content("0");
            }
        }

        public async Task<IActionResult> GetAll()
        {
            try
            {
                var kqResult = await _iDanhMucRepo.GetAll();
                var kq = kqResult.ToList();
                return PartialView("_ListDanhMuc", kq);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return Content("0");
            }
        }
    }
}