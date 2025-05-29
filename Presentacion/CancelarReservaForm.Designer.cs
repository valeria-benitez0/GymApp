namespace GymApp.Presentacion
{
    partial class CancelarReservaForm
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
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnCancelarReserva = new System.Windows.Forms.Button();
            this.dgvReservas = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.ReservaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaReserva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClaseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRefrescar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(58, 308);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(16, 13);
            this.lblMensaje.TabIndex = 5;
            this.lblMensaje.Text = "...";
            // 
            // btnCancelarReserva
            // 
            this.btnCancelarReserva.Location = new System.Drawing.Point(61, 341);
            this.btnCancelarReserva.Name = "btnCancelarReserva";
            this.btnCancelarReserva.Size = new System.Drawing.Size(155, 23);
            this.btnCancelarReserva.TabIndex = 4;
            this.btnCancelarReserva.Text = "Cancelar reserva";
            this.btnCancelarReserva.UseVisualStyleBackColor = true;
            this.btnCancelarReserva.Click += new System.EventHandler(this.btnCancelarReserva_Click_1);
            // 
            // dgvReservas
            // 
            this.dgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ReservaID,
            this.FechaReserva,
            this.Estado,
            this.ClaseID});
            this.dgvReservas.Location = new System.Drawing.Point(61, 134);
            this.dgvReservas.Name = "dgvReservas";
            this.dgvReservas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReservas.Size = new System.Drawing.Size(436, 150);
            this.dgvReservas.TabIndex = 3;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(289, 42);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(92, 13);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Cancelar Reserva";
            // 
            // ReservaID
            // 
            this.ReservaID.HeaderText = "ID Reserva";
            this.ReservaID.Name = "ReservaID";
            // 
            // FechaReserva
            // 
            this.FechaReserva.HeaderText = "Fecha Reserva";
            this.FechaReserva.Name = "FechaReserva";
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // ClaseID
            // 
            this.ClaseID.HeaderText = "ID clase";
            this.ClaseID.Name = "ClaseID";
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Location = new System.Drawing.Point(267, 341);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(155, 23);
            this.btnRefrescar.TabIndex = 7;
            this.btnRefrescar.Text = "Actualizar";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click_1);
            // 
            // CancelarReservaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.btnCancelarReserva);
            this.Controls.Add(this.dgvReservas);
            this.Name = "CancelarReservaForm";
            this.Text = "CancelarReservaForm";
            this.Load += new System.EventHandler(this.CancelarReservaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnCancelarReserva;
        private System.Windows.Forms.DataGridView dgvReservas;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReservaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaReserva;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClaseID;
        private System.Windows.Forms.Button btnRefrescar;
    }
}