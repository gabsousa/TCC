using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Session;
using ProjetoTCC.Models;

namespace ProjetoTCC.Controllers
{
    public class LoginController : Controller
    {
        Login aA = new Login();

        public object LOGIN { get; private set; }
       
        public ActionResult TelaLogin()
        {
            return View();
        }

        public ActionResult TelaMenu()
        {

            //chamar método que retorna se usuário é valido ou não

            //se usuário for válido preenhcer a session

            //Models.Login classeLogin = new Models.Login();
            //classeLogin.LOGIN = "LOGIN";
            //classeLogin.NOME = "COD_FUNC";

            //HttpContext.Session.SetString("Login", classeLogin.LOGIN);
            //HttpContext.Session.SetString("Nome_Usuario", classeLogin.NOME);

            return View();
        }

        //public ActionResult VerificarLogin()
        //{
        //    //aA.TestarUsuario(u);

        //    //if (u.LOGIN !=null && u.ds_SENHA !=null)
        //    //{
        //    //    FormsAuthentication.SetAuthCookie(u.LOGIN, false);
        //    //    Session["usuarioLogado"] = u.LOGIN.ToString();
        //    //    Session["senhaLogado"] = u.ds_SENHA.ToString();

        //    //    return RedirectToaction("TelaMenu", "Login");
        //    //}
        //    //else
        //    //{
        //    //    return RedirectToAction("Login", "Login");
        //    //}

        //    //return View();
        //}

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

        //public ActionResult Logout()
        //{
        //    Session["usuarioLogado"] = null;
        //    return RedirectToAction("Login", "Login");

        //}
    }
}

