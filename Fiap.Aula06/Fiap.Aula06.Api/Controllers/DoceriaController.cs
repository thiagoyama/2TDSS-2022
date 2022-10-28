using Fiap.Aula06.Api.Models;
using Fiap.Aula06.Api.Persistencia;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Fiap.Aula06.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoceriaController : ControllerBase
    {
        //Propriedade do contexto
        private DoceriaContext _context;

        //Receber no construtor o contexto
        public DoceriaController(DoceriaContext context)
        {
            _context = context;
        }

        [HttpGet]//GET api/doceria
        public ActionResult<IList<Doceria>> Get()
        {
            return _context.Docerias.ToList();
        }
        
        [HttpGet("{id}")] //GET api/doceria/1
        public ActionResult<Doceria> Get(int id)
        {
            var doceria = _context.Docerias.Find(id);
            if (doceria == null)
                return NotFound();
            return doceria;
        }

        [HttpPost] //POST api/doceria
        public ActionResult<Doceria> Post(Doceria doceria)
        {
            //cadastrar
            _context.Docerias.Add(doceria);
            _context.SaveChanges();
            //retornar o 201 
            return CreatedAtAction("Get", new { id = doceria.DoceriaId }, doceria);
        }

        [HttpPut("{id}")]//PUT api/doceria/1
        public ActionResult Put(Doceria doceria, int id)
        {
            //Pesqusiar a doceria
            var doce = _context.Docerias.Find(id);
            //Validar se existe a doceria, se não 404
            if (doce == null)
                return NotFound();
            //Tirar o objeto "doce" do gerenciamento do DbContext
            _context.Entry(doce).State = EntityState.Detached;
            //Setar o id da doceria
            doceria.DoceriaId = id;
            //Atualiza
            _context.Docerias.Update(doceria);
            _context.SaveChanges();
            //Retorna 204 NoContent
            return NoContent();
        }

        [HttpDelete("{id}")] //Delete api/doceria/1
        public ActionResult Delete(int id)
        {
            //Pesquisar a doceria
            var doceria = _context.Docerias.Find(id);
            //Validar se existe a doceria, se não 404
            if (doceria == null)
                return NotFound();
            //Remove
            _context.Docerias.Remove(doceria);
            _context.SaveChanges();
            //Retorna 204 NoContent
            return NoContent();
        }

    }
}
