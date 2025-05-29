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
        }

        private void MemberDashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
