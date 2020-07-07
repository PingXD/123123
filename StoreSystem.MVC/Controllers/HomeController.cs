using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StoreSystem.MVC.Models;
using static StoreSystem.BLL.GoodsClass;

namespace StoreSystem.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            IBLL.IGoodsClass  tClass= new BLL.GoodsClass();
           var f =  tClass.GetAllClassList().Result.FirstOrDefault();
            
            //MyClass sss = new MyClass();
            string sd = f.ClassMaster;
            //foreach (var asd in f )
            //{
            //    sd = asd.ClassMaster;
            //}

            return View();
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
