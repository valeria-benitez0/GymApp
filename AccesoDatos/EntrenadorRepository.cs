using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using GymApp.Entidades;
using System.Windows.Forms;
using System.Configuration;
using System.Data;

namespace GymApp.AccesoDatos
{
    public class EntrenadorRepository : IEntrenadorRepository
    {
        private SqlConnection connection;

        public EntrenadorRepository()
        {
            connection = GymConnection.GetInstance().Connection;
        }

        public void Crear(Entrenador entrenador)
        {
            try
            {
                connection.Open();
                // Usamos una sentencia SQL directamente para crear al entrenador.
                string query = "INSERT INTO Entrenadores (Nombre, Especialidad, Disponibilidad) " +
                               "VALUES (@Nombre, @Especialidad, @Disponibilidad); SELECT SCOPE_IDENTITY();";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Nombre", entrenador.Nombre);
                    cmd.Parameters.AddWithValue("@Especialidad", entrenador.Especialidad);
                    cmd.Parameters.AddWithValue("@Disponibilidad", entrenador.Disponibilidad);
                    object result = cmd.ExecuteScalar();
                    entrenador.EntrenadorID = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear el entrenador.", ex);
            }
            finally
            {
                connection.Close();
            }
        }

        public Entrenador ObtenerPorId(int id)
        {
            Entrenador entrenador = null;
            try
            {
                connection.Open();
                string query = "SELECT * FROM Entrenadores WHERE EntrenadorID = @EntrenadorID;";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@EntrenadorID", id);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            entrenador = new Entrenador
                            {
                                EntrenadorID = Convert.ToInt32(reader["EntrenadorID"]),
                                Nombre = reader["Nombre"].ToString(),
                                Especialidad = reader["Especialidad"].ToString(),
                                Disponibilidad = reader["Disponibilidad"].ToString()
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el entrenador.", ex);
            }
            finally
            {
                connection.Close();
            }
            return entrenador;
        }

        public IEnumerable<Entrenador> ObtenerTodos()
        {
            List<Entrenador> entrenadores = new List<Entrenador>();
            try
            {
                connection.Open();
                string query = "SELECT * FROM Entrenadores;";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Entrenador entrenador = new Entrenador
                            {
                                EntrenadorID = Convert.ToInt32(reader["EntrenadorID"]),
                                Nombre = reader["Nombre"].ToString(),
                                Especialidad = reader["Especialidad"].ToString(),
                                Disponibilidad = reader["Disponibilidad"].ToString()
                            };
                            entrenadores.Add(entrenador);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los entrenadores.", ex);
            }
            finally
            {
                connection.Close();
            }
            return entrenadores;
        }

        public void Actualizar(Entrenador entrenador)
        {
            try
            {
                connection.Open();
                // Utilizamos el procedimiento almacenado SP_ActualizarEntrenador
                string query = "EXEC SP_ActualizarEntrenador @EntrenadorID, @Nombre, @Especialidad, @Disponibilidad;";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@EntrenadorID", entrenador.EntrenadorID);
                    cmd.Parameters.AddWithValue("@Nombre", entrenador.Nombre);
                    cmd.Parameters.AddWithValue("@Especialidad", entrenador.Especialidad);
                    cmd.Parameters.AddWithValue("@Disponibilidad", entrenador.Disponibilidad);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar el entrenador.", ex);
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
                // Utilizamos el procedimiento almacenado SP_EliminarEntrenador
                string query = "EXEC SP_EliminarEntrenador @EntrenadorID;";
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["GymDB"].ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("SP_EliminarEntrenador", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@EntrenadorID", id);
                        cmd.ExecuteNonQuery();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error real:\n" + (ex.InnerException?.Message ?? ex.Message),
                    "ERROR DETALLADO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
