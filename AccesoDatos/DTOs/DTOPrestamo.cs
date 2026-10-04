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
    public class DTOPrestamo
    {
        private readonly string _conn;

        public DTOPrestamo(IConfiguration configuration)
        {
            _conn = configuration.GetConnectionString("SQLConnection")
                ?? throw new InvalidOperationException("No se encontró la cadena de conexión 'SQLConnection'.");
        }

        // Método completo que permitea insertar el prestamo junto con sus detalles
        public bool RegistrarPrestamo(MPrestamo mPrestamo)
        {
            using (var conexion = new SqlConnection(_conn))
            {
                conexion.Open();

                using (var transaccion = conexion.BeginTransaction())
                {
                    try
                    {
                        // Asignamos los parametros
                        var parametros = new
                        {
                            mPrestamo.FechaLimite,
                            mPrestamo.IdLector,
                            mPrestamo.IdEmpleado,
                            mPrestamo.Observaciones
                        };

                        // Insertar la cabecera del prestamo
                        int idPrestamoGenerado = conexion.ExecuteScalar<int>(
                            "sp_InsertarPrestamo",
                            parametros,
                            commandType: CommandType.StoredProcedure,
                            transaction: transaccion // Indica que la operación forma parte de la transacción
                            );

                        // Recorre la lista de detallers para insertar uno por unno

                        foreach (var detalle in mPrestamo.Detalles)
                        {
                            // Usamos el id que nos retorna el primer procedimiento almacenado
                            var parametrosDetalle = new
                            {
                                IdPrestamo = idPrestamoGenerado,
                                idEjemplar = detalle.IdEjemplar
                            };

                            conexion.Execute(
                                "sp_InsertarDetallePrestamo",
                                parametrosDetalle,
                                commandType: CommandType.StoredProcedure,
                                transaction: transaccion // Indica que la operación forma parte de la transacción
                                );
                        }

                        // Si ambas operaciones fueron exitosas se manda un commit
                        transaccion.Commit();
                        return true;
                    }
                    catch
                    {
                        // Si hubo un error en alguna de las operaciones
                        // Se hace un rollback para deshacer cualquier cambio
                        transaccion.Rollback();
                        return false;
                    }
                }
            }
        }

        // Metodo para obtener los prestamos de la cabecera
        public IEnumerable<MPrestamo> ObtenerPrestamos()
        {
            using (IDbConnection db = new SqlConnection(_conn))
            {
                return db.Query<MPrestamo>(
                    "sp_ObtenerPrestamos",
                    commandType: CommandType.StoredProcedure
                    );
            }
        }
        // Buscar los prestamos por fechas
        public IEnumerable<MPrestamo> BuscarPrestamosFechas(DateTime fechaI, DateTime fechaF)
        {
            var parametros = new
            {
                FechaInicio = fechaI,
                FechaFin = fechaF
            };
            using (IDbConnection db = new SqlConnection(_conn))
            {

                return db.Query<MPrestamo>(
                    "sp_BuscarPrestamosPorFecha",
                    parametros,
                    commandType: CommandType.StoredProcedure
                    );
            }
        }

        //Obtener el detalle de los prestamos
        // Como parametro se usara el id del prestamo de la cabecera
        public IEnumerable<MDetallePrestamo> ObtenerDetallePrestamo(int id)
        {
            var parametros = new
            {
                IdPrestamo = id
            };
            using (IDbConnection db = new SqlConnection(_conn))
            {
                return db.Query<MDetallePrestamo>(
                    "sp_ObtenerDetallePorPrestamo",
                    parametros,
                    commandType: CommandType.StoredProcedure
                    );
            }
        }

        // Método para actualizar la cabecera del prestamo
        public bool ActualizarPrestamo(MPrestamo mPrestamo)
        {
            var parametros = new
            {
                Id = mPrestamo.Id,
                FechaLimite = mPrestamo.FechaLimite,
                Observaciones = mPrestamo.Observaciones
            };
            using (IDbConnection db = new SqlConnection(_conn))
            {
                db.Execute(
                    "sp_ActualizarPrestamo",
                    parametros,
                    commandType: CommandType.StoredProcedure
                    );
                return true;
            }
        }

        public bool EliminarPrestamo(int id) 
        {
            var parametros = new 
            {
                Id = id
            };

            using (IDbConnection db = new SqlConnection(_conn)) 
            {
                db.Execute(
                    "sp_EliminarPrestamo",
                    parametros,
                    commandType: CommandType.StoredProcedure
                    );
                return true;
            }
        }

        // Método que actualiza a detalle los prestamos en sus estado y fecha
        public bool ActualizarDetallePrestamo(MDetallePrestamo detallePrestamo) 
        {
            var parametros = new 
            {
                IdDetalle = detallePrestamo.IdDetalle,
                Estado = detallePrestamo.Estado,
                FechaDevolucion = detallePrestamo.FechaDevolucion
            };
            using (IDbConnection db =new SqlConnection(_conn)) 
            {
                db.Execute(
                    "sp_RegistrarDevolucionEjemplar",
                    parametros,
                    commandType: CommandType.StoredProcedure
                    );
                return true;
            }
        }
    }
}
