using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_EXAMEN.Context;
using API_EXAMEN.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_EXAMEN.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstrumentoController : Controller
    {
        private readonly AppDbContext context;

        public InstrumentoController(AppDbContext context)
        {
            this.context = context;
        }
        // GET: api/Instrumento
        [HttpGet]
        public IEnumerable<Instrumento> Get()
        {
            var instrumento = context.Instrumento.FromSqlRaw("EXEC generarCalculos");
            return instrumento;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Instrumento>> Get(string id)
        {
            var instrumento = await context.Instrumento.FirstOrDefaultAsync(i => i.Simbolo == id);
            return instrumento;
        }

        // POST: api/Datos
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Instrumento instrumento)
        {
            try
            {
                context.Add(instrumento);
                await context.SaveChangesAsync();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        // PUT: api/Datos/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(string id, [FromBody] Instrumento instrumento)
        {
            if (instrumento.Simbolo == id)
            {
                context.Entry(instrumento).State = EntityState.Modified;
                await context.SaveChangesAsync();
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
