using Microsoft.AspNetCore.Mvc;
using MiBackend.Data;
using MiBackend.Models;

namespace MiBackend.Controllers
{
    [ApiController]
    [Route("api/clientes")]
    public class ClientesController : ControllerBase
    {
        private readonly PeluqueriaContext _context;

        public ClientesController(PeluqueriaContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Clientes.ToList());
        }

        [HttpPost]
        public IActionResult Post(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
            return Ok(cliente);
        }
    }
}
