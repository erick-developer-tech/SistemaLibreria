using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Models
{
    public class MEjemplar
    {
        public int Id { get; set; }
        public int IdLibro { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string CodigoBarras { get; set; } = string.Empty;
        public string Estado { get; set; } = string.Empty;
    }
}
