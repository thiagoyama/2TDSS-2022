using Fiap.Aula04.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Fiap.Aula04.Web.Controllers
{
    public class CarroController : Controller
    {
        //Lista de carro para simular o banco de dados
        private static List<Carro> _lista = new List<Carro>();

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet] //Abrir a página com o formulário HTML
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Carro carro)
        {
            //Adicionar o carro na lista
            _lista.Add(carro);
            //Mandar uma mensagem de sucesso para a view
            TempData["msg"] = "Carro cadastrado!";
            return View();
        }

    }
}
