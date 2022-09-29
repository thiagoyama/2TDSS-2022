using Fiap.Aula05.Web.Models;
using Fiap.Aula05.Web.Persistencia;
using Microsoft.AspNetCore.Mvc;

namespace Fiap.Aula05.Web.Controllers
{
    public class VooController : Controller
    {
        private GestaoAereaContext _context;

        //O contexto é injetado no construtor
        public VooController(GestaoAereaContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Cadastrar(Voo voo)
        {
            //Cadastrar no banco
            _context.Voos.Add(voo);
            _context.SaveChanges();
            //Mensagem de sucesso
            TempData["msg"] = "Voo cadastrado!";
            //Redirecionar para o cadastrar
            return RedirectToAction("Cadastrar");
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        public IActionResult Index()
        {
            //Recuperar os voos cadastrados
            var lista = _context.Voos.ToList();
            //Enviar a lista para a view
            return View(lista);
        }
    }
}
