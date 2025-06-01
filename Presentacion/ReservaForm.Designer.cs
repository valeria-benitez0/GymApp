namespace GymApp.Presentacion
{
    partial class ReservaForm
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
            this.txtUsuarioID = new System.Windows.Forms.TextBox();
            this.btnCancelarReserva = new System.Windows.Forms.Button();
            this.dgvReservas = new System.Windows.Forms.DataGridView();
            this.lblFechaReserva = new System.Windows.Forms.Label();
            this.lblClases = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnRegistrarReserva = new System.Windows.Forms.Button();
            this.dtpFechaReserva = new System.Windows.Forms.DateTimePicker();
            this.cmbClases = new System.Windows.Forms.ComboBox();
            this.lblUsuarioID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsuarioID
            // 
            this.txtUsuarioID.Location = new System.Drawing.Point(276, 79);
            this.txtUsuarioID.Name = "txtUsuarioID";
            this.txtUsuarioID.Size = new System.Drawing.Size(100, 20);
            this.txtUsuarioID.TabIndex = 43;
            // 
            // btnCancelarReserva
            // 
            this.btnCancelarReserva.Location = new System.Drawing.Point(276, 300);
            this.btnCancelarReserva.Name = "btnCancelarReserva";
            this.btnCancelarReserva.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarReserva.TabIndex = 42;
            this.btnCancelarReserva.Text = "Cancelar";
            this.btnCancelarReserva.UseVisualStyleBackColor = true;
            this.btnCancelarReserva.Click += new System.EventHandler(this.btnCancelarReserva_Click);
            // 
            // dgvReservas
            // 
            this.dgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservas.Location = new System.Drawing.Point(417, 260);
            this.dgvReservas.Name = "dgvReservas";
            this.dgvReservas.Size = new System.Drawing.Size(240, 150);
            this.dgvReservas.TabIndex = 41;
            // 
            // lblFechaReserva
            // 
            this.lblFechaReserva.AutoSize = true;
            this.lblFechaReserva.Location = new System.Drawing.Point(143, 187);
            this.lblFechaReserva.Name = "lblFechaReserva";
            this.lblFechaReserva.Size = new System.Drawing.Size(129, 13);
            this.lblFechaReserva.TabIndex = 40;
            this.lblFechaReserva.Text = "Fecha y Hora de Reserva";
            // 
            // lblClases
            // 
            this.lblClases.AutoSize = true;
            this.lblClases.Location = new System.Drawing.Point(143, 137);
            this.lblClases.Name = "lblClases";
            this.lblClases.Size = new System.Drawing.Size(99, 13);
            this.lblClases.TabIndex = 39;
            this.lblClases.Text = "Seleccione la clase";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(276, 41);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(83, 13);
            this.lblTitulo.TabIndex = 38;
            this.lblTitulo.Text = "Realizar reserva";
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(276, 356);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(16, 13);
            this.lblMensaje.TabIndex = 37;
            this.lblMensaje.Text = "...";
            // 
            // btnRegistrarReserva
            // 
            this.btnRegistrarReserva.Location = new System.Drawing.Point(279, 260);
            this.btnRegistrarReserva.Name = "btnRegistrarReserva";
            this.btnRegistrarReserva.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrarReserva.TabIndex = 36;
            this.btnRegistrarReserva.Text = "Reservar";
            this.btnRegistrarReserva.UseVisualStyleBackColor = true;
            this.btnRegistrarReserva.Click += new System.EventHandler(this.btnRegistrarReserva_Click);
            // 
            // dtpFechaReserva
            // 
            this.dtpFechaReserva.Location = new System.Drawing.Point(288, 187);
            this.dtpFechaReserva.Name = "dtpFechaReserva";
            this.dtpFechaReserva.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaReserva.TabIndex = 35;
            // 
            // cmbClases
            // 
            this.cmbClases.FormattingEnabled = true;
            this.cmbClases.Location = new System.Drawing.Point(276, 129);
            this.cmbClases.Name = "cmbClases";
            this.cmbClases.Size = new System.Drawing.Size(121, 21);
            this.cmbClases.TabIndex = 34;
            // 
            // lblUsuarioID
            // 
            this.lblUsuarioID.AutoSize = true;
            this.lblUsuarioID.Location = new System.Drawing.Point(143, 79);
            this.lblUsuarioID.Name = "lblUsuarioID";
            this.lblUsuarioID.Size = new System.Drawing.Size(99, 13);
            this.lblUsuarioID.TabIndex = 44;
            this.lblUsuarioID.Text = "Seleccione la clase";
            // 
            // ReservaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblUsuarioID);
            this.Controls.Add(this.txtUsuarioID);
            this.Controls.Add(this.btnCancelarReserva);
            this.Controls.Add(this.dgvReservas);
            this.Controls.Add(this.lblFechaReserva);
            this.Controls.Add(this.lblClases);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.btnRegistrarReserva);
            this.Controls.Add(this.dtpFechaReserva);
            this.Controls.Add(this.cmbClases);
            this.Name = "ReservaForm";
            this.Text = "ReservaForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuarioID;
        private System.Windows.Forms.Button btnCancelarReserva;
        private System.Windows.Forms.DataGridView dgvReservas;
        private System.Windows.Forms.Label lblFechaReserva;
        private System.Windows.Forms.Label lblClases;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnRegistrarReserva;
        private System.Windows.Forms.DateTimePicker dtpFechaReserva;
        private System.Windows.Forms.ComboBox cmbClases;
        private System.Windows.Forms.Label lblUsuarioID;
    }
}