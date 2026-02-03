using Microsoft.AspNetCore.Mvc;
using MiBackend.Data;
using MiBackend.Models;

namespace MiBackend.Controllers
{
    [ApiController]
    [Route("api/servicios")]
    public class ServiciosController : ControllerBase
    {
        private readonly PeluqueriaContext _context;

        public ServiciosController(PeluqueriaContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Servicios.ToList());
        }

        [HttpPost]
        public IActionResult Post(Servicio servicio)
        {
            _context.Servicios.Add(servicio);
            _context.SaveChanges();
            return Ok(servicio);
        }
    }
}
