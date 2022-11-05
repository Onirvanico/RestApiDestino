using CSharpRest.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CSharpRest.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class DestinoController : ControllerBase
    {
        public readonly DestinoDBContext _context;
        public DestinoController(DestinoDBContext context)
        {
            _context = context;
        }
        // GET: api/<DestinoController>
        [HttpGet]
        public IEnumerable<Destino> Get()
        {
            return _context.Destinos;
        }

        // GET api/<DestinoController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Destino produto = _context.Destinos.SingleOrDefault(model => model.ID == id);
            if (produto == null) return NotFound();
            else return new ObjectResult(produto);
        }

        // POST api/<DestinoController>
        [HttpPost]
        public IActionResult Post([FromBody] Destino destino)
        {
            if (destino == null) return BadRequest();

            _context.Destinos.Add(destino);
            _context.SaveChanges();
            return CreatedAtAction("Get", new { id = destino.ID }, destino);
        }

        // PUT api/<DestinoController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Destino destino)
        {
            if (id != destino.ID) return BadRequest();
            _context.Entry(destino).State = EntityState.Modified;
            _context.SaveChanges();
            return new NoContentResult();
        }

        // DELETE api/<DestinoController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var destino = _context.Destinos.SingleOrDefault(model => model.ID == id);

            if (destino == null) return BadRequest();
            _context.Remove(destino);
            _context.SaveChanges();
            return Ok(destino);
        }
    }
}
