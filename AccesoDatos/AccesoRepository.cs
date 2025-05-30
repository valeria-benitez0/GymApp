using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using GymApp.Entidades;

namespace GymApp.AccesoDatos
{
    public class AccesoRepository : IAccesoRepository
    {
        private SqlConnection connection;

        public AccesoRepository()
        {
            // Se utiliza la conexión del Singleton GymConnection (asegúrate de que esté correctamente configurada en app.config)
            connection = GymConnection.GetInstance().Connection;
        }

        public int InsertarAcceso(Acceso acceso)
        {
            int nuevoId = 0;
            try
            {
                connection.Open();
                string query = "EXEC SP_InsertarAcceso @UsuarioID, @ClaseID, @EstadoAcceso";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@UsuarioID", acceso.UsuarioID);
                    cmd.Parameters.AddWithValue("@ClaseID", acceso.ClaseID);
                    cmd.Parameters.AddWithValue("@EstadoAcceso", acceso.EstadoAcceso);
                    object result = cmd.ExecuteScalar();
                    nuevoId = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar acceso: " + ex.Message, ex);
            }
            finally
            {
                connection.Close();
            }
            return nuevoId;
        }

        public IEnumerable<ReporteAsistenciaDTO> GenerarReporteAsistencia(DateTime fechaInicio, DateTime fechaFin)
        {
            var reporte = new List<ReporteAsistenciaDTO>();
            try
            {
                connection.Open();
                string query = "EXEC SP_GenerarReporteAsistencia @FechaInicio, @FechaFin";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                    cmd.Parameters.AddWithValue("@FechaFin", fechaFin);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            reporte.Add(new ReporteAsistenciaDTO
                            {
                                ClaseID = Convert.ToInt32(reader["ClaseID"]),
                                NombreClase = reader["NombreClase"].ToString(),
                                UsuarioID = Convert.ToInt32(reader["UsuarioID"]),
                                NombreMiembro = reader["NombreMiembro"].ToString(),
                                TotalAccesos = Convert.ToInt32(reader["TotalAccesos"])
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error generando reporte de asistencia: " + ex.Message, ex);
            }
            finally
            {
                connection.Close();
            }
            return reporte;
        }

        public IEnumerable<NotificacionReservaDTO> ObtenerNotificacionesReservasPendientes()
        {
            var notificaciones = new List<NotificacionReservaDTO>();
            try
            {
                connection.Open();
                string query = "EXEC SP_NotificarReservasPendientes";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            notificaciones.Add(new NotificacionReservaDTO
                            {
                                ReservaID = Convert.ToInt32(reader["ReservaID"]),
                                UsuarioID = Convert.ToInt32(reader["UsuarioID"]),
                                Nombre = reader["Nombre"].ToString(),
                                Email = reader["Email"].ToString(),
                                ClaseID = Convert.ToInt32(reader["ClaseID"]),
                                NombreClase = reader["NombreClase"].ToString(),
                                FechaReserva = Convert.ToDateTime(reader["FechaReserva"])
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener notificaciones de reservas pendientes: " + ex.Message, ex);
            }
            finally
            {
                connection.Close();
            }
            return notificaciones;
        }
    }
}
