using Fiap.Aula05.Web.Models;
using Fiap.Aula05.Web.Persistencia;
using Microsoft.AspNetCore.Mvc;

namespace Fiap.Aula05.Web.Controllers
{
    public class ServicoController : Controller
    {
        private GestaoAereaContext _context;

        public ServicoController(GestaoAereaContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.lista = _context.Servicos.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Servico servico)
        {
            //Realizar o cadastro!
            _context.Servicos.Add(servico);
            _context.SaveChanges();
            TempData["msg"] = "Serviço registrado";
            return RedirectToAction("Index");
        }

    }
}
