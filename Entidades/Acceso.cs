using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp.Entidades
{
    public class Acceso
    {
        public int AccesoID { get; set; }
        public int UsuarioID { get; set; }
        public int ClaseID { get; set; }
        public DateTime FechaAcceso { get; set; }
        public string EstadoAcceso { get; set; } 
    }

    public class ReporteAsistenciaDTO
    {
        public int ClaseID { get; set; }
        public string NombreClase { get; set; }
        public int UsuarioID { get; set; }
        public string NombreMiembro { get; set; }
        public int TotalAccesos { get; set; }
    }

    public class NotificacionReservaDTO
    {
        public int ReservaID { get; set; }
        public int UsuarioID { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public int ClaseID { get; set; }
        public string NombreClase { get; set; }
        public DateTime FechaReserva { get; set; }
    }
}
