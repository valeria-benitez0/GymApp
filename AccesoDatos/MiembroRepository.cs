using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymApp.Entidades;
using System.Data.SqlClient;

namespace GymApp.AccesoDatos
{
    public class MiembroRepository : IMiembroRepository
    {
        private SqlConnection connection;

        public MiembroRepository()
        {
            // Se obtiene la conexión única
            connection = GymConnection.GetInstance().Connection;
        }

        public void RegistrarMiembro(Miembro miembro)
        {
            try
            {
                connection.Open();
                string query = "INSERT INTO Miembros (Nombre, Email, Telefono, TipoMembresia, FechaVencimientoMembresia, Rol, Activo, Password) " +
                               "VALUES (@Nombre, @Email, @Telefono, @TipoMembresia, @FechaVencimientoMembresia, @Rol, 1, @Password); " +
                               "SELECT SCOPE_IDENTITY();";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Nombre", miembro.Nombre);
                    cmd.Parameters.AddWithValue("@Email", miembro.Email);
                    cmd.Parameters.AddWithValue("@Telefono", miembro.Telefono);
                    cmd.Parameters.AddWithValue("@TipoMembresia", miembro.TipoMembresia);
                    cmd.Parameters.AddWithValue("@FechaVencimientoMembresia", miembro.FechaVencimientoMembresia);
                    cmd.Parameters.AddWithValue("@Rol", miembro.Rol);
                    cmd.Parameters.AddWithValue("@Password", miembro.Password);

                    // Se asigna el ID generado al objeto miembro
                    object result = cmd.ExecuteScalar();
                    miembro.UsuarioID = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear el miembro.", ex);
            }
            finally
            {
                connection.Close();
            }
        }

        public Miembro ObtenerPorId(int id)
        {
            Miembro miembro = null;
            try
            {
                connection.Open();
                string query = "SELECT * FROM Miembros WHERE UsuarioID = @UsuarioID AND Activo = 1;";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@UsuarioID", id);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            miembro = new Miembro
                            {
                                UsuarioID = Convert.ToInt32(reader["UsuarioID"]),
                                Nombre = reader["Nombre"].ToString(),
                                Email = reader["Email"].ToString(),
                                Telefono = reader["Telefono"].ToString(),
                                TipoMembresia = reader["TipoMembresia"].ToString(),
                                FechaVencimientoMembresia = Convert.ToDateTime(reader["FechaVencimientoMembresia"]),
                                Rol = reader["Rol"].ToString(),
                                Activo = Convert.ToBoolean(reader["Activo"]),
                                Password = reader["Password"].ToString()
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el miembro.", ex);
            }
            finally
            {
                connection.Close();
            }
            return miembro;
        }

        public IEnumerable<Miembro> ObtenerTodos()
        {
            List<Miembro> miembros = new List<Miembro>();
            try
            {
                connection.Open();
                string query = "SELECT * FROM Miembros WHERE Activo = 1;";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Miembro miembro = new Miembro
                            {
                                UsuarioID = Convert.ToInt32(reader["UsuarioID"]),
                                Nombre = reader["Nombre"].ToString(),
                                Email = reader["Email"].ToString(),
                                Telefono = reader["Telefono"].ToString(),
                                TipoMembresia = reader["TipoMembresia"].ToString(),
                                FechaVencimientoMembresia = Convert.ToDateTime(reader["FechaVencimientoMembresia"]),
                                Rol = reader["Rol"].ToString(),
                                Activo = Convert.ToBoolean(reader["Activo"]),
                                Password = reader["Password"].ToString()
                            };
                            miembros.Add(miembro);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los miembros.", ex);
            }
            finally
            {
                connection.Close();
            }
            return miembros;
        }

        public void Actualizar(Miembro miembro)
        {
            try
            {
                connection.Open();
                string query = "UPDATE Miembros SET Nombre=@Nombre, Email=@Email, Telefono=@Telefono, " +
                               "TipoMembresia=@TipoMembresia, FechaVencimientoMembresia=@FechaVencimientoMembresia, " +
                               "Rol=@Rol, Password=@Password " +
                               "WHERE UsuarioID=@UsuarioID;";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Nombre", miembro.Nombre);
                    cmd.Parameters.AddWithValue("@Email", miembro.Email);
                    cmd.Parameters.AddWithValue("@Telefono", miembro.Telefono);
                    cmd.Parameters.AddWithValue("@TipoMembresia", miembro.TipoMembresia);
                    cmd.Parameters.AddWithValue("@FechaVencimientoMembresia", miembro.FechaVencimientoMembresia);
                    cmd.Parameters.AddWithValue("@Rol", miembro.Rol);
                    cmd.Parameters.AddWithValue("@Password", miembro.Password);
                    cmd.Parameters.AddWithValue("@UsuarioID", miembro.UsuarioID);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar el miembro.", ex);
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
                // Eliminación lógica: se marca el miembro como inactivo.
                string query = "UPDATE Miembros SET Activo = 0 WHERE UsuarioID = @UsuarioID;";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@UsuarioID", id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el miembro.", ex);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}

