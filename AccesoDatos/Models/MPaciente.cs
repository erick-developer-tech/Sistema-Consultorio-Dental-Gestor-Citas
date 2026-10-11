using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Models
{
    public class MPaciente
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Apellidos { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
        public string Email { get; set; }
        public string Alergias { get; set; }
        public DateTime FechaRegistro { get; set; }

        public string InfoPaciente => $"{Nombre} {Apellidos} - {Alergias}";
    }
}
