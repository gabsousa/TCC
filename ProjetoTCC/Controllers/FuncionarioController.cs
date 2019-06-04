using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProjetoTCC.Controllers
{
    public class FuncionarioController : Controller
    {
        // GET: Funcionario
        public ActionResult Index()
        {
            return View();
        }

        // GET: Funcionario/Details/5
        public ActionResult DetalhesFuncionario(int id)
        {
            Models.Data.FuncionarioData fd = new Models.Data.FuncionarioData();

            return View(fd.DetalhesFuncionario(id));
        }

        public ActionResult ListaFuncionario()
        {
            Models.Data.FuncionarioData fd = new Models.Data.FuncionarioData();

            return View(fd.ListaFuncionario());
        }

        // GET: Funcionario/Create
        public ActionResult CadastrarFuncionario()
        {
            return View();
        }

        // POST: Funcionario/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CadastrarFuncionario(Models.Funcionario collection)
        {
            Models.Data.FuncionarioData fd = new Models.Data.FuncionarioData();
            fd.CadastrarFuncionario(collection);

            return RedirectToAction(nameof(ListaFuncionario));
        }

        // GET: Funcionario/Edit/5
        public ActionResult EditarFuncionario(int id)
        {
            Models.Data.FuncionarioData fd = new Models.Data.FuncionarioData();

            return View(fd.DetalhesFuncionario(id));
        }

        // POST: Funcionario/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditarFuncionario(Models.Funcionario collection)
        {
            Models.Data.FuncionarioData fd = new Models.Data.FuncionarioData();
            fd.EditarFuncionario(collection);

            return RedirectToAction(nameof(EditarFuncionario));
        }

        // GET: Funcionario/Delete/5
        public ActionResult DeletarFuncionario(int id)
        {
            Models.Data.FuncionarioData fd = new Models.Data.FuncionarioData();

            return View(fd.DetalhesFuncionario(id));
        }

        // POST: Funcionario/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeletarFuncionario(int id, IFormCollection collection)
        {
            Models.Data.FuncionarioData fd = new Models.Data.FuncionarioData();
            fd.DeletarFuncionario(id);

            return RedirectToAction(nameof(ListaFuncionario));
        }
    }
}