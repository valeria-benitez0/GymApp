namespace GymApp.Presentacion
{
    partial class AdminDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnGestionarClases = new System.Windows.Forms.Button();
            this.btnGestionarEntrenadores = new System.Windows.Forms.Button();
            this.btnGestionarReservas = new System.Windows.Forms.Button();
            this.btnGestionarMiembros = new System.Windows.Forms.Button();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReportes
            // 
            this.btnReportes.Location = new System.Drawing.Point(553, 225);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(75, 23);
            this.btnReportes.TabIndex = 10;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click_1);
            // 
            // btnGestionarClases
            // 
            this.btnGestionarClases.Location = new System.Drawing.Point(381, 147);
            this.btnGestionarClases.Name = "btnGestionarClases";
            this.btnGestionarClases.Size = new System.Drawing.Size(75, 23);
            this.btnGestionarClases.TabIndex = 9;
            this.btnGestionarClases.Text = "Clases";
            this.btnGestionarClases.UseVisualStyleBackColor = true;
            this.btnGestionarClases.Click += new System.EventHandler(this.btnGestionarClases_Click_1);
            // 
            // btnGestionarEntrenadores
            // 
            this.btnGestionarEntrenadores.Location = new System.Drawing.Point(173, 280);
            this.btnGestionarEntrenadores.Name = "btnGestionarEntrenadores";
            this.btnGestionarEntrenadores.Size = new System.Drawing.Size(95, 23);
            this.btnGestionarEntrenadores.TabIndex = 8;
            this.btnGestionarEntrenadores.Text = "Entrenadores";
            this.btnGestionarEntrenadores.UseVisualStyleBackColor = true;
            this.btnGestionarEntrenadores.Click += new System.EventHandler(this.btnGestionarEntrenadores_Click_1);
            // 
            // btnGestionarReservas
            // 
            this.btnGestionarReservas.Location = new System.Drawing.Point(381, 280);
            this.btnGestionarReservas.Name = "btnGestionarReservas";
            this.btnGestionarReservas.Size = new System.Drawing.Size(75, 23);
            this.btnGestionarReservas.TabIndex = 7;
            this.btnGestionarReservas.Text = "Reservas";
            this.btnGestionarReservas.UseVisualStyleBackColor = true;
            this.btnGestionarReservas.Click += new System.EventHandler(this.btnGestionarReservas_Click_1);
            // 
            // btnGestionarMiembros
            // 
            this.btnGestionarMiembros.Location = new System.Drawing.Point(173, 147);
            this.btnGestionarMiembros.Name = "btnGestionarMiembros";
            this.btnGestionarMiembros.Size = new System.Drawing.Size(75, 23);
            this.btnGestionarMiembros.TabIndex = 6;
            this.btnGestionarMiembros.Text = "Miembros";
            this.btnGestionarMiembros.UseVisualStyleBackColor = true;
            this.btnGestionarMiembros.Click += new System.EventHandler(this.btnGestionarMiembros_Click_1);
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Location = new System.Drawing.Point(288, 64);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(60, 13);
            this.lblBienvenida.TabIndex = 11;
            this.lblBienvenida.Text = "Bienvenida";
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBienvenida);
            this.Controls.Add(this.btnReportes);
            this.Controls.Add(this.btnGestionarClases);
            this.Controls.Add(this.btnGestionarEntrenadores);
            this.Controls.Add(this.btnGestionarReservas);
            this.Controls.Add(this.btnGestionarMiembros);
            this.Name = "AdminDashboard";
            this.Text = "AdminDashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnGestionarClases;
        private System.Windows.Forms.Button btnGestionarEntrenadores;
        private System.Windows.Forms.Button btnGestionarReservas;
        private System.Windows.Forms.Button btnGestionarMiembros;
        private System.Windows.Forms.Label lblBienvenida;
    }
}