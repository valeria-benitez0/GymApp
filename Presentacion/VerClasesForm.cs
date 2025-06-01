using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GymApp.AccesoDatos;
using GymApp.Entidades;

namespace GymApp.Presentacion
{
    public partial class VerClasesForm : Form
    {
        private ClaseRepository claseRepo;

        public VerClasesForm()
        {
            InitializeComponent();
            claseRepo = new ClaseRepository();
            CargarClases();
        }

        private void CargarClases()
        {
            try
            {
                var clases = claseRepo.ObtenerTodos().ToList();
                dgvClases.DataSource = clases;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las clases: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
