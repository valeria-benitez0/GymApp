using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace GymApp.AccesoDatos
{
    public class UnitOfWork : IDisposable
    {
        private SqlConnection connection;
        private SqlTransaction transaction;

        // Repositorios que se usarán en conjunto para operaciones transaccionales.
        public IMiembroRepository Miembros { get; private set; }
        public IClaseRepository Clases { get; private set; }
        // Agregar repositorios para Entrenadores, Reservas y Acceso si es necesario

        public UnitOfWork()
        {
            connection = GymConnection.GetInstance().Connection;
            connection.Open();
            transaction = connection.BeginTransaction();

            // Inicializar repositorios pasando la conexión y la transacción (si se requiere)
            Miembros = new MiembroRepository(); // Se puede extender para aceptar transacción si el diseño lo requiere
            Clases = new ClaseRepository();
            // Inicializar otros repositorios de forma similar
        }
        public void OperacionComplejaReserva(Reserva reserva)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                try
                {
                    int nuevaReservaId = uow.Reservas.RegistrarReserva(reserva);
                    uow.Commit();
                }
                catch
                {
                    uow.Rollback();
                    throw;
                }
            }
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
