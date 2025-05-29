using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GymApp.Entidades;

namespace GymApp.Presentacion
{
    public partial class MemberDashboard : Form
    {
        private Miembro usuarioActual;

        public MemberDashboard(Miembro miembro)
        {
            InitializeComponent();
            usuarioActual = miembro;
            lblBienvenida.Text = $"Bienvenido, {usuarioActual.Nombre}";
            // Aquí podrías cargar la información inicial del miembro y sus reservas en el dgvReservas.
        }

        // Evento para ver las clases disponibles
        private void btnVerClases_Click(object sender, EventArgs e)
        {
            // Por ejemplo, abrir un formulario que liste las clases disponibles
            // ClasesForm clasesForm = new ClasesForm();
            // clasesForm.ShowDialog();
        }

        // Evento para realizar una reserva
        private void btnReservar_Click(object sender, EventArgs e)
        {
            // Se podría abrir un formulario de reserva con los detalles necesarios.
            // ReservaForm reservaForm = new ReservaForm(usuarioActual);
            // reservaForm.ShowDialog();
        }

        // Evento para cancelar una reserva
        private void btnCancelarReserva_Click(object sender, EventArgs e)
        {
            // Se podría implementar la lógica para cancelar una reserva seleccionada del dgvReservas.
            // Por ejemplo, verificar si se seleccionó una fila y llamar al ReservaService.
        }


        private void MemberDashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
