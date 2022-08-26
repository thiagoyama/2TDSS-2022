using Fiap.Aula03.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Fiap.Aula03.Web.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet] //Retornar a página com o formulário
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost] //Receber os parâmetros do formulário
        public IActionResult Cadastrar(Produto produto)
        {
            //Enviar a descrição do produto para a página
            ViewData["desc"] = $"Descrição: {produto.Descricao}";
            //Enviar o objeto produto para a view
            ViewBag.prod = produto;
            return View("Sucesso");
            //return Content($"Descrição: {produto.Descricao}, Valor: {produto.Valor}");
        }

        public IActionResult Estoque()
        {
            return View();
        }

    }
}
