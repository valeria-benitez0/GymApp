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
        private readonly IMiembroRepository miembroRepo;

        public MiembroService(IMiembroRepository repo)
        {
            this.miembroRepo = repo;
        }

        public int CrearMiembro(Miembro miembro)
        {
            miembroRepo.Crear(miembro);
            return miembro.UsuarioID;
        }

        public void ActualizarMiembro(Miembro miembro)
        {
            miembroRepo.Actualizar(miembro);
        }

        public void EliminarMiembro(int id)
        {
            miembroRepo.Eliminar(id);
        }

        public Miembro ObtenerMiembroPorId(int id)
        {
            return miembroRepo.ObtenerPorId(id);
        }

        public IEnumerable<Miembro> ObtenerTodosLosMiembros()
        {
            return miembroRepo.ObtenerTodos();
        }
    }
}
