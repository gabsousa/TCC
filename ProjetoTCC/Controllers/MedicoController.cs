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
        public ActionResult DetalhesMedico(int id)
        {
            Models.Data.MedicoData md = new Models.Data.MedicoData();

            return View(md.DetalhesMedico(id));
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
            Models.Data.MedicoData md = new Models.Data.MedicoData();
            md.CadastrarMedico(collection);

            return RedirectToAction(nameof(ListaMedico));
        }

        // GET: Medico/Edit/5
        public ActionResult EditarMedico(int id)
        {
            Models.Data.MedicoData md = new Models.Data.MedicoData();
            
            return View(md.DetalhesMedico(id));
        }

        // POST: Medico/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditarMedico(Models.Medico collection)
        {
            Models.Data.MedicoData md = new Models.Data.MedicoData();
            md.EditarMedico(collection);

            return RedirectToAction(nameof(ListaMedico));
        }

        // GET: Medico/Delete/5
        public ActionResult DeletarMedico(int id)
        {
            Models.Data.MedicoData md = new Models.Data.MedicoData();

            return View(md.DetalhesMedico(id));
        }

        // POST: Medico/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeletarMedico(int id, IFormCollection collection)
        {
            Models.Data.MedicoData md = new Models.Data.MedicoData();
            md.DeletarMedico(id);

            return RedirectToAction(nameof(ListaMedico));
        }
    }
}