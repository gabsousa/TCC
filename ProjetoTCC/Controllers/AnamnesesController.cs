using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProjetoTCC.Controllers
{
    public class AnamnesesController : Controller
    {
        // GET: Anamneses
        public ActionResult Index()
        {
            return View();
        }

        // GET: Anamneses/Details/5
        public ActionResult DetalhesAnamneses(int id)
        {
            Models.Data.AnamnesesData ad = new Models.Data.AnamnesesData();

            return View(ad.DetalhesAnamneses(id));
        }

        public ActionResult ListaAnamneses()
        {
            Models.Data.AnamnesesData ad = new Models.Data.AnamnesesData();

            return View(ad.ListaAnamneses());
        }

        // GET: Anamneses/Create
        public ActionResult CadastrarAnamneses()
        {
            return View();
        }

        // POST: Anamneses/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CadastrarAnamneses(Models.Anamneses collection)
        {
            Models.Data.AnamnesesData ad = new Models.Data.AnamnesesData();
            ad.CadastrarAnamneses(collection);

            return RedirectToAction(nameof(ListaAnamneses));
        }

        // GET: Anamneses/Edit/5
        public ActionResult EditarAnameneses(int id)
        {
            Models.Data.AnamnesesData ad = new Models.Data.AnamnesesData();

            return View(ad.DetalhesAnamneses(id));
        }

        // POST: Anamneses/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditarAnameneses(Models.Anamneses collection)
        {
            Models.Data.AnamnesesData ad = new Models.Data.AnamnesesData();
            ad.EditarAnamneses(collection);

            return RedirectToAction(nameof(EditarAnameneses));
        }

        // GET: Anamneses/Delete/5
        public ActionResult DeletarAnamneses(int id)
        {
            Models.Data.AnamnesesData ad = new Models.Data.AnamnesesData();

            return View(ad.DetalhesAnamneses(id));
        }

        // POST: Anamneses/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeletarAnamneses(int id, IFormCollection collection)
        {
            Models.Data.AnamnesesData ad = new Models.Data.AnamnesesData();
            ad.DeletarAnamneses(id);

            return RedirectToAction(nameof(ListaAnamneses));
        }
    }
}