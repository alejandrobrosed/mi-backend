using System;

namespace MiBackend.Models
{
    public class Turno
    {
        public int Id { get; set; }
        public DateTime FechaHora { get; set; }

        public int ClienteId { get; set; }
        public int ServicioId { get; set; }
    }
}
