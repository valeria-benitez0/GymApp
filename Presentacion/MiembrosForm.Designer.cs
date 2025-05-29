namespace GymApp.Presentacion
{
    partial class MiembrosForm
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
            this.dgvMiembros = new System.Windows.Forms.DataGridView();
            this.btnNuevoMiembro = new System.Windows.Forms.Button();
            this.btnEditarMiembro = new System.Windows.Forms.Button();
            this.btnEliminarMiembro = new System.Windows.Forms.Button();
            this.btnRefrescar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMiembros)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMiembros
            // 
            this.dgvMiembros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMiembros.Location = new System.Drawing.Point(42, 223);
            this.dgvMiembros.MultiSelect = false;
            this.dgvMiembros.Name = "dgvMiembros";
            this.dgvMiembros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMiembros.Size = new System.Drawing.Size(683, 174);
            this.dgvMiembros.TabIndex = 0;
            this.dgvMiembros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMiembros_CellContentClick);
            // 
            // btnNuevoMiembro
            // 
            this.btnNuevoMiembro.Location = new System.Drawing.Point(73, 63);
            this.btnNuevoMiembro.Name = "btnNuevoMiembro";
            this.btnNuevoMiembro.Size = new System.Drawing.Size(121, 23);
            this.btnNuevoMiembro.TabIndex = 1;
            this.btnNuevoMiembro.Text = "Nuevo miembro";
            this.btnNuevoMiembro.UseVisualStyleBackColor = true;
            this.btnNuevoMiembro.Click += new System.EventHandler(this.btnNuevoMiembro_Click_1);
            // 
            // btnEditarMiembro
            // 
            this.btnEditarMiembro.Location = new System.Drawing.Point(73, 114);
            this.btnEditarMiembro.Name = "btnEditarMiembro";
            this.btnEditarMiembro.Size = new System.Drawing.Size(121, 23);
            this.btnEditarMiembro.TabIndex = 2;
            this.btnEditarMiembro.Text = "Editar Miembro";
            this.btnEditarMiembro.UseVisualStyleBackColor = true;
            this.btnEditarMiembro.Click += new System.EventHandler(this.btnEditarMiembro_Click_1);
            // 
            // btnEliminarMiembro
            // 
            this.btnEliminarMiembro.Location = new System.Drawing.Point(73, 165);
            this.btnEliminarMiembro.Name = "btnEliminarMiembro";
            this.btnEliminarMiembro.Size = new System.Drawing.Size(121, 23);
            this.btnEliminarMiembro.TabIndex = 3;
            this.btnEliminarMiembro.Text = "Eliminar Miembro";
            this.btnEliminarMiembro.UseVisualStyleBackColor = true;
            this.btnEliminarMiembro.Click += new System.EventHandler(this.btnEliminarMiembro_Click_1);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Location = new System.Drawing.Point(264, 165);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(121, 23);
            this.btnRefrescar.TabIndex = 4;
            this.btnRefrescar.Text = "Actualizar";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click_1);
            // 
            // MiembrosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.btnEliminarMiembro);
            this.Controls.Add(this.btnEditarMiembro);
            this.Controls.Add(this.btnNuevoMiembro);
            this.Controls.Add(this.dgvMiembros);
            this.Name = "MiembrosForm";
            this.Text = "MiembrosForm";
            this.Load += new System.EventHandler(this.MiembrosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMiembros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMiembros;
        private System.Windows.Forms.Button btnNuevoMiembro;
        private System.Windows.Forms.Button btnEditarMiembro;
        private System.Windows.Forms.Button btnEliminarMiembro;
        private System.Windows.Forms.Button btnRefrescar;
    }
}