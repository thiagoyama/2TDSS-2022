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

        public IActionResult Index()
        {
            return View();
        }
    }
}
