using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp.Entidades
{
    public class PopularidadClaseDTO
    {
        public int ClaseID { get; set; }
        public string NombreClase { get; set; }
        public int TotalReservas { get; set; }
        public int TotalAsistencias { get; set; }
    }
}
