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
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnReservar = new System.Windows.Forms.Button();
            this.dtpFechaReserva = new System.Windows.Forms.DateTimePicker();
            this.cmbClases = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(300, 343);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(35, 13);
            this.lblMensaje.TabIndex = 7;
            this.lblMensaje.Text = "label1";
            // 
            // btnReservar
            // 
            this.btnReservar.Location = new System.Drawing.Point(300, 258);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(75, 23);
            this.btnReservar.TabIndex = 6;
            this.btnReservar.Text = "button1";
            this.btnReservar.UseVisualStyleBackColor = true;
            // 
            // dtpFechaReserva
            // 
            this.dtpFechaReserva.Location = new System.Drawing.Point(300, 174);
            this.dtpFechaReserva.Name = "dtpFechaReserva";
            this.dtpFechaReserva.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaReserva.TabIndex = 5;
            // 
            // cmbClases
            // 
            this.cmbClases.FormattingEnabled = true;
            this.cmbClases.Location = new System.Drawing.Point(300, 95);
            this.cmbClases.Name = "cmbClases";
            this.cmbClases.Size = new System.Drawing.Size(121, 21);
            this.cmbClases.TabIndex = 4;
            // 
            // ReservaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.btnReservar);
            this.Controls.Add(this.dtpFechaReserva);
            this.Controls.Add(this.cmbClases);
            this.Name = "ReservaForm";
            this.Text = "ReservaForm";
            this.Load += new System.EventHandler(this.ReservaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.DateTimePicker dtpFechaReserva;
        private System.Windows.Forms.ComboBox cmbClases;
    }
}