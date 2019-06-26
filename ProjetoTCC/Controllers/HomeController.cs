using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjetoTCC.Models;
using Microsoft.AspNetCore.Http;

namespace ProjetoTCC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
          
        //    HttpContext.Session.SetString("Login", null);
            return View();
        }

        public IActionResult About()
        {

            return View();
        }

        public IActionResult Contact()
        {

            return View();
        }

        public IActionResult Doutores()
        {
            return View();
        }

        public IActionResult Especialidades()
        {
            return View();
        }

        public IActionResult Historia()
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
