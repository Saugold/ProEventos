using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Data;
using ProEventos.API.Models;
using System.Reflection.Metadata.Ecma335;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventosController : ControllerBase
    {
        private readonly DataContext _context;
        public EventosController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _context.Eventos;
        }
         
        [HttpGet("{id}")]
        public ActionResult GetById(int id)
        {
            var evento = _context.Eventos.FirstOrDefault(evento => evento.EventoId == id);
            if (evento == null)
                return NotFound();
            return Ok(evento);
        }
    }
}
