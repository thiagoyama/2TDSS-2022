using Fiap.Aula05.Web.Models;
using Fiap.Aula05.Web.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

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
        public IActionResult Adicionar(VooServico vooServico)
        {
            //Pesquisou o voo
            var voo = _context.Voos.Find(vooServico.VooId);
            if (voo.Data > DateTime.Now)
            {
                //Cadastrar o vooServico
                _context.VoosServicos.Add(vooServico);
                _context.SaveChanges();
                //Mensagem
                TempData["msg"] = "Serviço adicionado!";
            }
            else
            {
                TempData["msg"] = "Não é possível adicionar";
            }
            //Redirect para o detalhar
            return RedirectToAction("Detalhar", new { id = vooServico.VooId});
        }

        [HttpGet]
        public IActionResult Detalhar(int id)
        {
            //Pesquisar pelos servicos associados ao voo
            var vooServico = _context.VoosServicos
                .Where(v => v.VooId == id) //Filtro
                .Select(v => v.Servico) //Seleciona o retorno da pesquisa
                .ToList();
            //Enviar a lista de serviços associados ao voo
            ViewBag.vooServico = vooServico;
            //Listar todos os serviços
            var lista = _context.Servicos.ToList();

            //Filtrar a lista de serviços
            //var listaFiltrada = new List<Servico>();
            //foreach (var item in lista)
            //{
            //    if (!vooServico.Contains(item))
            //    {
            //        listaFiltrada.Add(item);
            //    }
            //}

            var listaFiltrada = lista.Where(v => !vooServico.Contains(v));

            //Enviar a lista de serviços para a view (select)
            ViewBag.servicos = new SelectList(listaFiltrada, "ServicoId", "Descricao");
            //Pesquisar o voo por id
            var voo = _context.Voos
                .Where(v => v.VooId == id)
                .Include(v => v.Passagens)
                .FirstOrDefault();
            //Enviar o voo para a view
            return View(voo);
        }

        [HttpPost]
        public IActionResult Remover(int id)
        {
            //Remover do banco
            var voo = _context.Voos.Find(id);
            _context.Voos.Remove(voo);
            _context.SaveChanges();
            //Mensagem
            TempData["msg"] = "Voo removido!";
            //Redirect
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Editar(Voo voo)
        {
            //Atualizar o voo no banco
            _context.Voos.Update(voo);
            _context.SaveChanges();
            //Mensagem
            TempData["msg"] = "Voo atualizado!";
            //Redirect
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Editar(int id)
        {
            //Pesquisar o voo pelo id
            var voo = _context.Voos
                .Include(v => v.Frequencia) //Adiciona o relacionamento no retorno
                .Where(v => v.VooId == id) //filtro pela PK
                .FirstOrDefault(); //retorar o primeiro ou null
            //Retornar a view com os dados do voo
            return View(voo);
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

        public IActionResult Index(bool escala, string origem)
        {
            //Recuperar os voos cadastrados
            var lista = _context.Voos
                .Where(v => (v.Origem.Contains(origem) || origem == null)
                    && (v.Escala == escala  || !escala))
                .Include(v => v.Frequencia) //Inclui o relacionamento na pesquisa
                .ToList();
            //Enviar a lista para a view
            return View(lista);
        }
    }
}
