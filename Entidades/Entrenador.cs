﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp.Entidades
{
    public class Entrenador
    {
        public int EntrenadorID { get; set; }
        public string Nombre { get; set; }
        public string Especialidad { get; set; }
        public string Disponibilidad { get; set; }
    }
}
