using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Models
{
    public class MEmpleado
    {
        public int Id { get; set; }
        public string DNI { get; set; } = string.Empty;
        public string Nombre { get; set; } = string.Empty;

        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Turno { get; set; } = string.Empty;
        public string Usuario { get; set; } = string.Empty;
        public byte[] Contraseña { get; set; } = Array.Empty<byte>();
        public string Rol { get; set; } = string.Empty;

    }
}
