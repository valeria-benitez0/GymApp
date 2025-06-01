using System;
using System.Collections.Generic;
using System.Linq;
using GymApp.AccesoDatos;
using GymApp.Entidades;
using GymApp.Factories;

namespace GymApp.Negocio
{
    public class AccesoService
    {
        private readonly IAccesoRepository accesoRepo;

        public AccesoService(IAccesoRepository accesoRepo)
        {
            this.accesoRepo = accesoRepo;
        }

        public int RegistrarAcceso(Acceso acceso)
        {
            if (acceso == null)
                throw new ArgumentNullException(nameof(acceso));

            return accesoRepo.InsertarAcceso(acceso);
        }

        public IEnumerable<ReporteAsistenciaDTO> ObtenerReporteAsistencia(DateTime fechaInicio, DateTime fechaFin)
        {
            return ReporteFactory.CrearReporteAsistencia(fechaInicio, fechaFin, accesoRepo);
        }

        public IEnumerable<NotificacionReservaDTO> ObtenerNotificacionesPendientes()
        {
            return NotificacionFactory.CrearNotificaciones(accesoRepo);
        }

        public IEnumerable<Acceso> ObtenerAccesosPorUsuario(int usuarioId)
        {
            return accesoRepo.ObtenerAccesosPorUsuario(usuarioId);
        }

        public IEnumerable<Acceso> ObtenerAccesosPorClase(int claseId)
        {
            return accesoRepo.ObtenerAccesosPorClase(claseId);
        }

        public IEnumerable<Acceso> ObtenerAccesosPorClaseYFecha(int claseId, DateTime desde, DateTime hasta)
        {
            return accesoRepo.ObtenerAccesosPorClaseYFecha(claseId, desde, hasta);
        }

        public IEnumerable<Acceso> ObtenerTodos()
        {
            return accesoRepo.ObtenerTodos();
        }
    }
}
