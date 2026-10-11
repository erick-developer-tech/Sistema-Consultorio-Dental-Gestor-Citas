using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Models
{
    public class MCita
    {
        public int Id { get; set; }
        public int IdUsuario {get; set;}
        public string Usuario { get; set; } = string.Empty;
        public int IdPaciente { get; set; }
        public string Paciente { get; set; } = string.Empty;
        public int IdServicio { get; set; }
        public string Servicio { get; set; } = string.Empty;
        public decimal Costo { get; set; }
        public DateTime FechaHora { get; set; }
        public string Estado { get; set; } = string.Empty;
        public bool Pagado { get; set; }
        public string Notas { get; set; }
    }
}
