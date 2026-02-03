using Microsoft.EntityFrameworkCore;
using MiBackend.Models;

namespace MiBackend.Data
{
    public class PeluqueriaContext : DbContext
    {
        public PeluqueriaContext(DbContextOptions<PeluqueriaContext> options)
            : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Servicio> Servicios { get; set; }
        public DbSet<Turno> Turnos { get; set; }
    }
}
