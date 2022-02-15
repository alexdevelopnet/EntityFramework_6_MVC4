using Data;

using Domain.Entity;
using System.Web.Mvc;

namespace WebMVC1.Controllers
{
    public class ProdutoController : Controller
    {
     
         
        public ProdutoController( )
        {
       
        }
        // GET: Produto
        public ActionResult Index()
        {
          //  ProdutoRepository _repository = new ProdutoRepository();
          //  Produto produto = new Produto("Feijão", 1);
          //  _repository.Incluir(produto);


          //var  produtos= _repository.Listar();

           // ViewBag.produtos =produtos ;
            return View();
        }
    }
}