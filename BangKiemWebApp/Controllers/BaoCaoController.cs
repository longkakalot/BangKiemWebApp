using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BangKiemWebApp.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BangKiemWebApp.Controllers
{
    public class BaoCaoController : Controller
    {
        private readonly IBaoCaoRepo _iBaoCaoRepo;

        public BaoCaoController(IBaoCaoRepo iBaoCaoRepo)
        {
            _iBaoCaoRepo = iBaoCaoRepo;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}