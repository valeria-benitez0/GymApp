using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using GymApp.Entidades;

namespace GymApp.AccesoDatos
{
    public class UnitOfWork : IDisposable
    {
        private SqlConnection connection;
        private SqlTransaction transaction;

        public IMiembroRepository Miembros { get; private set; }
        public IClaseRepository Clases { get; private set; }
        public IReservaRepository Reservas { get; private set; }
        // Puedes agregar IEntrenadorRepository, IAccesoRepository, etc.

        public UnitOfWork()
        {
            connection = GymConnection.GetInstance().Connection;
            connection.Open();
            transaction = connection.BeginTransaction();

            // Instanciar repositorios. Si tu diseño soporta pasar la conexión o transacción,
            // adáptalo para que estos repositorios operen en la misma transacción.
            Miembros = new MiembroRepository();
            Clases = new ClaseRepository();
            Reservas = new ReservaRepository();
        }

        public void Commit()
        {
            try
            {
                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw new Exception("Error al aplicar la transacción.", ex);
            }
            finally
            {
                connection.Close();
            }
        }

        public void Rollback()
        {
            try
            {
                transaction.Rollback();
            }
            finally
            {
                connection.Close();
            }
        }

        public void Dispose()
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();
        }
    }
}
