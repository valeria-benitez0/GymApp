using System;
using System.Collections.Generic;
using System.Linq;
using GymApp.Entidades;
using GymApp.AccesoDatos;

namespace GymApp.Factories
{
    public static class ReporteFactory
    {
        // Reporte de asistencia general por periodo
        public static IEnumerable<ReporteAsistenciaDTO> CrearReporteAsistencia(DateTime fechaInicio, DateTime fechaFin, IAccesoRepository repo)
        {
            return repo.GenerarReporteAsistencia(fechaInicio, fechaFin);
        }

        // Reporte de popularidad de clases (reservas + accesos)
        public static IEnumerable<PopularidadClaseDTO> CrearReportePopularidadClases(
            IReservaRepository reservaRepo,
            IAccesoRepository accesoRepo,
            IClaseRepository claseRepo)
        {
            var clases = claseRepo.ObtenerTodos().ToList();

            var reservas = reservaRepo.ObtenerTodos();
            var accesos = accesoRepo.ObtenerTodos();

            var popularidad = clases.Select(c => new PopularidadClaseDTO
            {
                ClaseID = c.ClaseID,
                NombreClase = c.NombreClase,
                TotalReservas = reservas.Count(r => r.ClaseID == c.ClaseID),
                TotalAsistencias = accesos.Count(a => a.ClaseID == c.ClaseID)
            });

            return popularidad.OrderByDescending(p => p.TotalReservas);
        }

        // Reporte de asistencias por usuario (para uso personal o admin)
        public static IEnumerable<Acceso> CrearReporteAsistenciaPorUsuario(int usuarioId, IAccesoRepository repo)
        {
            return repo.ObtenerAccesosPorUsuario(usuarioId);
        }

        // Reporte de asistencias por clase y fechas (para admins)
        public static IEnumerable<Acceso> CrearReporteAsistenciaPorClaseYFecha(int claseId, DateTime desde, DateTime hasta, IAccesoRepository repo)
        {
            return repo.ObtenerAccesosPorClaseYFecha(claseId, desde, hasta);
        }

        // Reporte resumen de todos los accesos
        public static IEnumerable<Acceso> CrearReporteGeneral(IAccesoRepository repo)
        {
            return repo.ObtenerTodos();
        }
    }
}
