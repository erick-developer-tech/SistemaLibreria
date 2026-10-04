using AccesoDatos.Models;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.DTOs
{
    public class DTOSancion
    {
        private readonly string _conn;

        // Único constructor: obliga a pasar IConfiguration
        public DTOSancion(IConfiguration configuration)
        {
            _conn = configuration.GetConnectionString("SQLConnection")
                ?? throw new InvalidOperationException("No se encontró la cadena de conexión 'SQLConnection'.");
        }

        // Método para insertar la sanción
        public bool InsertarSancion(MSancion msancion)
        {
            var parametros = new
            {
                IdPrestamo = msancion.IdPrestamo,
                Motivo = msancion.Motivo,
                Multa = msancion.Multa
            };
            using (IDbConnection db = new SqlConnection(_conn))
            {
                db.Execute(
                    "sp_InsertarSancion",
                    parametros,
                    commandType: CommandType.StoredProcedure
                    );
                return true;
            }
        }

        // Método para actualizar la sanción
        public bool ActualizarSancion(MSancion msancion)
        {
            var parametros = new
            {
                Id = msancion.Id,
                IdPrestamo = msancion.IdPrestamo,
                Motivo = msancion.Motivo,
                Multa = msancion.Multa,
                Estado = msancion.Estado
            };
            using (IDbConnection db = new SqlConnection(_conn))
            {
                db.Execute(
                    "sp_ActualizarSancion",
                    parametros,
                    commandType: CommandType.StoredProcedure
                    );
                return true;
            }
        }

        // Método para obtener todas las sanciones
        public IEnumerable<MSancion> ObtenerSanciones()
        {
            using (IDbConnection db = new SqlConnection(_conn))
            {
                return db.Query<MSancion>(
                    "sp_ObtenerSanciones",
                    commandType: CommandType.StoredProcedure
                    );
            }
        }

        // Método para buscar una sanción por nombre del lector
        public IEnumerable<MSancion> BuscarSanciones(string criterio)
        {
            var parametros = new
            {
                Criterio = criterio
            };
            using (IDbConnection db = new SqlConnection(_conn))
            {
                return db.Query<MSancion>(
                    "sp_BuscarSancion",
                    parametros,
                    commandType: CommandType.StoredProcedure
                    );
            }
        }

        // Método para eliminar la sanción
        public bool EliminarSancion(int id)
        {
            var parametros = new
            {
                Id = id
            };
            using (IDbConnection db = new SqlConnection(_conn))
            {
                db.Execute(
                    "sp_EliminarSancion",
                    parametros,
                    commandType: CommandType.StoredProcedure
                    );
                return true;
            }
        }
    }
}
