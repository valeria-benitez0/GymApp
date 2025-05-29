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
    public partial class CancelarReservaForm : Form
    {
        public CancelarReservaForm(Miembro miembro)
        {
            InitializeComponent();
        }
        private void CancelarReservaForm_Load(object sender, EventArgs e)
        {

        }
    }
}
