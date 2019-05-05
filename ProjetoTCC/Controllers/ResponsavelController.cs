using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProjetoTCC.Controllers
{
    public class ResponsavelController : Controller
    {
        // GET: Responsavel
        public ActionResult Index()
        {
            return View();
        }

        // GET: Responsavel/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Responsavel/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Responsavel/Create
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

        // GET: Responsavel/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Responsavel/Edit/5
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

        // GET: Responsavel/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Responsavel/Delete/5
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