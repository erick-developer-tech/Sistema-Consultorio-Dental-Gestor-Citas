using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Models
{
    public class MServicio
    {
        public int Id { get; set; }
        public string Servicio { get; set; } = string.Empty;
        public decimal Costo { get; set; }
    }
}
