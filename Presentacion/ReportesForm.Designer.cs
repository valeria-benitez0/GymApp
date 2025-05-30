namespace GymApp.Presentacion
{
    partial class ReportesForm
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
            this.btnVerNotificaciones = new System.Windows.Forms.Button();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            this.dgvNotificaciones = new System.Windows.Forms.DataGridView();
            this.dgvReporteAsistencia = new System.Windows.Forms.DataGridView();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotificaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteAsistencia)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVerNotificaciones
            // 
            this.btnVerNotificaciones.Location = new System.Drawing.Point(75, 269);
            this.btnVerNotificaciones.Name = "btnVerNotificaciones";
            this.btnVerNotificaciones.Size = new System.Drawing.Size(75, 23);
            this.btnVerNotificaciones.TabIndex = 19;
            this.btnVerNotificaciones.Text = "Ver notificaciones";
            this.btnVerNotificaciones.UseVisualStyleBackColor = true;
            this.btnVerNotificaciones.Click += new System.EventHandler(this.btnVerNotificaciones_Click_1);
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.Location = new System.Drawing.Point(75, 217);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(75, 23);
            this.btnGenerarReporte.TabIndex = 18;
            this.btnGenerarReporte.Text = "Resporte";
            this.btnGenerarReporte.UseVisualStyleBackColor = true;
            this.btnGenerarReporte.Click += new System.EventHandler(this.btnGenerarReporte_Click_1);
            // 
            // dgvNotificaciones
            // 
            this.dgvNotificaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotificaciones.Location = new System.Drawing.Point(474, 267);
            this.dgvNotificaciones.Name = "dgvNotificaciones";
            this.dgvNotificaciones.Size = new System.Drawing.Size(240, 150);
            this.dgvNotificaciones.TabIndex = 16;
            // 
            // dgvReporteAsistencia
            // 
            this.dgvReporteAsistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReporteAsistencia.Location = new System.Drawing.Point(458, 61);
            this.dgvReporteAsistencia.Name = "dgvReporteAsistencia";
            this.dgvReporteAsistencia.Size = new System.Drawing.Size(240, 150);
            this.dgvReporteAsistencia.TabIndex = 15;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Location = new System.Drawing.Point(61, 112);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaFin.TabIndex = 14;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(61, 61);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaInicio.TabIndex = 13;
            // 
            // ReportesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVerNotificaciones);
            this.Controls.Add(this.btnGenerarReporte);
            this.Controls.Add(this.dgvNotificaciones);
            this.Controls.Add(this.dgvReporteAsistencia);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.dtpFechaInicio);
            this.Name = "ReportesForm";
            this.Text = "ReportesForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotificaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteAsistencia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVerNotificaciones;
        private System.Windows.Forms.Button btnGenerarReporte;
        private System.Windows.Forms.DataGridView dgvNotificaciones;
        private System.Windows.Forms.DataGridView dgvReporteAsistencia;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
    }
}