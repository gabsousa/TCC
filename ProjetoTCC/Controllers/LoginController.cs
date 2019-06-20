using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Session;

namespace ProjetoTCC.Controllers
{
    public class LoginController : Controller
    {
       
        public ActionResult TelaLogin()
        {
            //HttpContext.Session.SetString("Login", Models.Data.);
            //HttpContext.Session.SetString("Nome_Usuario", classeLogin.NOME);

            return View();
        }

        public ActionResult TelaMenu()
        {

            //chamar método que retorna se usuário é valido ou não

            //se usuário for válido preenhcer a session

            Models.Login classeLogin = new Models.Login();
            classeLogin.LOGIN = "gabriela";
            classeLogin.NOME = "Gabriela Aguiar";

            HttpContext.Session.SetString("Login", classeLogin.LOGIN);
            HttpContext.Session.SetString("Nome_Usuario", classeLogin.NOME);

            return View();
        }

        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        // GET: Login/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Login/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Login/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Login/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Login/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Login/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Login/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

