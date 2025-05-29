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
            ((System.ComponentModel.ISupportInitialize)(this.dgvMiembros)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMiembros
            // 
            this.dgvMiembros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMiembros.Location = new System.Drawing.Point(198, 131);
            this.dgvMiembros.Name = "dgvMiembros";
            this.dgvMiembros.Size = new System.Drawing.Size(240, 150);
            this.dgvMiembros.TabIndex = 0;
            // 
            // MiembrosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvMiembros);
            this.Name = "MiembrosForm";
            this.Text = "MiembrosForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMiembros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMiembros;
    }
}