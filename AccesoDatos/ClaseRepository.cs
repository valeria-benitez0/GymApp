using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymApp.Entidades;
using System.Data.SqlClient;

namespace GymApp.AccesoDatos
{
    public class ClaseRepository : IClaseRepository
    {
        private SqlConnection connection;

        public ClaseRepository()
        {
            connection = GymConnection.GetInstance().Connection;
        }

        public void Crear(Clase clase)
        {
            try
            {
                connection.Open();
                string query = "INSERT INTO Clases (NombreClase, Horario, Duracion, CapacidadMaxima, EntrenadorID) " +
                               "VALUES (@NombreClase, @Horario, @Duracion, @CapacidadMaxima, @EntrenadorID); " +
                               "SELECT SCOPE_IDENTITY();";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@NombreClase", clase.NombreClase);
                    cmd.Parameters.AddWithValue("@Horario", clase.Horario);
                    cmd.Parameters.AddWithValue("@Duracion", clase.Duracion);
                    cmd.Parameters.AddWithValue("@CapacidadMaxima", clase.CapacidadMaxima);
                    cmd.Parameters.AddWithValue("@EntrenadorID", clase.EntrenadorID);
                    object result = cmd.ExecuteScalar();
                    clase.ClaseID = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear la clase.", ex);
            }
            finally
            {
                connection.Close();
            }
        }

        public Clase ObtenerPorId(int id)
        {
            Clase clase = null;
            try
            {
                connection.Open();
                string query = "SELECT * FROM Clases WHERE ClaseID = @ClaseID;";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ClaseID", id);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            clase = new Clase
                            {
                                ClaseID = Convert.ToInt32(reader["ClaseID"]),
                                NombreClase = reader["NombreClase"].ToString(),
                                Horario = Convert.ToDateTime(reader["Horario"]),
                                Duracion = Convert.ToInt32(reader["Duracion"]),
                                CapacidadMaxima = Convert.ToInt32(reader["CapacidadMaxima"]),
                                EntrenadorID = Convert.ToInt32(reader["EntrenadorID"])
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la clase.", ex);
            }
            finally
            {
                connection.Close();
            }
            return clase;
        }

        public IEnumerable<Clase> ObtenerTodos()
        {
            List<Clase> clases = new List<Clase>();
            try
            {
                connection.Open();
                string query = "SELECT * FROM Clases;";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Clase clase = new Clase
                            {
                                ClaseID = Convert.ToInt32(reader["ClaseID"]),
                                NombreClase = reader["NombreClase"].ToString(),
                                Horario = Convert.ToDateTime(reader["Horario"]),
                                Duracion = Convert.ToInt32(reader["Duracion"]),
                                CapacidadMaxima = Convert.ToInt32(reader["CapacidadMaxima"]),
                                EntrenadorID = Convert.ToInt32(reader["EntrenadorID"])
                            };
                            clases.Add(clase);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener las clases.", ex);
            }
            finally
            {
                connection.Close();
            }
            return clases;
        }

        public void Actualizar(Clase clase)
        {
            try
            {
                connection.Open();
                string query = "UPDATE Clases SET NombreClase=@NombreClase, Horario=@Horario, Duracion=@Duracion, " +
                               "CapacidadMaxima=@CapacidadMaxima, EntrenadorID=@EntrenadorID " +
                               "WHERE ClaseID=@ClaseID;";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@NombreClase", clase.NombreClase);
                    cmd.Parameters.AddWithValue("@Horario", clase.Horario);
                    cmd.Parameters.AddWithValue("@Duracion", clase.Duracion);
                    cmd.Parameters.AddWithValue("@CapacidadMaxima", clase.CapacidadMaxima);
                    cmd.Parameters.AddWithValue("@EntrenadorID", clase.EntrenadorID);
                    cmd.Parameters.AddWithValue("@ClaseID", clase.ClaseID);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar la clase.", ex);
            }
            finally
            {
                connection.Close();
            }
        }

        public void Eliminar(int id)
        {
            try
            {
                connection.Open();
                string query = "DELETE FROM Clases WHERE ClaseID = @ClaseID;";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ClaseID", id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar la clase.", ex);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
