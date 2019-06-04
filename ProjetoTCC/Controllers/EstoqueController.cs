using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProjetoTCC.Controllers
{
    public class EstoqueController : Controller
    {
        // GET: Estoque
        public ActionResult Index()
        {
            return View();
        }

        // GET: Estoque/Details/5
        public ActionResult DetalhesEstoque(int id)
        {
            Models.Data.EstoqueData ed = new Models.Data.EstoqueData();

            return View(ed.DetalhesEstoque(id));
        }

        public ActionResult ListaEstoque()
        {
            Models.Data.EstoqueData ed = new Models.Data.EstoqueData();

            return View(ed.ListaEstoque());
        }

        // GET: Estoque/Create
        public ActionResult CadastrarEstoque()
        {
            return View();
        }

        // POST: Estoque/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CadastrarEstoque(Models.Estoque collection)
        {
            Models.Data.EstoqueData ed = new Models.Data.EstoqueData();
            ed.CadastrarEstoque(collection);

            return RedirectToAction(nameof(ListaEstoque));
        }

        // GET: Estoque/Edit/5
        public ActionResult EditarEstoque(int id)
        {
            Models.Data.EstoqueData ed = new Models.Data.EstoqueData();

            return View(ed.DetalhesEstoque(id));
        }

        // POST: Estoque/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditarEstoque(int id, Models.Estoque collection)
        {
            Models.Data.EstoqueData ed = new Models.Data.EstoqueData();
            ed.EditarEstoque(collection);

            return RedirectToAction(nameof(ListaEstoque));
        }

        // GET: Estoque/Delete/5
        public ActionResult DeletarEstoque(int id)
        {
            Models.Data.EstoqueData ed = new Models.Data.EstoqueData();

            return View(ed.DetalhesEstoque(id));
        }

        // POST: Estoque/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeletarEstoque(int id, IFormCollection collection)
        {
            Models.Data.EstoqueData md = new Models.Data.EstoqueData();
            md.DeletarEstoque(id);

            return RedirectToAction(nameof(ListaEstoque));
        }
    }
}