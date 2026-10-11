using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Models
{
    public class MReceta
    {
        public int Id { get; set; }
        public int IdCita { get; set; }
        public string Paciente { get; set; } = string.Empty;
        public string Servicio { get; set; } = string.Empty;      
        public DateTime FechaCita { get; set; }
        public string Diagnostico { get; set; } = string.Empty;
        public string Tratamiento { get; set; } = string.Empty;
        public DateTime FechaEmision { get; set; }
    }
}
