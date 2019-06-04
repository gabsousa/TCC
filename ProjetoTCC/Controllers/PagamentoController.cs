using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProjetoTCC.Controllers
{
    public class PagamentoController : Controller
    {
        // GET: Pagamento
        /*public ActionResult Index()
        {
            return View();
        }

        // GET: Pagamento/Details/5
        public ActionResult DetalhesPagamento(int id)
        {
            Models.Data.PagamentoData pd = new Models.Data.PagamentoData();

            return View(pd.DetalhesPagamento(id));
        }

        // GET: Pagamento/Create
        public ActionResult CadastrarPagamento()
        {
            return View();
        }

        // POST: Pagamento/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CadastrarPagamento(Models.Pagamento collection)
        {
            Models.Data.PagamentoData pd = new Models.Data.PagamentoData();
            pd.CadastrarPagamento(collection);

            return RedirectToAction(nameof(ListaPagamento));
        }

        // GET: Pagamento/Edit/5
        public ActionResult EditarPagamento(int id)
        {
            Models.Data.PagamentoData pd = new Models.Data.PagamentoData();

            return View(pd.DetalhesPagamento(id));
        }

        // POST: Pagamento/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditarPagamento(Models.Pagamento collection)
        {
            Models.Data.PagamentoData pd = new Models.Data.PagamentoData();
            pd.EditarPagamento(collection);

            return RedirectToAction(nameof(ListaPagamento));
        }

        // GET: Pagamento/Delete/5
        public ActionResult DeletarPagamento(int id)
        {
            Models.Data.PagamentoData pd = new Models.Data.PagamentoData();

            return View(pd.DetalhesPagamento(id));
        }

        // POST: Pagamento/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeletarPagamento(int id, IFormCollection collection)
        {
            Models.Data.PagamentoData pd = new Models.Data.PagamentoData();
            pd.DeletarPagamento(id);

            return RedirectToAction(nameof(ListaPagamento));
        }*/
    }
}