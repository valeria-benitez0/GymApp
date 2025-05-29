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
            this.btnGestionarMiembros = new System.Windows.Forms.Button();
            this.btnGestionarReservas = new System.Windows.Forms.Button();
            this.btnGestionarEntrenadores = new System.Windows.Forms.Button();
            this.btnGestionarClases = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGestionarMiembros
            // 
            this.btnGestionarMiembros.Location = new System.Drawing.Point(202, 144);
            this.btnGestionarMiembros.Name = "btnGestionarMiembros";
            this.btnGestionarMiembros.Size = new System.Drawing.Size(75, 23);
            this.btnGestionarMiembros.TabIndex = 0;
            this.btnGestionarMiembros.Text = "Miembros";
            this.btnGestionarMiembros.UseVisualStyleBackColor = true;
            this.btnGestionarMiembros.Click += new System.EventHandler(this.btnGestionarMiembros_Click_1);
            // 
            // btnGestionarReservas
            // 
            this.btnGestionarReservas.Location = new System.Drawing.Point(400, 277);
            this.btnGestionarReservas.Name = "btnGestionarReservas";
            this.btnGestionarReservas.Size = new System.Drawing.Size(75, 23);
            this.btnGestionarReservas.TabIndex = 2;
            this.btnGestionarReservas.Text = "Reservas";
            this.btnGestionarReservas.UseVisualStyleBackColor = true;
            // 
            // btnGestionarEntrenadores
            // 
            this.btnGestionarEntrenadores.Location = new System.Drawing.Point(202, 277);
            this.btnGestionarEntrenadores.Name = "btnGestionarEntrenadores";
            this.btnGestionarEntrenadores.Size = new System.Drawing.Size(95, 23);
            this.btnGestionarEntrenadores.TabIndex = 3;
            this.btnGestionarEntrenadores.Text = "Entrenadores";
            this.btnGestionarEntrenadores.UseVisualStyleBackColor = true;
            // 
            // btnGestionarClases
            // 
            this.btnGestionarClases.Location = new System.Drawing.Point(410, 144);
            this.btnGestionarClases.Name = "btnGestionarClases";
            this.btnGestionarClases.Size = new System.Drawing.Size(75, 23);
            this.btnGestionarClases.TabIndex = 4;
            this.btnGestionarClases.Text = "Clases";
            this.btnGestionarClases.UseVisualStyleBackColor = true;
            // 
            // btnReportes
            // 
            this.btnReportes.Location = new System.Drawing.Point(582, 222);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(75, 23);
            this.btnReportes.TabIndex = 5;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.UseVisualStyleBackColor = true;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReportes);
            this.Controls.Add(this.btnGestionarClases);
            this.Controls.Add(this.btnGestionarEntrenadores);
            this.Controls.Add(this.btnGestionarReservas);
            this.Controls.Add(this.btnGestionarMiembros);
            this.Name = "AdminDashboard";
            this.Text = "AdminDashboard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGestionarMiembros;
        private System.Windows.Forms.Button btnGestionarReservas;
        private System.Windows.Forms.Button btnGestionarEntrenadores;
        private System.Windows.Forms.Button btnGestionarClases;
        private System.Windows.Forms.Button btnReportes;
    }
}