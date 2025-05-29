using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using GymApp.AccesoDatos;
using GymApp.Entidades;

namespace GymApp.Negocio
{
    public class EntrenadorService
    {
        private readonly IEntrenadorRepository entrenadorRepository;

        public EntrenadorService(IEntrenadorRepository entrenadorRepository)
        {
            this.entrenadorRepository = entrenadorRepository;
        }

        /// <summary>
        /// Obtiene todos los entrenadores.
        /// </summary>
        public IEnumerable<Entrenador> ObtenerTodosLosEntrenadores()
        {
            return entrenadorRepository.ObtenerTodos();
        }

        /// <summary>
        /// Obtiene un entrenador por ID.
        /// </summary>
        public Entrenador ObtenerPorId(int id)
        {
            var entrenador = entrenadorRepository.ObtenerPorId(id);
            if (entrenador == null)
                throw new Exception("El entrenador no existe.");
            return entrenador;
        }

        /// <summary>
        /// Registra un nuevo entrenador con validaciones.
        /// </summary>
        public void RegistrarEntrenador(Entrenador entrenador)
        {
            if (string.IsNullOrWhiteSpace(entrenador.Nombre))
                throw new Exception("El nombre del entrenador es obligatorio.");
            if (string.IsNullOrWhiteSpace(entrenador.Especialidad))
                throw new Exception("La especialidad es obligatoria.");
            if (string.IsNullOrWhiteSpace(entrenador.Disponibilidad))
                throw new Exception("La disponibilidad es obligatoria.");

            entrenadorRepository.Crear(entrenador);
        }

        /// <summary>
        /// Actualiza la información de un entrenador, con validaciones.
        /// </summary>
        public void ActualizarEntrenador(Entrenador entrenador)
        {
            if (entrenador == null)
                throw new Exception("El entrenador no existe.");
            if (string.IsNullOrWhiteSpace(entrenador.Nombre))
                throw new Exception("El nombre del entrenador es obligatorio.");
            if (string.IsNullOrWhiteSpace(entrenador.Especialidad))
                throw new Exception("La especialidad es obligatoria.");
            if (string.IsNullOrWhiteSpace(entrenador.Disponibilidad))
                throw new Exception("La disponibilidad es obligatoria.");

            entrenadorRepository.Actualizar(entrenador);
        }

        /// <summary>
        /// Elimina un entrenador, comprobando que no tenga clases asignadas.
        /// </summary>
        public void EliminarEntrenador(int id)
        {
            var entrenador = entrenadorRepository.ObtenerPorId(id);
            if (entrenador == null)
                throw new Exception("El entrenador no existe.");

            if (EntrenadorTieneClases(id))
                throw new Exception("No se puede eliminar el entrenador, ya que tiene clases asignadas.");

            entrenadorRepository.Eliminar(id);
        }

        /// <summary>
        /// Verifica si el entrenador tiene clases asignadas.
        /// </summary>
        private bool EntrenadorTieneClases(int entrenadorID)
        {
            bool tieneClases = false;
            using (SqlConnection connection = GymConnection.GetInstance().Connection)
            {
                try
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM Clases WHERE EntrenadorID = @EntrenadorID";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@EntrenadorID", entrenadorID);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        tieneClases = (count > 0);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al verificar las clases asignadas.", ex);
                }
                finally
                {
                    connection.Close();
                }
            }
            return tieneClases;
        }
    }
}
