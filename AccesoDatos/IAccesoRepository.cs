using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymApp.Entidades;

namespace GymApp.AccesoDatos
{
    public interface IAccesoRepository
    {
        int InsertarAcceso(Acceso acceso);
        IEnumerable<ReporteAsistenciaDTO> GenerarReporteAsistencia(DateTime fechaInicio, DateTime fechaFin);
        IEnumerable<NotificacionReservaDTO> ObtenerNotificacionesReservasPendientes();
        IEnumerable<Acceso> ObtenerAccesosPorUsuario(int usuarioId);
        IEnumerable<Acceso> ObtenerAccesosPorClase(int claseId);
        IEnumerable<Acceso> ObtenerAccesosPorClaseYFecha(int claseId, DateTime desde, DateTime hasta);
        IEnumerable<Acceso> ObtenerTodos();
    }
}
