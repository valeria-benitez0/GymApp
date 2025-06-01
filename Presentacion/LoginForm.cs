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
        // Servicio de miembros: encapsula la lógica de negocio relacionada con los usuarios
        private MiembroService miembroService;

        public LoginForm()
        {
            InitializeComponent();
            miembroService = new MiembroService(new MiembroRepository());
            this.VisibleChanged += new EventHandler(LoginForm_VisibleChanged);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Validación básica: se verifica que ninguno de los campos esté vacío
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                lblMensaje.Text = "Por favor, ingresa el correo y la contraseña.";
                return;
            }

            // Se busca el miembro por correo electrónico
            Miembro miembro = ObtenerMiembroPorEmail(email);
            if (miembro == null)
            {
                lblMensaje.Text = "El usuario no se encuentra registrado o está inactivo.";
                return;
            }

            if (!miembro.Password.Equals(password))
            {
                lblMensaje.Text = "La contraseña es incorrecta.";
                return;
            }

            // Si todo es válido, se redirige según el rol del usuario
            if (string.Equals(miembro.Rol, "Administrador", StringComparison.OrdinalIgnoreCase))
            {
                // Se instancia y muestra el dashboard del Administrador
                AdminDashboard adminForm = new AdminDashboard(miembro);
                this.Hide();
                adminForm.ShowDialog();
                this.Show();
            }
            else if (string.Equals(miembro.Rol, "Miembro", StringComparison.OrdinalIgnoreCase))
            {
                // Se instancia y muestra el dashboard para Miembros
                MemberDashboard memberForm = new MemberDashboard(miembro);
                this.Hide();
                memberForm.ShowDialog();
                this.Show();
            }
            else
            {
                // Si el rol no está configurado correctamente, se informa el error
                lblMensaje.Text = "El rol del usuario no está configurado correctamente.";
            }
        }

        private Miembro ObtenerMiembroPorEmail(string email)
        {
            foreach (Miembro m in miembroService.ObtenerTodosLosMiembros())
            {
                if (m.Email.Equals(email, StringComparison.OrdinalIgnoreCase))
                    return m;
            }
            return null; 
        }

        private void LoginForm_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                LimpiarControles();
            }
        }

        private void LimpiarControles()
        {
            txtEmail.Text = string.Empty;
            txtPassword.Text = string.Empty;
            lblMensaje.Text = string.Empty;
        }



        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void lblMensaje_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            MiembroNuevoUsuario nuevoForm = new MiembroNuevoUsuario();

            this.Hide();
            nuevoForm.ShowDialog();
            this.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
