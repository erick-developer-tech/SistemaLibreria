using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Data.SqlClient;
using AccesoDatos.Models;
using System.Data;

namespace AccesoDatos.DTOs
{
    public class DTOLector
    {
        private readonly string _conn;

        // Único constructor: obliga a pasar IConfiguration
        public DTOLector(IConfiguration configuration)
        {
            _conn = configuration.GetConnectionString("SQLConnection")
                ?? throw new InvalidOperationException("No se encontró la cadena de conexión 'SQLConnection'.");
        }

        // Método para insertar un nuevo lector
        public bool InsertarLector(MLector lec) 
        {
            var parametros = new
            {
                DNI = lec.DNI,
                Nombre = lec.Nombre,
                Telefono = lec.Telefono,
                Correo = lec.Correo
            };
            using (IDbConnection db = new SqlConnection(_conn)) 
            {
                db.Execute(
                    "sp_InsertarLector",
                    parametros,
                    commandType: CommandType.StoredProcedure
                    );
                return true;
            }
        }

        // Método para obtener los lectores
        public IEnumerable<MLector> ObtenerLectores() 
        {
            using (IDbConnection db = new SqlConnection(_conn)) 
            {
                return db.Query<MLector>(
                    "sp_ObtenerLectores",
                    commandType : CommandType.StoredProcedure
                    );
            }
        }

        // Método para obtener los lectores
        public IEnumerable<MLector> BuscarLector(string textoBuscar)
        {
            var parametros = new { Criterio = textoBuscar};
            using (IDbConnection db = new SqlConnection(_conn))
            {
                return db.Query<MLector>(
                    "sp_BuscarLector",
                    parametros,
                    commandType: CommandType.StoredProcedure
                    );
            }
        }

        // Método para actualizar un lector
        public bool ActualizarLector(MLector lec)
        {
            var parametros = new
            {
                Id = lec.Id,
                DNI = lec.DNI,
                Nombre = lec.Nombre,
                Telefono = lec.Telefono,
                Correo = lec.Correo
            };
            using (IDbConnection db = new SqlConnection(_conn))
            {
                db.Execute(
                    "sp_ActualizarLector",
                    parametros,
                    commandType: CommandType.StoredProcedure
                    );
                return true;
            }
        }

        // Método para eliminar un lector
        public bool EliminarLector(int id)
        {
            var parametros = new
            {
                Id = id
            };
            using (IDbConnection db = new SqlConnection(_conn))
            {
                db.Execute(
                    "sp_EliminarLector",
                    parametros,
                    commandType: CommandType.StoredProcedure
                    );
                return true;
            }
        }
    }
}
