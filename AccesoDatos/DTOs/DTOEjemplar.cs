using AccesoDatos.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace AccesoDatos.DTOs
{
    public class DTOEjemplar
    {
        private readonly string _conn;

        // Único constructor: obliga a pasar IConfiguration
        public DTOEjemplar(IConfiguration configuration)
        {
            _conn = configuration.GetConnectionString("SQLConnection")
                ?? throw new InvalidOperationException("No se encontró la cadena de conexión 'SQLConnection'.");
        }

        // Método para insertar un nuevo ejemplar
        public bool InsertarEjemplar(MEjemplar eje)
        {
            var parametros = new
            {
                IdLibro = eje.IdLibro,
                CodigoBarras = eje.CodigoBarras,
                Estado = eje.Estado
            };
            using (IDbConnection db = new SqlConnection(_conn))
            {
                db.Execute(
                    "sp_InsertarEjemplar",
                    parametros,
                    commandType: CommandType.StoredProcedure
                    );
                return true;
            }
        }
        // Método para obtener los ejemplares
        public IEnumerable<MEjemplar> ObtenerEjemplares()
        {
            using (IDbConnection db = new SqlConnection(_conn))
            {
                return db.Query<MEjemplar>(
                    "sp_ObtenerEjemplares",
                    commandType: CommandType.StoredProcedure
                    );
            }
        }

        // Método para buscar uno o mas ejemplares
        public IEnumerable<MEjemplar> BuscarEjemplar(string textoBuscar)
        {
            var parametros = new { Criterio = textoBuscar };
            using (IDbConnection db = new SqlConnection(_conn))
            {
                return db.Query<MEjemplar>(
                    "sp_BuscarEjemplar",
                    parametros,
                    commandType: CommandType.StoredProcedure
                    );
            }
        }

        // Método para actualizar un ejemplar
        public bool ActualizarEjemplar(MEjemplar eje)
        {
            var parametros = new
            {
                Id = eje.Id,
                IdLibro = eje.IdLibro,
                CodigoBarras = eje.CodigoBarras,
                Estado = eje.Estado
            };
            using (IDbConnection db = new SqlConnection(_conn))
            {
                db.Execute(
                    "sp_ActualizarEjemplar",
                    parametros,
                    commandType: CommandType.StoredProcedure
                    );
                return true;
            }
        }

        // Método para eliminar un ejemplar
        public bool EliminarEjemplar(int id)
        {
            var parametros = new
            {
                Id = id
            };
            using (IDbConnection db = new SqlConnection(_conn))
            {
                db.Execute(
                    "sp_EliminarEjemplar",
                    parametros,
                    commandType: CommandType.StoredProcedure
                    );
                return true;
            }
        }
    }
}
