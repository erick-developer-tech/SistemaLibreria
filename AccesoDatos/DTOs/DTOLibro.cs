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
    public class DTOLibro
    {
        private readonly string _conn;

        // Único constructor: obliga a pasar IConfiguration
        public DTOLibro(IConfiguration configuration)
        {
            _conn = configuration.GetConnectionString("SQLConnection")
                ?? throw new InvalidOperationException("No se encontró la cadena de conexión 'SQLConnection'.");
        }

        // Método para insertar un nuevo libro
        public bool InsertarLibro(MLibro lib)
        {
            var parametros = new
            {
                Titulo = lib.Titulo,
                Autor = lib.Autor,
                Editorial = lib.Editorial,
                Año = lib.Año
            };
            using (IDbConnection db = new SqlConnection(_conn))
            {
                db.Execute(
                    "sp_InsertarLibro",
                    parametros,
                    commandType: CommandType.StoredProcedure
                    );
                return true;
            }
        }

        // Método para obtener los libros
        public IEnumerable<MLibro> ObtenerLibros()
        {
            using (IDbConnection db = new SqlConnection(_conn))
            {
                return db.Query<MLibro>(
                    "sp_ObtenerLibros",
                    commandType: CommandType.StoredProcedure
                    );
            }
        }

        // Método para buscar un libro o libros
        public IEnumerable<MLibro> BuscarLibro(string textoBuscar)
        {
            var parametros = new { Criterio = textoBuscar };
            using (IDbConnection db = new SqlConnection(_conn))
            {
                return db.Query<MLibro>(
                    "sp_BuscarLibro",
                    parametros,
                    commandType: CommandType.StoredProcedure
                    );
            }
        }

        // Método para actualizar un libro
        public bool ActualizarLibro(MLibro lib)
        {
            var parametros = new
            {
                Id = lib.Id,
                Titulo = lib.Titulo,
                Autor = lib.Autor,
                Editorial = lib.Editorial,
                Año = lib.Año
            };
            using (IDbConnection db = new SqlConnection(_conn))
            {
                db.Execute(
                    "sp_ActualizarLibro",
                    parametros,
                    commandType: CommandType.StoredProcedure
                    );
                return true;
            }
        }

        // Método para eliminar un libro
        public bool EliminarLibro(int id)
        {
            var parametros = new
            {
                Id = id
            };
            using (IDbConnection db = new SqlConnection(_conn))
            {
                db.Execute(
                    "sp_EliminarLibro",
                    parametros,
                    commandType: CommandType.StoredProcedure
                    );
                return true;
            }
        }
    }
}
