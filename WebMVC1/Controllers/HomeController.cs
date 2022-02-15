using Data;
using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebMVC1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ProdutoRepository _repository = new ProdutoRepository();

            Produto produto = new Produto() { Nome = "Feijão", CategoriaId = 1 };
           
            _repository.Incluir(produto);

            var produtos = _repository.Listar();

            ViewBag.produtos = produtos;
            return View();

        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}