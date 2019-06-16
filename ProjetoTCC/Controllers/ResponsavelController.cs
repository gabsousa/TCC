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
        public ActionResult DetalhesResponsavel(int id)
        {
            Models.Data.ResponsavelData rd = new Models.Data.ResponsavelData();

            return View(rd.DetalhesResponsavel(id));
        }

        public ActionResult ListaResponsavel()
        {
            Models.Data.ResponsavelData rd = new Models.Data.ResponsavelData();

            return View(rd.ListaResponsavel());
        }

        // GET: Responsavel/Create
        public ActionResult CadastrarResponsavel()
        {
            return View();
        }

        // POST: Responsavel/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CadastrarResponsavel(Models.Responsavel collection)
        {
            Models.Data.ResponsavelData rd = new Models.Data.ResponsavelData();
            rd.CadastarResponsavel(collection);

            return RedirectToAction(nameof(ListaResponsavel));
        }


        // GET: Responsavel/Edit/5
        public ActionResult EditarResponsavel(int id)
        {
            Models.Data.ResponsavelData rd = new Models.Data.ResponsavelData();

            return View(rd.DetalhesResponsavel(id));
        }

        // POST: Responsavel/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditarResponsavel(Models.Responsavel collection)
        {
            Models.Data.ResponsavelData rd = new Models.Data.ResponsavelData();
            rd.EditarResponsavel(collection);

            return RedirectToAction(nameof(EditarResponsavel));
        }

        // GET: Responsavel/Delete/5
        public ActionResult DeletarResponsavel(int id)
        {
            Models.Data.ResponsavelData rd = new Models.Data.ResponsavelData();

            return View(rd.DetalhesResponsavel(id));
        }

        // POST: Responsavel/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeletarResponsavel(int id, IFormCollection collection)
        {
            Models.Data.ResponsavelData rd = new Models.Data.ResponsavelData();
            rd.DeletarResponsavel(id);

            return RedirectToAction(nameof(ListaResponsavel));
        }
    }
}