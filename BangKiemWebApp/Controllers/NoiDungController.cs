using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using BangKiemWebApp.Models;
using BangKiemWebApp.Repository;
using BangKiemWebApp.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BangKiemWebApp.Controllers
{
    public class NoiDungController : Controller
    {
        private readonly IDanhMucRepo _iDanhMucRepo;
        private readonly INoiDungRepo _iNoiDungRepo;

        public NoiDungController(IDanhMucRepo iDanhMucRepo, INoiDungRepo iNoiDungRepo)
        {
            _iDanhMucRepo = iDanhMucRepo;
            _iNoiDungRepo = iNoiDungRepo;
        }

        public async Task<IActionResult> Index()
        {
            var listBangKiemResult = await _iDanhMucRepo.GetAll();
            var listBangKiem = listBangKiemResult.ToList();
            ViewBag.ActiveNoiDung = "active";
            return View(listBangKiem);
        }

        public async Task<JsonResult> GetListBangKiem()
        {
            var a1 = await _iDanhMucRepo.GetAll();
            var a = a1
                .Where(m=>m.Hide == 0)
                .ToList();
            var jsonData = a.Select(x => new
            {
                id = x.Id.ToString(CultureInfo.InvariantCulture),
                ten = x.Ten
            });
            return Json(jsonData);
        }

        public async Task<IActionResult> Insert(NoiDung objNoiDung)
        {
            try
            {
                var kq = await _iNoiDungRepo.Insert(objNoiDung);
                return Content(kq.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return Content("0");
            }
        }

        public async Task<IActionResult> GetAll(NoiDungViewModel objNoiDungViewModel)
        {
            try
            {
                var kqResult = await _iNoiDungRepo.GetAll();
                var kq = kqResult.ToList();
                return PartialView("_ListNoiDung", kq);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return Content("0");
            }
        }

        public async Task<IActionResult> Update(NoiDung objNoiDung)
        {
            try
            {
                var kq = await _iNoiDungRepo.Update(objNoiDung);
                return Content(kq.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return Content("0");
            }
        }
    }
}