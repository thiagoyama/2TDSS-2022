using Fiap.Aula05.Web.Models;
using Fiap.Aula05.Web.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Fiap.Aula05.Web.Controllers
{
    public class PassagemController : Controller
    {
        private GestaoAereaContext _context;

        public PassagemController(GestaoAereaContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            //Pesquisar todos os voos
            var lista = _context.Voos.ToList();
            //Envia o selectlist para view definir as opções do select
                                        //lista, Value, Texto
            ViewBag.voos = new SelectList(lista,"VooId","Destino");
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Passagem passagem)
        {
            _context.Passagens.Add(passagem);
            _context.SaveChanges();
            TempData["msg"] = "Passagem registrada";
            return RedirectToAction("Cadastrar");
        }

        [HttpGet]
        public IActionResult Index()
        {
            var lista = _context.Passagens.Include(p => p.Voo).ToList();
            return View(lista);
        }

    }
}
