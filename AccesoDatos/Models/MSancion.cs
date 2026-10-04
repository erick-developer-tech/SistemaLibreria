using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Models
{
    public class MSancion
    {
        public int Id { get; set; }
        public int IdPrestamo { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaLimite { get; set; }
        public int IdLector { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Motivo { get; set; } = string.Empty;
        public decimal Multa { get; set; }
        public string Estado { get; set; } = string.Empty;
    }
}
