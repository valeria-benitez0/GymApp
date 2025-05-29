using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymApp.Entidades;
using System.Data.SqlClient;

namespace GymApp.AccesoDatos
{
    public class ReservaRepository : IReservaRepository
    {
        private SqlConnection connection;

        public ReservaRepository()
        {
            connection = GymConnection.GetInstance().Connection;
        }

        public int RegistrarReserva(Reserva reserva)
        {
            int newId = 0;
            try
            {
                connection.Open();
                string query = "EXEC SP_RegistrarReserva @UsuarioID, @ClaseID, @FechaReserva";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@UsuarioID", reserva.UsuarioID);
                    cmd.Parameters.AddWithValue("@ClaseID", reserva.ClaseID);
                    cmd.Parameters.AddWithValue("@FechaReserva", reserva.FechaReserva);
                    object result = cmd.ExecuteScalar();
                    newId = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error registrando la reserva", ex);
            }
            finally
            {
                connection.Close();
            }
            return newId;
        }

        public void CancelarReserva(int reservaId)
        {
            try
            {
                connection.Open();
                string query = "EXEC SP_CancelarReserva @ReservaID";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ReservaID", reservaId);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error cancelando la reserva", ex);
            }
            finally
            {
                connection.Close();
            }
        }

        public Reserva ObtenerPorId(int reservaId)
        {
            Reserva reserva = null;
            try
            {
                connection.Open();
                string query = "SELECT * FROM Reservas WHERE ReservaID = @ReservaID";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ReservaID", reservaId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            reserva = new Reserva
                            {
                                ReservaID = Convert.ToInt32(reader["ReservaID"]),
                                UsuarioID = Convert.ToInt32(reader["UsuarioID"]),
                                ClaseID = Convert.ToInt32(reader["ClaseID"]),
                                FechaReserva = Convert.ToDateTime(reader["FechaReserva"]),
                                Estado = reader["Estado"].ToString(),
                                FechaCancelacion = reader["FechaCancelacion"] != DBNull.Value ? Convert.ToDateTime(reader["FechaCancelacion"]) : (DateTime?)null
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error obteniendo la reserva", ex);
            }
            finally
            {
                connection.Close();
            }
            return reserva;
        }

        public int ContarReservasActivasPorClase(int claseId)
        {
            int count = 0;
            try
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM Reservas WHERE ClaseID = @ClaseID AND Estado = 'Activa'";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ClaseID", claseId);
                    count = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error contando reservas activas", ex);
            }
            finally
            {
                connection.Close();
            }
            return count;
        }

        public IEnumerable<Reserva> ObtenerReservasPorMiembro(int usuarioId)
        {
            List<Reserva> reservas = new List<Reserva>();
            try
            {
                connection.Open();
                string query = "SELECT * FROM Reservas WHERE UsuarioID = @UsuarioID";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@UsuarioID", usuarioId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Reserva reserva = new Reserva
                            {
                                ReservaID = Convert.ToInt32(reader["ReservaID"]),
                                UsuarioID = Convert.ToInt32(reader["UsuarioID"]),
                                ClaseID = Convert.ToInt32(reader["ClaseID"]),
                                FechaReserva = Convert.ToDateTime(reader["FechaReserva"]),
                                Estado = reader["Estado"].ToString(),
                                FechaCancelacion = reader["FechaCancelacion"] != DBNull.Value ? Convert.ToDateTime(reader["FechaCancelacion"]) : (DateTime?)null
                            };
                            reservas.Add(reserva);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error obteniendo reservas por miembro", ex);
            }
            finally
            {
                connection.Close();
            }
            return reservas;
        }
    }
}
