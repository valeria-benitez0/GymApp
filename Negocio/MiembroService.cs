using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymApp.AccesoDatos;
using GymApp.Entidades;

namespace GymApp.Negocio
{
    public class MiembroService
    {
        private readonly IMiembroRepository miembroRepository;

        public MiembroService(IMiembroRepository miembroRepository)
        {
            this.miembroRepository = miembroRepository;
        }

        // Método para registrar un nuevo miembro.
        public void RegistrarMiembro(Miembro miembro)
        {
            miembroRepository.RegistrarMiembro(miembro);
        }

        // Método para actualizar un miembro existente.
        public void ActualizarMiembro(Miembro miembro)
        {
            miembroRepository.Actualizar(miembro);
        }

        public void EliminarMiembro(int id)
        {
            miembroRepository.Eliminar(id);
        }

        public Miembro ObtenerMiembroPorId(int id)
        {
            return miembroRepository.ObtenerPorId(id);
        }

        public IEnumerable<Miembro> ObtenerTodosLosMiembros()
        {
            return miembroRepository.ObtenerTodos();
        }
    }
}
