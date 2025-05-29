using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymApp.AccesoDatos;
using GymApp.Entidades;

namespace GymApp.Negocio
{
    public class ReservaService
    {
        private readonly IReservaRepository reservaRepo;
        private readonly IMiembroRepository miembroRepo;
        private readonly IClaseRepository claseRepo;

        public ReservaService(IReservaRepository reservaRepo,
                              IMiembroRepository miembroRepo,
                              IClaseRepository claseRepo)
        {
            this.reservaRepo = reservaRepo;
            this.miembroRepo = miembroRepo;
            this.claseRepo = claseRepo;
        }

        /// <summary>
        /// Registra una nueva reserva, validando primero las reglas de negocio.
        /// </summary>
        /// <param name="reserva">Objeto Reserva con la información de la reserva.</param>
        /// <returns>ID de la nueva reserva registrada.</returns>
        public int RegistrarReserva(Reserva reserva)
        {
            // 1. Validar que el miembro exista y esté activo.
            Miembro miembro = miembroRepo.ObtenerPorId(reserva.UsuarioID);
            if (miembro == null)
                throw new Exception("El miembro no existe o se encuentra inactivo.");

            // 2. Validar la vigencia de la membresía.
            if (miembro.FechaVencimientoMembresia < DateTime.Now)
                throw new Exception("La membresía ha expirado.");

            // 3. Obtener información de la clase y validar que exista.
            Clase clase = claseRepo.ObtenerPorId(reserva.ClaseID);
            if (clase == null)
                throw new Exception("La clase no existe.");

            // 4. Validar que existan cupos disponibles:
            // Se asume que el repositorio de reservas tiene un método para contar reservas activas.
            int reservasActivas = reservaRepo.ContarReservasActivasPorClase(reserva.ClaseID);
            if (reservasActivas >= clase.CapacidadMaxima)
                throw new Exception("No hay cupos disponibles para esta clase.");

            // 5. Si todas las verificaciones pasan, registra la reserva.
            int nuevoId = reservaRepo.RegistrarReserva(reserva);
            return nuevoId;
        }

        /// <summary>
        /// Cancela una reserva, validando que se realice con más de 24 horas de antelación.
        /// </summary>
        /// <param name="reservaId">ID de la reserva a cancelar.</param>
        public void CancelarReserva(int reservaId)
        {
            // Obtener la reserva
            Reserva reserva = reservaRepo.ObtenerPorId(reservaId);
            if (reserva == null || reserva.Estado != "Activa")
                throw new Exception("La reserva no existe o ya se encuentra cancelada.");

            // Validar la regla de cancelación (más de 24 horas de antelación)
            double diferenciaHoras = (reserva.FechaReserva - DateTime.Now).TotalHours;
            if (diferenciaHoras < 24)
                throw new Exception("Sólo puedes cancelar una reserva con más de 24 horas de anticipación.");

            // Cancelar la reserva en la base de datos
            reservaRepo.CancelarReserva(reservaId);
        }

        // Se pueden agregar otros métodos, como consultar reservas de un miembro, etc.
    }
}
