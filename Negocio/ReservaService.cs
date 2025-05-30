using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

        public int RegistrarReserva(Reserva reserva)
        {
            // Validar que el miembro exista y esté activo
            Miembro miembro = miembroRepo.ObtenerPorId(reserva.UsuarioID);
            if (miembro == null)
                throw new Exception("El miembro no existe o se encuentra inactivo.");

            if (miembro.FechaVencimientoMembresia < DateTime.Now)
                throw new Exception("La membresía ha expirado.");

            // Validar que la clase exista
            Clase clase = claseRepo.ObtenerPorId(reserva.ClaseID);
            if (clase == null)
                throw new Exception("La clase no existe.");

            // Validar que existan cupos disponibles
            int reservasActivas = reservaRepo.ContarReservasActivasPorClase(reserva.ClaseID);
            if (reservasActivas >= clase.CapacidadMaxima)
                throw new Exception("No hay cupos disponibles para esta clase.");

            int nuevoId = reservaRepo.RegistrarReserva(reserva);
            return nuevoId;
        }

        public IEnumerable<Reserva> ObtenerReservasPorMiembro(int usuarioId)
        {
            return reservaRepo.ObtenerReservasPorMiembro(usuarioId);
        }

        public void CancelarReserva(int reservaId)
        {
            Reserva reserva = reservaRepo.ObtenerPorId(reservaId);
            if (reserva == null || reserva.Estado != "Activa")
                throw new Exception("La reserva no existe o ya se encuentra cancelada.");

            double diferenciaHoras = (reserva.FechaReserva - DateTime.Now).TotalHours;
            if (diferenciaHoras < 24)
                throw new Exception("Sólo puedes cancelar una reserva con más de 24 horas de anticipación.");

            reservaRepo.CancelarReserva(reservaId);
        }
    }
}
