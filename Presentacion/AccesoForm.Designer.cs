namespace GymApp.Presentacion
{
    partial class AccesoForm
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
            this.txtClaseID = new System.Windows.Forms.TextBox();
            this.cmbEstadoAcceso = new System.Windows.Forms.ComboBox();
            this.btnRegistrarAcceso = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUsuarioID
            // 
            this.txtUsuarioID.Location = new System.Drawing.Point(295, 71);
            this.txtUsuarioID.Name = "txtUsuarioID";
            this.txtUsuarioID.Size = new System.Drawing.Size(100, 20);
            this.txtUsuarioID.TabIndex = 0;
            // 
            // txtClaseID
            // 
            this.txtClaseID.Location = new System.Drawing.Point(295, 122);
            this.txtClaseID.Name = "txtClaseID";
            this.txtClaseID.Size = new System.Drawing.Size(100, 20);
            this.txtClaseID.TabIndex = 1;
            // 
            // cmbEstadoAcceso
            // 
            this.cmbEstadoAcceso.FormattingEnabled = true;
            this.cmbEstadoAcceso.Location = new System.Drawing.Point(295, 177);
            this.cmbEstadoAcceso.Name = "cmbEstadoAcceso";
            this.cmbEstadoAcceso.Size = new System.Drawing.Size(121, 21);
            this.cmbEstadoAcceso.TabIndex = 2;
            // 
            // btnRegistrarAcceso
            // 
            this.btnRegistrarAcceso.Location = new System.Drawing.Point(309, 331);
            this.btnRegistrarAcceso.Name = "btnRegistrarAcceso";
            this.btnRegistrarAcceso.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrarAcceso.TabIndex = 7;
            this.btnRegistrarAcceso.Text = "Acceso";
            this.btnRegistrarAcceso.UseVisualStyleBackColor = true;
            // 
            // AccesoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegistrarAcceso);
            this.Controls.Add(this.cmbEstadoAcceso);
            this.Controls.Add(this.txtClaseID);
            this.Controls.Add(this.txtUsuarioID);
            this.Name = "AccesoForm";
            this.Text = "AccesoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuarioID;
        private System.Windows.Forms.TextBox txtClaseID;
        private System.Windows.Forms.ComboBox cmbEstadoAcceso;
        private System.Windows.Forms.Button btnRegistrarAcceso;
    }
}