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
    public partial class MiembrosForm : Form
    {
        private MiembroService miembroService;

        public MiembrosForm()
        {
            InitializeComponent();
            // Instancia el servicio utilizando el repositorio correspondiente.
            miembroService = new MiembroService(new MiembroRepository());
            // Cargar el listado de miembros al iniciar el formulario.
            CargarMiembros();
        }

        /// <summary>
        /// Carga el DataGridView (dgvMiembros) con la lista de miembros.
        /// </summary>
        private void CargarMiembros()
        {
            try
            {
                var miembros = miembroService.ObtenerTodosLosMiembros();
                dgvMiembros.DataSource = miembros.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar miembros: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// Abre el formulario para agregar un nuevo miembro.

        private void btnNuevoMiembro_Click_1(object sender, EventArgs e)
        {
            MiembroNuevoForm nuevoForm = new MiembroNuevoForm();
            nuevoForm.ShowDialog();
            CargarMiembros();
        }

        /// Abre el formulario para editar al miembro seleccionado.
        private void btnEditarMiembro_Click_1(object sender, EventArgs e)
        {
            if (dgvMiembros.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un miembro para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Se asume que el DataGridView tiene una columna "UsuarioID".
            int idMiembro = Convert.ToInt32(dgvMiembros.SelectedRows[0].Cells["UsuarioID"].Value);
            // Para editar, buscamos el miembro en la lista; también se puede agregar un método específico en el servicio.
            Miembro miembro = miembroService.ObtenerTodosLosMiembros().FirstOrDefault(m => m.UsuarioID == idMiembro);
            if (miembro != null)
            {
                MiembroNuevoForm editarForm = new MiembroNuevoForm(miembro);
                editarForm.ShowDialog();
                CargarMiembros();
            }
        }

        /// <summary>
        /// Elimina el miembro seleccionado.
        /// </summary>
        private void btnEliminarMiembro_Click_1(object sender, EventArgs e)
        {
            if (dgvMiembros.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un miembro para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idMiembro = Convert.ToInt32(dgvMiembros.SelectedRows[0].Cells["UsuarioID"].Value);
            try
            {
                // Se asume que tienes un método EliminarMiembro en MiembroService.
                miembroService.EliminarMiembro(idMiembro);
                MessageBox.Show("Miembro eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarMiembros();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar al miembro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// Actualiza el listado de miembros en el DataGridView.
        private void btnRefrescar_Click_1(object sender, EventArgs e)
        {
            CargarMiembros();
        }
        private void MiembrosForm_Load(object sender, EventArgs e)
        {

        }

        private void dgvMiembros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
