using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Models
{
    public class MUsuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Apellidos { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
        public string Email { get; set; }
        public string Horario { get; set; } = string.Empty;
        public string Usuario { get; set; } = string.Empty;
        public byte[] Contraseña { get; set; } = Array.Empty<byte>();
        public string Rol { get; set; } = string.Empty;
        public bool Activo { get; set; }

        public string InfoUsuario => $"{Nombre} {Apellidos}";
    }
}
