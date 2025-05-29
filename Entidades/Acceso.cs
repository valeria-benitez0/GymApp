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
        public DateTime FechaAcceso { get; set; }
        public int ClaseID { get; set; }
        public string EstadoAcceso { get; set; } // "Permitido" o "Denegado"
    }
}
