using Fiap.Aula04.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Fiap.Aula04.Web.Controllers
{
    public class CarroController : Controller
    {
        //Lista de carro para simular o banco de dados
        private static List<Carro> _lista = new List<Carro>();
        private static int _id = 0; //Controla o ID

        [HttpPost]
        public IActionResult Remover(int id)
        {
            //Remover o carro da lista
            _lista.RemoveAt(_lista.FindIndex(c => c.Codigo == id));
            //Mensagem de sucesso
            TempData["msg"] = "Carro removido!";
            //Redirecionar para a listagem
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Editar(Carro carro)
        {
            //Atualizar o carro na lista
            var index = _lista.FindIndex(c => c.Codigo == carro.Codigo);
            //Substitui o objeto na posição do carro antigo
            _lista[index] = carro;
            //Mensagem de sucesso
            TempData["msg"] = "Carro atualizado!";
            //Redirect para a listagem/editar
            return RedirectToAction("editar");
        }

        [HttpGet] //Abrir o formulário com os dados preenchidos
        public IActionResult Editar(int id)
        {
            //Enviar as opções do select de marcas
            CarregarMarcas();
            //Recuperar a posição do carro na lista através do id
            var index = _lista.FindIndex(c => c.Codigo == id);
            //Recuperar o carro através do ID
            var carro = _lista[index];
            //Enviar o carro para a view
            return View(carro);
        }

        public IActionResult Index()
        {
            //Enviar a lista de carro para a view
            return View(_lista);
        }

        [HttpGet] //Abrir a página com o formulário HTML
        public IActionResult Cadastrar()
        {
            CarregarMarcas();
            return View();
        }

        private void CarregarMarcas()
        {
            //Criar uma lista de string com as marcas
            var lista = new List<string>(new string[] {"FIAT", "Hyundai",
                "Ford", "Volkswagen", "Caoa"});
            //Envia as opções do select da marca para a view
            ViewBag.marcas = new SelectList(lista);
        }

        [HttpPost]
        public IActionResult Cadastrar(Carro carro)
        {
            //Setar o código do carro
            carro.Codigo = ++_id;
            //Adicionar o carro na lista
            _lista.Add(carro);
            //Mandar uma mensagem de sucesso para a view
            TempData["msg"] = "Carro cadastrado!";
            //Redireciona para o método Cadastrar
            return RedirectToAction("Cadastrar");
        }
    }
}
