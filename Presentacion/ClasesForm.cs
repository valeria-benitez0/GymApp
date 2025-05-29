using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GymApp.Negocio;
using GymApp.AccesoDatos;
using GymApp.Entidades;

namespace GymApp.Presentacion
{
    public partial class ClasesForm : Form
    {
        private ClaseService claseService;

        public ClasesForm()
        {
            InitializeComponent();
            claseService = new ClaseService(new ClaseRepository());
            CargarClases();
        }

        /// <summary>
        /// Carga el listado de clases en el DataGridView.
        /// </summary>
        private void CargarClases()
        {
            try
            {
                var clases = claseService.ObtenerTodasLasClases();
                dgvClases.DataSource = clases.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las clases: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Abre el formulario para la creación de una nueva clase.
        /// </summary>
        private void btnNuevaClase_Click_1(object sender, EventArgs e)
        { 
        ClaseNuevoForm nuevoForm = new ClaseNuevoForm();
            nuevoForm.ShowDialog();
            CargarClases();
        }

        /// <summary>
        /// Abre el formulario para editar la clase seleccionada.
        /// </summary>
        private void btnEditarClase_Click_1(object sender, EventArgs e)
        {
            if (dgvClases.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una clase para editar.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idClase = Convert.ToInt32(dgvClases.SelectedRows[0].Cells["ClaseID"].Value);
            Clase clase = claseService.ObtenerTodasLasClases().FirstOrDefault(c => c.ClaseID == idClase);
            if (clase != null)
            {
                ClaseNuevoForm editarForm = new ClaseNuevoForm(clase);
                editarForm.ShowDialog();
                CargarClases();
            }
        }

        /// <summary>
        /// Elimina la clase seleccionada, tras una confirmación.
        /// </summary>
        private void btnEliminarClase_Click_1(object sender, EventArgs e)
        {
            if (dgvClases.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una clase para eliminar.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idClase = Convert.ToInt32(dgvClases.SelectedRows[0].Cells["ClaseID"].Value);
            try
            {
                DialogResult resultado = MessageBox.Show("¿Está seguro de eliminar la clase seleccionada?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    claseService.EliminarClase(idClase);
                    MessageBox.Show("Clase eliminada correctamente.", "Información",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarClases();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la clase: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Actualiza el listado de clases.
        /// </summary>

        private void btnRefrescar_Click_1(object sender, EventArgs e)
        {
            CargarClases();
        }

        private void ClasesForm_Load(object sender, EventArgs e)
        {

        }
    }
}
