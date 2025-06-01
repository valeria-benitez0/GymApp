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

        public AccesoService(IAccesoRepository repo)
        {
            accesoRepo = repo;
        }

        public IEnumerable<NotificacionReservaDTO> ObtenerNotificacionesPendientes()
        {
            // Utilizamos NotificacionFactory para crear la lista de notificaciones.
            return NotificacionFactory.CrearNotificaciones(accesoRepo);
        }

        //Registrar acceso (cuando un miembro ingresa)
        public int RegistrarAcceso(Acceso acceso)
        {
            if (acceso == null)
                throw new ArgumentNullException(nameof(acceso));

            return accesoRepo.InsertarAcceso(acceso);
        }

        // 🟢 Generar reporte general de asistencia por rango de fechas
        public IEnumerable<ReporteAsistenciaDTO> ObtenerReporteAsistencia(DateTime fechaInicio, DateTime fechaFin)
        {
            return ReporteFactory.CrearReporteAsistencia(fechaInicio, fechaFin, accesoRepo);
        }

        //Obtener accesos por usuario (para reportes personales)
        public IEnumerable<Acceso> ObtenerAccesosPorUsuario(int usuarioId)
        {
            return accesoRepo.ObtenerAccesosPorUsuario(usuarioId);
        }

        //Obtener accesos por clase (para popularidad)
        public IEnumerable<Acceso> ObtenerAccesosPorClase(int claseId)
        {
            return accesoRepo.ObtenerAccesosPorClase(claseId);
        }

        // Obtener accesos por clase y fecha (para reportes filtrados por periodo)
        public IEnumerable<Acceso> ObtenerAccesosPorClaseYFecha(int claseId, DateTime desde, DateTime hasta)
        {
            return accesoRepo.ObtenerAccesosPorClaseYFecha(claseId, desde, hasta);
        }

        // Obtener todos los accesos (solo para admin)
        public IEnumerable<Acceso> ObtenerTodos()
        {
            return accesoRepo.ObtenerTodos();
        }
    }
}
