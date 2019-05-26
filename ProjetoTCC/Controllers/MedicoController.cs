using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProjetoTCC.Controllers
{
    public class MedicoController : Controller
    {
        // GET: Medico
        public ActionResult Index()
        {
            return View();
        }

        // GET: Medico/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult ListaMedico()
        {
            Models.Data.MedicoData td = new Models.Data.MedicoData();

            return View(td.ListaMedico());
        }

        // GET: Medico/Create
        public ActionResult CadastrarMedico()
        {
            return View();
        }

        // POST: Medico/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CadastrarMedico(Models.Medico collection)
        {
            Models.Data.MedicoData medicoData = new Models.Data.MedicoData();
            medicoData.CadastrarMedico(collection);

            return RedirectToAction(nameof(ListaMedico));
        }

        // GET: Medico/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Medico/Edit/5
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

        // GET: Medico/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Medico/Delete/5
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