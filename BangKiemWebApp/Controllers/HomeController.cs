using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BangKiemWebApp.Models;
using BangKiemWebApp.Repository;

namespace BangKiemWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IDanhMucRepo _iDanhMucRepo;

        public HomeController(ILogger<HomeController> logger, IDanhMucRepo iDanhMucRepo)
        {
            _logger = logger;
            _iDanhMucRepo = iDanhMucRepo;
        }

        public IActionResult Index()
        {
            try
            {
                //var listDanhMucResult = await _iDanhMucRepo.GetAll();
                //var listDanhMuc = listDanhMucResult.ToList();
                //ViewBag.ListDm = listDanhMuc;

                return View();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
