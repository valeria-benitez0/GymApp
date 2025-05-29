using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymApp.Entidades;

namespace GymApp.AccesoDatos
{
    public interface IMiembroRepository
    {
        void Crear(Miembro miembro);
        Miembro ObtenerPorId(int id);
        IEnumerable<Miembro> ObtenerTodos();
        void Actualizar(Miembro miembro);
        void Eliminar(int id);
    }
}
