using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using AccesoDatos.Models;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace AccesoDatos.DTOs
{
    public class DTOEmpleado
    {
        private readonly string _conn;

        // Único constructor: obliga a pasar IConfiguration
        public DTOEmpleado(IConfiguration configuration)
        {
            _conn = configuration.GetConnectionString("SQLConnection")
                ?? throw new InvalidOperationException("No se encontró la cadena de conexión 'SQLConnection'.");
        }

        // Insertar un nuevo empleado
        public bool InsertarEmpleado(MEmpleado empleado)
        {
            var parametros = new
            {
                DNI = empleado.DNI,
                Nombre = empleado.Nombre,
                Telefono = empleado.Telefono,
                Correo = empleado.Correo,
                Turno = empleado.Turno,
                Rol = empleado.Rol,
                Usuario = empleado.Usuario,
                Contraseña = empleado.Contraseña
            };

            using (IDbConnection db = new SqlConnection(_conn))
            {
                db.Execute(
                    "sp_InsertarEmpleado",
                    parametros,
                    commandType: CommandType.StoredProcedure
                );
                return true;
            }
        }

        // Obtener los empleados
        public IEnumerable<MEmpleado> ObtenerEmpleados()
        {
            using (IDbConnection db = new SqlConnection(_conn))
            {
                return db.Query<MEmpleado>(
                    "sp_ObtenerEmpleados",
                    commandType: CommandType.StoredProcedure
                );
            }
        }

        // Buscar a un empleado
        public IEnumerable<MEmpleado> BuscarEmpleado(string textoBuscar)
        {
            var parametros = new { Criterio = textoBuscar };
            using (IDbConnection db = new SqlConnection(_conn))
            {
                return db.Query<MEmpleado>(
                    "sp_BuscarEmpleado",
                    parametros,
                    commandType: CommandType.StoredProcedure
                );
            }
        }

        // Actualizar a un empleado
        public bool ActualizarEmpleado(MEmpleado empleado)
        {
            var parametros = new
            {
                Id = empleado.Id,
                DNI = empleado.DNI,
                Nombre = empleado.Nombre,
                Telefono = empleado.Telefono,
                Correo = empleado.Correo,
                Turno = empleado.Turno,
                Rol = empleado.Rol,
                Usuario = empleado.Usuario
            };

            using (IDbConnection db = new SqlConnection(_conn))
            {
                db.Execute(
                    "sp_ActualizarEmpleado",
                    parametros,
                    commandType: CommandType.StoredProcedure
                );
                return true;
            }
        }

        // Actualizar contraseña del empleado
        public bool CambiarContraseñaEmpleado(int id, byte[] contrasenia)
        {
            var parametros = new
            {
                Id = id,
                Contraseña = contrasenia
            };

            using (IDbConnection db = new SqlConnection(_conn))
            {
                db.Execute(
                    "sp_CambiarContraseñaEmpleado",
                    parametros,
                    commandType: CommandType.StoredProcedure
                );
                return true;
            }
        }

        // Eliminar un empleado definitivamente
        public bool EliminarEmpleado(int id)
        {
            var parametros = new { Id = id };

            using (IDbConnection db = new SqlConnection(_conn))
            {
                db.Execute(
                    "sp_EliminarEmpleado",
                    parametros,
                    commandType: CommandType.StoredProcedure
                );
                return true;
            }
        }

        // Iniciar sesión (proceso de login)
        public IEnumerable<MEmpleado> Login(string usuario)
        {
            var parametros = new { Usuario = usuario };
            using (IDbConnection db = new SqlConnection(_conn))
            {
                return db.Query<MEmpleado>(
                    "sp_ValidarLogin",
                    parametros,
                    commandType: CommandType.StoredProcedure
                );
            }
        }
    }
}