using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymApp.Entidades;

namespace GymApp.AccesoDatos
{
    public interface IEntrenadorRepository
    {
        void Crear(Entrenador entrenador);
        Entrenador ObtenerPorId(int id);
        IEnumerable<Entrenador> ObtenerTodos();
        void Actualizar(Entrenador entrenador);
        void Eliminar(int id);
    }
}
