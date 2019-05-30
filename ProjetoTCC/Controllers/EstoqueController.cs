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
        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult ListaEstoque()
        {
            Models.Data.EstoqueData td = new Models.Data.EstoqueData();

            return View(td.ListaEstoque());
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
            Models.Data.EstoqueData estoqueData = new Models.Data.EstoqueData();
            estoqueData.CadastrarEstoque(collection);

            return RedirectToAction(nameof(ListaEstoque));
        }

        // GET: Estoque/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Estoque/Edit/5
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

        // GET: Estoque/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Estoque/Delete/5
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