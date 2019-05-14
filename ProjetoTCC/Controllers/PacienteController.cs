using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProjetoTCC.Controllers
{
    public class PacienteController : Controller
    {
        // GET: Paciente
        public ActionResult Index()
        {
            return View();
        }

        // GET: Paciente/Details/5
        public ActionResult DetalhesPaciente(int id)
        {
            Models.Data.PacienteData cd = new Models.Data.PacienteData();

            return View(cd.DetalhesPaciente(id));
        }

        public ActionResult ListaPaciente()
        {
            Models.Data.PacienteData td = new Models.Data.PacienteData();

            return View(td.ListaPaciente());
        }

        // GET: Paciente/Create
        public ActionResult CadastrarPaciente()
        {
            return View();
        }

        // POST: Paciente/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CadastrarPaciente(Models.Paciente collection)
        {
            Models.Data.PacienteData pacienteData = new Models.Data.PacienteData();
            pacienteData.CadastrarPaciente(collection);

            return RedirectToAction(nameof(ListaPaciente));
        }
    

        // GET: Paciente/Edit/5
        public ActionResult EditarPaciente(int id)
        {
        Models.Data.PacienteData pd = new Models.Data.PacienteData();

        return View(pd.DetalhesPaciente(id));
        }

        // POST: Paciente/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditarPaciente(int id, Models.Paciente collection)
        {
        Models.Data.PacienteData pacienteData = new Models.Data.PacienteData();
        pacienteData.EditarPaciente(collection);

        return RedirectToAction(nameof(EditarPaciente));
        }
        

        // GET: Paciente/Delete/5
        public ActionResult DeletarPaciente(int id)
        {
            return View();
        }

        // POST: Paciente/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeletarPaciente(int id, IFormCollection collection)
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