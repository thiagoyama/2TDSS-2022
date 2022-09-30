﻿using Fiap.Aula05.Web.Models;
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
            var voo = _context.Voos.Find(id);
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
                .ToList();
            //Enviar a lista para a view
            return View(lista);
        }
    }
}
