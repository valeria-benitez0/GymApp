namespace GymApp.Presentacion
{
    partial class ClasesForm
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
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.btnEliminarClase = new System.Windows.Forms.Button();
            this.btnEditarClase = new System.Windows.Forms.Button();
            this.btnNuevaClase = new System.Windows.Forms.Button();
            this.dgvClases = new System.Windows.Forms.DataGridView();
            this.ClaseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreClase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Horario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CapacidadMaxima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreEntrenador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClases)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Location = new System.Drawing.Point(426, 303);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(87, 23);
            this.btnRefrescar.TabIndex = 9;
            this.btnRefrescar.Text = "Actualizar";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            // 
            // btnEliminarClase
            // 
            this.btnEliminarClase.Location = new System.Drawing.Point(426, 250);
            this.btnEliminarClase.Name = "btnEliminarClase";
            this.btnEliminarClase.Size = new System.Drawing.Size(96, 23);
            this.btnEliminarClase.TabIndex = 8;
            this.btnEliminarClase.Text = "Eliminar clase";
            this.btnEliminarClase.UseVisualStyleBackColor = true;
            // 
            // btnEditarClase
            // 
            this.btnEditarClase.Location = new System.Drawing.Point(273, 304);
            this.btnEditarClase.Name = "btnEditarClase";
            this.btnEditarClase.Size = new System.Drawing.Size(75, 23);
            this.btnEditarClase.TabIndex = 7;
            this.btnEditarClase.Text = "Editar clase";
            this.btnEditarClase.UseVisualStyleBackColor = true;
            // 
            // btnNuevaClase
            // 
            this.btnNuevaClase.Location = new System.Drawing.Point(273, 251);
            this.btnNuevaClase.Name = "btnNuevaClase";
            this.btnNuevaClase.Size = new System.Drawing.Size(91, 23);
            this.btnNuevaClase.TabIndex = 6;
            this.btnNuevaClase.Text = "Nueva clase";
            this.btnNuevaClase.UseVisualStyleBackColor = true;
            // 
            // dgvClases
            // 
            this.dgvClases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClases.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClaseID,
            this.NombreClase,
            this.Horario,
            this.Duracion,
            this.CapacidadMaxima,
            this.NombreEntrenador});
            this.dgvClases.Location = new System.Drawing.Point(86, 60);
            this.dgvClases.MultiSelect = false;
            this.dgvClases.Name = "dgvClases";
            this.dgvClases.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClases.Size = new System.Drawing.Size(642, 150);
            this.dgvClases.TabIndex = 5;
            // 
            // ClaseID
            // 
            this.ClaseID.HeaderText = "ID Clase";
            this.ClaseID.Name = "ClaseID";
            // 
            // NombreClase
            // 
            this.NombreClase.HeaderText = "Nombre";
            this.NombreClase.Name = "NombreClase";
            // 
            // Horario
            // 
            this.Horario.HeaderText = "Horario";
            this.Horario.Name = "Horario";
            // 
            // Duracion
            // 
            this.Duracion.HeaderText = "Duración";
            this.Duracion.Name = "Duracion";
            // 
            // CapacidadMaxima
            // 
            this.CapacidadMaxima.HeaderText = "Capacidad Máxima";
            this.CapacidadMaxima.Name = "CapacidadMaxima";
            // 
            // NombreEntrenador
            // 
            this.NombreEntrenador.HeaderText = "Nombre Entrenador";
            this.NombreEntrenador.Name = "NombreEntrenador";
            // 
            // ClasesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.btnEliminarClase);
            this.Controls.Add(this.btnEditarClase);
            this.Controls.Add(this.btnNuevaClase);
            this.Controls.Add(this.dgvClases);
            this.Name = "ClasesForm";
            this.Text = "ClasesForm";
            this.Load += new System.EventHandler(this.ClasesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClases)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Button btnEliminarClase;
        private System.Windows.Forms.Button btnEditarClase;
        private System.Windows.Forms.Button btnNuevaClase;
        private System.Windows.Forms.DataGridView dgvClases;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClaseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreClase;
        private System.Windows.Forms.DataGridViewTextBoxColumn Horario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CapacidadMaxima;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreEntrenador;
    }
}