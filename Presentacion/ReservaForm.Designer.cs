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
            this.cmbClases = new System.Windows.Forms.ComboBox();
            this.dtpFechaReserva = new System.Windows.Forms.DateTimePicker();
            this.btnReservar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbClases
            // 
            this.cmbClases.FormattingEnabled = true;
            this.cmbClases.Location = new System.Drawing.Point(209, 97);
            this.cmbClases.Name = "cmbClases";
            this.cmbClases.Size = new System.Drawing.Size(121, 21);
            this.cmbClases.TabIndex = 0;
            // 
            // dtpFechaReserva
            // 
            this.dtpFechaReserva.Location = new System.Drawing.Point(209, 176);
            this.dtpFechaReserva.Name = "dtpFechaReserva";
            this.dtpFechaReserva.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaReserva.TabIndex = 1;
            // 
            // btnReservar
            // 
            this.btnReservar.Location = new System.Drawing.Point(209, 260);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(75, 23);
            this.btnReservar.TabIndex = 2;
            this.btnReservar.Text = "button1";
            this.btnReservar.UseVisualStyleBackColor = true;
            // 
            // ReservaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReservar);
            this.Controls.Add(this.dtpFechaReserva);
            this.Controls.Add(this.cmbClases);
            this.Name = "ReservaForm";
            this.Text = "ReservaForm";
            this.Load += new System.EventHandler(this.ReservaForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbClases;
        private System.Windows.Forms.DateTimePicker dtpFechaReserva;
        private System.Windows.Forms.Button btnReservar;
    }
}