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
using GymApp.Negocio;
using GymApp.AccesoDatos;

namespace GymApp.Presentacion
{
    public partial class EntrenadoresForm : Form
    {
        private EntrenadorService entrenadorService;

        public EntrenadoresForm()
        {
            InitializeComponent();
            entrenadorService = new EntrenadorService(new EntrenadorRepository());
            CargarEntrenadores();
        }

        private void CargarEntrenadores()
        {
            try
            {
                var entrenadores = entrenadorService.ObtenerTodosLosEntrenadores();
                dgvEntrenadores.DataSource = entrenadores.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar entrenadores: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevoEntrenador_Click_1(object sender, EventArgs e)
        {
            EntrenadorNuevoForm nuevoForm = new EntrenadorNuevoForm();
            nuevoForm.ShowDialog();
            CargarEntrenadores();
        }

        private void btnEditarEntrenador_Click_1(object sender, EventArgs e)
        {
            if (dgvEntrenadores.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un entrenador para editar.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idEntrenador = Convert.ToInt32(dgvEntrenadores.SelectedRows[0].Cells["EntrenadorID"].Value);
            Entrenador entrenador = entrenadorService.ObtenerTodosLosEntrenadores().FirstOrDefault(x => x.EntrenadorID == idEntrenador);
            if (entrenador != null)
            {
                EntrenadorNuevoForm editarForm = new EntrenadorNuevoForm(entrenador);
                editarForm.ShowDialog();
                CargarEntrenadores();
            }
        }

        private void btnEliminarEntrenador_Click_1(object sender, EventArgs e)
        {
            if (dgvEntrenadores.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un entrenador para eliminar.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idEntrenador = Convert.ToInt32(dgvEntrenadores.SelectedRows[0].Cells["EntrenadorID"].Value);
            try
            {
                DialogResult resultado = MessageBox.Show("¿Está seguro de eliminar el entrenador seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    entrenadorService.EliminarEntrenador(idEntrenador);
                    MessageBox.Show("Entrenador eliminado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarEntrenadores();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el entrenador: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefrescar_Click_1(object sender, EventArgs e)
        {
            CargarEntrenadores();
        }

        private void EntrenadoresForm_Load(object sender, EventArgs e)
        {

        }
    }
}
