using Fiap.Aula05.Web.Models;
using Fiap.Aula05.Web.Persistencia;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Fiap.Aula05.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private GestaoAereaContext _context;

        public HomeController(ILogger<HomeController> logger, GestaoAereaContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            //Contar a quantidade de voos cadastrados
            var qtd = _context.Voos.Count();
            //Enviar o valor para a view
            ViewBag.total = qtd;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}