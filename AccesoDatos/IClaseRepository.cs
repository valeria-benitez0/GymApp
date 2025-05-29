using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymApp.Entidades;

namespace GymApp.AccesoDatos
{
    public interface IClaseRepository
    {
        void Crear(Clase clase);
        Clase ObtenerPorId(int id);
        IEnumerable<Clase> ObtenerTodos();
        void Actualizar(Clase clase);
        void Eliminar(int id);
    }
}
