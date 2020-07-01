using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using JoaoLuizDev.Models;

namespace JoaoLuizDev.Controllers
{
    public class HomeController : Controller
    {
        private DefaultConectionContext db;
        public static List<SocialMedia> Destaques = null;


        public HomeController(DefaultConectionContext contexto)
        {
            db = contexto;
        }

        public IActionResult Index()
        {
            ViewBag.Redes = db.SocialMedia.FirstOrDefault();
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
