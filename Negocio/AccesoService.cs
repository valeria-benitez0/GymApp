using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            // Aquí podrías incluir validaciones adicionales, si es necesario.
            return accesoRepo.InsertarAcceso(acceso);
        }

        public IEnumerable<ReporteAsistenciaDTO> ObtenerReporteAsistencia(DateTime fechaInicio, DateTime fechaFin)
        {
            // Se utiliza la Factory para crear el reporte
            return ReporteFactory.CrearReporteAsistencia(fechaInicio, fechaFin, accesoRepo);
        }

        public IEnumerable<NotificacionReservaDTO> ObtenerNotificacionesPendientes()
        {
            return NotificacionFactory.CrearNotificaciones(accesoRepo);
        }
    }
}
