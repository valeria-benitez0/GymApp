namespace GymApp.Presentacion
{
    partial class MemberDashboard
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
            this.lblInfoMiembro = new System.Windows.Forms.Label();
            this.dgvReservas = new System.Windows.Forms.DataGridView();
            this.btnCancelarReserva = new System.Windows.Forms.Button();
            this.btnReservarClase = new System.Windows.Forms.Button();
            this.btnVerClases = new System.Windows.Forms.Button();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.btnRefrescarReservas = new System.Windows.Forms.Button();
            this.lblVencimiento = new System.Windows.Forms.Label();
            this.btnVerMisReservas = new System.Windows.Forms.Button();
            this.btnMisReportes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInfoMiembro
            // 
            this.lblInfoMiembro.AutoSize = true;
            this.lblInfoMiembro.Location = new System.Drawing.Point(449, 337);
            this.lblInfoMiembro.Name = "lblInfoMiembro";
            this.lblInfoMiembro.Size = new System.Drawing.Size(16, 13);
            this.lblInfoMiembro.TabIndex = 11;
            this.lblInfoMiembro.Text = "...";
            // 
            // dgvReservas
            // 
            this.dgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservas.Location = new System.Drawing.Point(449, 118);
            this.dgvReservas.Name = "dgvReservas";
            this.dgvReservas.Size = new System.Drawing.Size(240, 150);
            this.dgvReservas.TabIndex = 10;
            // 
            // btnCancelarReserva
            // 
            this.btnCancelarReserva.Location = new System.Drawing.Point(112, 196);
            this.btnCancelarReserva.Name = "btnCancelarReserva";
            this.btnCancelarReserva.Size = new System.Drawing.Size(166, 23);
            this.btnCancelarReserva.TabIndex = 9;
            this.btnCancelarReserva.Text = "Cancelar reserva";
            this.btnCancelarReserva.UseVisualStyleBackColor = true;
            this.btnCancelarReserva.Click += new System.EventHandler(this.btnCancelarReserva_Click_1);
            // 
            // btnReservarClase
            // 
            this.btnReservarClase.Location = new System.Drawing.Point(112, 118);
            this.btnReservarClase.Name = "btnReservarClase";
            this.btnReservarClase.Size = new System.Drawing.Size(150, 23);
            this.btnReservarClase.TabIndex = 8;
            this.btnReservarClase.Text = "Realizar reserva";
            this.btnReservarClase.UseVisualStyleBackColor = true;
            this.btnReservarClase.Click += new System.EventHandler(this.btnReservar_Click_1);
            // 
            // btnVerClases
            // 
            this.btnVerClases.Location = new System.Drawing.Point(113, 58);
            this.btnVerClases.Name = "btnVerClases";
            this.btnVerClases.Size = new System.Drawing.Size(117, 23);
            this.btnVerClases.TabIndex = 7;
            this.btnVerClases.Text = "Consultar Clases";
            this.btnVerClases.UseVisualStyleBackColor = true;
            this.btnVerClases.Click += new System.EventHandler(this.btnVerClases_Click_1);
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Location = new System.Drawing.Point(330, 33);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(60, 13);
            this.lblBienvenida.TabIndex = 12;
            this.lblBienvenida.Text = "Bienvenida";
            // 
            // btnRefrescarReservas
            // 
            this.btnRefrescarReservas.Location = new System.Drawing.Point(452, 378);
            this.btnRefrescarReservas.Name = "btnRefrescarReservas";
            this.btnRefrescarReservas.Size = new System.Drawing.Size(166, 23);
            this.btnRefrescarReservas.TabIndex = 13;
            this.btnRefrescarReservas.Text = "Actualizar";
            this.btnRefrescarReservas.UseVisualStyleBackColor = true;
            this.btnRefrescarReservas.Click += new System.EventHandler(this.btnRefrescarReservas_Click);
            // 
            // lblVencimiento
            // 
            this.lblVencimiento.AutoSize = true;
            this.lblVencimiento.Location = new System.Drawing.Point(246, 398);
            this.lblVencimiento.Name = "lblVencimiento";
            this.lblVencimiento.Size = new System.Drawing.Size(16, 13);
            this.lblVencimiento.TabIndex = 14;
            this.lblVencimiento.Text = "...";
            // 
            // btnVerMisReservas
            // 
            this.btnVerMisReservas.Location = new System.Drawing.Point(112, 264);
            this.btnVerMisReservas.Name = "btnVerMisReservas";
            this.btnVerMisReservas.Size = new System.Drawing.Size(166, 23);
            this.btnVerMisReservas.TabIndex = 15;
            this.btnVerMisReservas.Text = "Cancelar reserva";
            this.btnVerMisReservas.UseVisualStyleBackColor = true;
            // 
            // btnMisReportes
            // 
            this.btnMisReportes.Location = new System.Drawing.Point(113, 332);
            this.btnMisReportes.Name = "btnMisReportes";
            this.btnMisReportes.Size = new System.Drawing.Size(75, 23);
            this.btnMisReportes.TabIndex = 16;
            this.btnMisReportes.Text = "Reportes";
            this.btnMisReportes.UseVisualStyleBackColor = true;
            this.btnMisReportes.Click += new System.EventHandler(this.btnMisReportes_Click);
            // 
            // MemberDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMisReportes);
            this.Controls.Add(this.btnVerMisReservas);
            this.Controls.Add(this.lblVencimiento);
            this.Controls.Add(this.btnRefrescarReservas);
            this.Controls.Add(this.lblBienvenida);
            this.Controls.Add(this.lblInfoMiembro);
            this.Controls.Add(this.dgvReservas);
            this.Controls.Add(this.btnCancelarReserva);
            this.Controls.Add(this.btnReservarClase);
            this.Controls.Add(this.btnVerClases);
            this.Name = "MemberDashboard";
            this.Text = "MemberDashboard";
            this.Load += new System.EventHandler(this.MemberDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfoMiembro;
        private System.Windows.Forms.DataGridView dgvReservas;
        private System.Windows.Forms.Button btnCancelarReserva;
        private System.Windows.Forms.Button btnReservarClase;
        private System.Windows.Forms.Button btnVerClases;
        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Button btnRefrescarReservas;
        private System.Windows.Forms.Label lblVencimiento;
        private System.Windows.Forms.Button btnVerMisReservas;
        private System.Windows.Forms.Button btnMisReportes;
    }
}