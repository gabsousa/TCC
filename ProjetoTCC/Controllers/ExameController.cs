using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProjetoTCC.Controllers
{
    public class ExameController : Controller
    {
        // GET: Exame
        public ActionResult Index()
        {
            return View();
        }

        // GET: Exame/Details/5
        public ActionResult DetalhesExame(int id)
        {
            Models.Data.ExameData ed = new Models.Data.ExameData();

            return View(ed.DetalhesExame(id));
        }

        public ActionResult ListaExame()
        {
            Models.Data.ExameData ed = new Models.Data.ExameData();

            return View(ed.ListaExame());
        }

        // GET: Exame/Create
        public ActionResult CadastrarExame()
        {
            return View();
        }

        // POST: Exame/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CadastrarExame(Models.Exame collection)
        {
            Models.Data.ExameData ed = new Models.Data.ExameData();
            ed.CadastrarExame(collection);

            return RedirectToAction(nameof(ListaExame));
        }

        // GET: Exame/Edit/5
        public ActionResult EditarExame(int id)
        {
            Models.Data.ExameData ed = new Models.Data.ExameData();

            return View(ed.DetalhesExame(id));
        }

        // POST: Exame/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditarExame(Models.Exame collection)
        {
            Models.Data.ExameData ed = new Models.Data.ExameData();
            ed.EditarExame(collection);

            return RedirectToAction(nameof(EditarExame));
        }

        // GET: Exame/Delete/5
        public ActionResult DeletarExame(int id)
        {
            Models.Data.ExameData ed = new Models.Data.ExameData();

            return View(ed.DetalhesExame(id));
        }

        // POST: Exame/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeletarExame(int id, IFormCollection collection)
        {
            Models.Data.ExameData ed = new Models.Data.ExameData();
            ed.DeletarExame(id);

            return RedirectToAction(nameof(ListaExame));
        }
    }
}