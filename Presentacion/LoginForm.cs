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
    public partial class LoginForm : Form
    {
        private MiembroService miembroService;

        public LoginForm()
        {
            InitializeComponent();
            // Inicializar el servicio con la instancia del repositorio actualizado
            miembroService = new MiembroService(new MiembroRepository());
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            // Obtener los datos ingresados
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;

            // Validación básica
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                lblMensaje.Text = "Por favor, ingresa correo y contraseña.";
                return;
            }

            // Buscar el miembro por email (se supone que el servicio ya cuenta con métodos para obtener todos los miembros)
            Miembro miembro = ObtenerMiembroPorEmail(email);
            if (miembro == null)
            {
                lblMensaje.Text = "El usuario no se encuentra registrado o está inactivo.";
                return;
            }

            // Validar la contraseña (nota: en producción, comparar hashes)
            if (!miembro.Password.Equals(password))
            {
                lblMensaje.Text = "La contraseña es incorrecta.";
                return;
            }

            // Seguir según el rol
            if (string.Equals(miembro.Rol, "Administrador", StringComparison.OrdinalIgnoreCase))
            {
                AdminDashboard adminForm = new AdminDashboard(miembro);
                this.Hide();
                adminForm.ShowDialog();
                this.Show();
            }
            else if (string.Equals(miembro.Rol, "Miembro", StringComparison.OrdinalIgnoreCase))
            {
                MemberDashboard memberForm = new MemberDashboard(miembro);
                this.Hide();
                memberForm.ShowDialog();
                this.Show();
            }
            else
            {
                lblMensaje.Text = "El rol del usuario no está configurado.";
            }
        }

        // Método auxiliar para obtener un miembro filtrando por email
        private Miembro ObtenerMiembroPorEmail(string email)
        {
            foreach (Miembro m in miembroService.ObtenerTodosLosMiembros())
            {
                if (m.Email.Equals(email, StringComparison.OrdinalIgnoreCase))
                    return m;
            }
            return null;
        }
    }
}
