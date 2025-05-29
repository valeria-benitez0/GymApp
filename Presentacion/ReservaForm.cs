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
    public partial class ReservaForm : Form
    {
        private ReservaService reservaService;
        private Miembro currentMiembro;
        private IClaseRepository claseRepository;

        public ReservaForm(Miembro miembro)
        {
            InitializeComponent();
        }
        private void ReservaForm_Load(object sender, EventArgs e)
        {

        }

        private void btnReservar_Click_1(object sender, EventArgs e)
        {

        }
    }
}
