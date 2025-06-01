using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymApp.Entidades;

public interface IReservaRepository
{
    int RegistrarReserva(Reserva reserva);
    void CancelarReserva(int reservaId);
    Reserva ObtenerPorId(int reservaId);
    int ContarReservasActivasPorClase(int claseId);
    IEnumerable<Reserva> ObtenerReservasPorMiembro(int usuarioId);

    IEnumerable<Acceso> ObtenerTodos();
}