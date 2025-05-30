namespace GymApp.Presentacion
{
    partial class EntrenadoresForm
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
            this.dgvEntrenadores = new System.Windows.Forms.DataGridView();
            this.btnNuevoEntrenador = new System.Windows.Forms.Button();
            this.btnEditarEntrenador = new System.Windows.Forms.Button();
            this.btnEliminarEntrenador = new System.Windows.Forms.Button();
            this.btnRefrescar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntrenadores)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEntrenadores
            // 
            this.dgvEntrenadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntrenadores.Location = new System.Drawing.Point(143, 89);
            this.dgvEntrenadores.MultiSelect = false;
            this.dgvEntrenadores.Name = "dgvEntrenadores";
            this.dgvEntrenadores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEntrenadores.Size = new System.Drawing.Size(495, 150);
            this.dgvEntrenadores.TabIndex = 0;
            // 
            // btnNuevoEntrenador
            // 
            this.btnNuevoEntrenador.Location = new System.Drawing.Point(114, 288);
            this.btnNuevoEntrenador.Name = "btnNuevoEntrenador";
            this.btnNuevoEntrenador.Size = new System.Drawing.Size(135, 23);
            this.btnNuevoEntrenador.TabIndex = 1;
            this.btnNuevoEntrenador.Text = "Nuevo Entrenador";
            this.btnNuevoEntrenador.UseVisualStyleBackColor = true;
            this.btnNuevoEntrenador.Click += new System.EventHandler(this.btnNuevoEntrenador_Click_1);
            // 
            // btnEditarEntrenador
            // 
            this.btnEditarEntrenador.Location = new System.Drawing.Point(114, 345);
            this.btnEditarEntrenador.Name = "btnEditarEntrenador";
            this.btnEditarEntrenador.Size = new System.Drawing.Size(135, 23);
            this.btnEditarEntrenador.TabIndex = 2;
            this.btnEditarEntrenador.Text = "Editar Entrenador";
            this.btnEditarEntrenador.UseVisualStyleBackColor = true;
            this.btnEditarEntrenador.Click += new System.EventHandler(this.btnEditarEntrenador_Click_1);
            // 
            // btnEliminarEntrenador
            // 
            this.btnEliminarEntrenador.Location = new System.Drawing.Point(330, 288);
            this.btnEliminarEntrenador.Name = "btnEliminarEntrenador";
            this.btnEliminarEntrenador.Size = new System.Drawing.Size(135, 23);
            this.btnEliminarEntrenador.TabIndex = 3;
            this.btnEliminarEntrenador.Text = "Eliminar Entrenador";
            this.btnEliminarEntrenador.UseVisualStyleBackColor = true;
            this.btnEliminarEntrenador.Click += new System.EventHandler(this.btnEliminarEntrenador_Click_1);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Location = new System.Drawing.Point(330, 345);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(135, 23);
            this.btnRefrescar.TabIndex = 4;
            this.btnRefrescar.Text = "Actualizar";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click_1);
            // 
            // EntrenadoresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.btnEliminarEntrenador);
            this.Controls.Add(this.btnEditarEntrenador);
            this.Controls.Add(this.btnNuevoEntrenador);
            this.Controls.Add(this.dgvEntrenadores);
            this.Name = "EntrenadoresForm";
            this.Text = "EntrenadoresForm";
            this.Load += new System.EventHandler(this.EntrenadoresForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntrenadores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEntrenadores;
        private System.Windows.Forms.Button btnNuevoEntrenador;
        private System.Windows.Forms.Button btnEditarEntrenador;
        private System.Windows.Forms.Button btnEliminarEntrenador;
        private System.Windows.Forms.Button btnRefrescar;
    }
}