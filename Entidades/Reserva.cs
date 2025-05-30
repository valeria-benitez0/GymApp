using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GymApp.Entidades
{
    public class Reserva
    {
        public int ReservaID { get; set; }
        public int UsuarioID { get; set; }
        public int ClaseID { get; set; }
        public DateTime FechaReserva { get; set; }
        public string Estado { get; set; } // "Activa" o "Cancelada"
        public DateTime? FechaCancelacion { get; set; }
    }
}
