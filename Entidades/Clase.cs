using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp.Entidades
{
    public class Clase
    {
        public int ClaseID { get; set; }
        public string NombreClase { get; set; }
        public DateTime Horario { get; set; }
        public int Duracion { get; set; }
        public int CapacidadMaxima { get; set; }
        public int EntrenadorID { get; set; }
    }
}
