namespace GymApp.Presentacion
{
    partial class ClaseNuevoForm
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNombreClase = new System.Windows.Forms.Label();
            this.lblHorario = new System.Windows.Forms.Label();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.lblEntrenador = new System.Windows.Forms.Label();
            this.dtpHorario = new System.Windows.Forms.DateTimePicker();
            this.numDuracion = new System.Windows.Forms.NumericUpDown();
            this.cmbEntrenador = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.lblCapacida = new System.Windows.Forms.Label();
            this.numCapacidad = new System.Windows.Forms.NumericUpDown();
            this.cmbNombreClase = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numDuracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCapacidad)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(343, 48);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(67, 13);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Nueva clase";
            // 
            // lblNombreClase
            // 
            this.lblNombreClase.AutoSize = true;
            this.lblNombreClase.Location = new System.Drawing.Point(104, 123);
            this.lblNombreClase.Name = "lblNombreClase";
            this.lblNombreClase.Size = new System.Drawing.Size(98, 13);
            this.lblNombreClase.TabIndex = 2;
            this.lblNombreClase.Text = "Nombre de la clase";
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Location = new System.Drawing.Point(104, 185);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(41, 13);
            this.lblHorario.TabIndex = 3;
            this.lblHorario.Text = "Horario";
            // 
            // lblDuracion
            // 
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.Location = new System.Drawing.Point(104, 241);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(50, 13);
            this.lblDuracion.TabIndex = 4;
            this.lblDuracion.Text = "Duración";
            // 
            // lblEntrenador
            // 
            this.lblEntrenador.AutoSize = true;
            this.lblEntrenador.Location = new System.Drawing.Point(104, 332);
            this.lblEntrenador.Name = "lblEntrenador";
            this.lblEntrenador.Size = new System.Drawing.Size(59, 13);
            this.lblEntrenador.TabIndex = 5;
            this.lblEntrenador.Text = "Entrenador";
            // 
            // dtpHorario
            // 
            this.dtpHorario.Location = new System.Drawing.Point(208, 178);
            this.dtpHorario.Name = "dtpHorario";
            this.dtpHorario.Size = new System.Drawing.Size(200, 20);
            this.dtpHorario.TabIndex = 7;
            // 
            // numDuracion
            // 
            this.numDuracion.Location = new System.Drawing.Point(208, 234);
            this.numDuracion.Name = "numDuracion";
            this.numDuracion.Size = new System.Drawing.Size(120, 20);
            this.numDuracion.TabIndex = 8;
            // 
            // cmbEntrenador
            // 
            this.cmbEntrenador.FormattingEnabled = true;
            this.cmbEntrenador.Location = new System.Drawing.Point(230, 332);
            this.cmbEntrenador.Name = "cmbEntrenador";
            this.cmbEntrenador.Size = new System.Drawing.Size(121, 21);
            this.cmbEntrenador.TabIndex = 9;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(107, 399);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(371, 364);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(16, 13);
            this.lblMensaje.TabIndex = 11;
            this.lblMensaje.Text = "...";
            // 
            // lblCapacida
            // 
            this.lblCapacida.AutoSize = true;
            this.lblCapacida.Location = new System.Drawing.Point(104, 289);
            this.lblCapacida.Name = "lblCapacida";
            this.lblCapacida.Size = new System.Drawing.Size(58, 13);
            this.lblCapacida.TabIndex = 12;
            this.lblCapacida.Text = "Capacidad";
            // 
            // numCapacidad
            // 
            this.numCapacidad.Location = new System.Drawing.Point(208, 282);
            this.numCapacidad.Name = "numCapacidad";
            this.numCapacidad.Size = new System.Drawing.Size(120, 20);
            this.numCapacidad.TabIndex = 13;
            // 
            // cmbNombreClase
            // 
            this.cmbNombreClase.FormattingEnabled = true;
            this.cmbNombreClase.Items.AddRange(new object[] {
            "Yoga",
            "Pilates",
            "Spinning"});
            this.cmbNombreClase.Location = new System.Drawing.Point(208, 115);
            this.cmbNombreClase.Name = "cmbNombreClase";
            this.cmbNombreClase.Size = new System.Drawing.Size(121, 21);
            this.cmbNombreClase.TabIndex = 14;
            // 
            // ClaseNuevoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbNombreClase);
            this.Controls.Add(this.numCapacidad);
            this.Controls.Add(this.lblCapacida);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cmbEntrenador);
            this.Controls.Add(this.numDuracion);
            this.Controls.Add(this.dtpHorario);
            this.Controls.Add(this.lblEntrenador);
            this.Controls.Add(this.lblDuracion);
            this.Controls.Add(this.lblHorario);
            this.Controls.Add(this.lblNombreClase);
            this.Controls.Add(this.lblTitulo);
            this.Name = "ClaseNuevoForm";
            this.Text = "ClaseNuevoForm";
            ((System.ComponentModel.ISupportInitialize)(this.numDuracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCapacidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNombreClase;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.Label lblEntrenador;
        private System.Windows.Forms.DateTimePicker dtpHorario;
        private System.Windows.Forms.NumericUpDown numDuracion;
        private System.Windows.Forms.ComboBox cmbEntrenador;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label lblCapacida;
        private System.Windows.Forms.NumericUpDown numCapacidad;
        private System.Windows.Forms.ComboBox cmbNombreClase;
    }
}