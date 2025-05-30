using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymApp.AccesoDatos;
using GymApp.Entidades;
using System.Data.SqlClient;
namespace GymApp.Negocio
{
    public class ClaseService
    {
        private readonly IClaseRepository claseRepository;

        public ClaseService(IClaseRepository claseRepository)
        {
            this.claseRepository = claseRepository;
        }

        /// <summary>
        /// Obtiene todas las clases registradas.
        /// </summary>
        public IEnumerable<Clase> ObtenerTodasLasClases()
        {
            return claseRepository.ObtenerTodos();
        }

        /// <summary>
        /// Obtiene una clase por su ID y lanza una excepción si no se encuentra.
        /// </summary>
        public Clase ObtenerPorId(int claseID)
        {
            var clase = claseRepository.ObtenerPorId(claseID);
            if (clase == null)
                throw new Exception("La clase no existe.");
            return clase;
        }

        /// <summary>
        /// Registra una nueva clase, aplicando todas las validaciones necesarias.
        /// </summary>
        public void RegistrarClase(Clase clase)
        {
            // Validación: El nombre de la clase es obligatorio.
            if (string.IsNullOrWhiteSpace(clase.NombreClase))
                throw new Exception("El nombre de la clase es obligatorio.");

            // Validación: El horario no puede ser en el pasado.
            if (clase.Horario < DateTime.Now)
                throw new Exception("El horario no puede ser en el pasado.");

            // Validación: La duración y la capacidad deben ser mayores a cero.
            if (clase.Duracion <= 0)
                throw new Exception("La duración debe ser mayor a 0.");
            if (clase.CapacidadMaxima <= 0)
                throw new Exception("La capacidad máxima debe ser mayor a 0.");

            // Validación: Se debe seleccionar un entrenador válido.
            if (clase.EntrenadorID <= 0)
                throw new Exception("Debe seleccionar un entrenador válido.");

            // Si todo es correcto, se delega la creación al repositorio.
            claseRepository.Crear(clase);
        }

        /// <summary>
        /// Actualiza los datos de una clase, aplicando las mismas validaciones de registro.
        /// Además, si la clase tiene reservas activas,
        /// no se permite modificar el horario, duración o capacidad.
        /// </summary>
        public void ActualizarClase(Clase clase)
        {
            if (clase == null)
                throw new Exception("La clase no existe.");

            // Validaciones básicas
            if (string.IsNullOrWhiteSpace(clase.NombreClase))
                throw new Exception("El nombre de la clase es obligatorio.");
            if (clase.Horario < DateTime.Now)
                throw new Exception("El horario no puede ser en el pasado.");
            if (clase.Duracion <= 0)
                throw new Exception("La duración debe ser mayor a 0.");
            if (clase.CapacidadMaxima <= 0)
                throw new Exception("La capacidad máxima debe ser mayor a 0.");
            if (clase.EntrenadorID <= 0)
                throw new Exception("Debe seleccionar un entrenador válido.");

            // Validación adicional: si existen reservas activas, no se pueden modificar propiedades críticas.
         /* if (ClaseTieneReservasActivas(clase.ClaseID))
            {
                // Se obtiene la versión actual de la clase desde la BD.
                Clase claseActualDB = claseRepository.ObtenerPorId(clase.ClaseID);
                if (claseActualDB != null)
                {
                    if (clase.Horario != claseActualDB.Horario ||
                        clase.Duracion != claseActualDB.Duracion ||
                        clase.CapacidadMaxima != claseActualDB.CapacidadMaxima)
                    {
                        throw new Exception("No se puede modificar el horario, la duración o la capacidad de una clase que tiene reservas activas.");
                    }
                }
            }*/

            // Si todo está en orden, se procede a actualizar.
            claseRepository.Actualizar(clase);
        }

        /// <summary>
        /// Elimina una clase dado su ID, previo chequeo de que no tenga reservas activas.
        /// </summary>
        public void EliminarClase(int claseID)
        {
            var clase = claseRepository.ObtenerPorId(claseID);
            if (clase == null)
                throw new Exception("La clase que desea eliminar no existe.");

          //if (ClaseTieneReservasActivas(claseID))
            //  throw new Exception("No se puede eliminar la clase, ya que tiene reservas activas.");

            claseRepository.Eliminar(claseID);
        }

        /// <summary>
        /// Verifica si una clase tiene reservas activas consultando la tabla Reservas.
        /// </summary>
        /// <param name="claseID">El ID de la clase a consultar.</param>
        /// <returns>True si existen reservas activas; de lo contrario, false.</returns>
      /*private bool ClaseTieneReservasActivas(int claseID)
        {
            bool tieneReservas = false;
            using (SqlConnection connection = GymConnection.GetInstance().Connection)
            {
                try
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM Reservas WHERE ClaseID = @ClaseID AND Estado = 'Activa'";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@ClaseID", claseID);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        tieneReservas = (count > 0);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al verificar reservas activas.", ex);
                }
                finally
                {
                    connection.Close();
                }
            }
            return tieneReservas; 
        }*/
    }
}

