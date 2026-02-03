using Microsoft.AspNetCore.Mvc;
using MiBackend.Data;
using MiBackend.Models;

namespace MiBackend.Controllers
{
    [ApiController]
    [Route("api/turnos")]
    public class TurnosController : ControllerBase
    {
        private readonly PeluqueriaContext _context;

        public TurnosController(PeluqueriaContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Turnos.ToList());
        }

        [HttpPost]
        public IActionResult Post(Turno turno)
        {
            _context.Turnos.Add(turno);
            _context.SaveChanges();
            return Ok(turno);
        }
    }
}
