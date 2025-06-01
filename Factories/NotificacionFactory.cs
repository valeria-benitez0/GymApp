using System.Collections.Generic;
using GymApp.Entidades;
using GymApp.AccesoDatos;

namespace GymApp.Factories
{
    public static class NotificacionFactory
    {
        public static IEnumerable<NotificacionReservaDTO> CrearNotificaciones(IAccesoRepository repo)
        {
            return repo.ObtenerNotificacionesReservasPendientes();
        }
    }
}
