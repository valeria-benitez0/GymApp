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
            this.btnReservar = new System.Windows.Forms.Button();
            this.btnVerClases = new System.Windows.Forms.Button();
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
            this.btnCancelarReserva.Location = new System.Drawing.Point(112, 308);
            this.btnCancelarReserva.Name = "btnCancelarReserva";
            this.btnCancelarReserva.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarReserva.TabIndex = 9;
            this.btnCancelarReserva.Text = "Cancelar reserva";
            this.btnCancelarReserva.UseVisualStyleBackColor = true;
            // 
            // btnReservar
            // 
            this.btnReservar.Location = new System.Drawing.Point(112, 203);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(75, 23);
            this.btnReservar.TabIndex = 8;
            this.btnReservar.Text = "Realizar reserva";
            this.btnReservar.UseVisualStyleBackColor = true;
            // 
            // btnVerClases
            // 
            this.btnVerClases.Location = new System.Drawing.Point(112, 101);
            this.btnVerClases.Name = "btnVerClases";
            this.btnVerClases.Size = new System.Drawing.Size(75, 23);
            this.btnVerClases.TabIndex = 7;
            this.btnVerClases.Text = "Consultar Clases";
            this.btnVerClases.UseVisualStyleBackColor = true;
            // 
            // MemberDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblInfoMiembro);
            this.Controls.Add(this.dgvReservas);
            this.Controls.Add(this.btnCancelarReserva);
            this.Controls.Add(this.btnReservar);
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
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.Button btnVerClases;
    }
}