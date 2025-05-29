using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp.Entidades
{
    public class Miembro
    {
        public int UsuarioID { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string TipoMembresia { get; set; }
        public DateTime FechaVencimientoMembresia { get; set; }
        public string Rol { get; set; }  // "Administrador" o "Miembro"
        public bool Activo { get; set; }
        public string Password { get; set; }
    }
}
