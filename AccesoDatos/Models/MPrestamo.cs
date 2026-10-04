using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Models
{
    // La lista y busqueda provendran de esta clase
    public class MPrestamo
    {
        public int Id { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaLimite { get; set; }
        public int IdLector { get; set; }
        public string Lector { get; set; } = string.Empty;
        public int IdEmpleado { get; set; }
        public string Empleado { get; set; } = string.Empty;
        public string Observaciones { get; set; }

        // Propiedad combinada para mostrar en el ComboBox
        public string InfoCombo => $"#Préstamo {Id} - {Lector} ({FechaInicio:dd/MM/yyyy})";
        // Una cabecera de prestamo tiene una lista de uno o varios detalles
        public List<MDetallePrestamo> Detalles { get; set; } = new List<MDetallePrestamo>();
    }

    // Esta clase es solo para ver el detalle del prestamo
    public class MDetallePrestamo
    {
        public int IdDetalle { get; set; }
        public int IdPrestamo { get; set; }
        public int IdEjemplar { get; set; }
        public string CodigoBarras { get; set; } = string.Empty;
        public string Titulo { get; set; } = string.Empty;
        public DateTime? FechaDevolucion { get; set; }
        public string Estado { get; set; } = string.Empty;
    }
}
