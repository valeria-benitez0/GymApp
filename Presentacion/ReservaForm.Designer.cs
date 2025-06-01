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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservaForm));
            this.txtUsuarioID = new System.Windows.Forms.TextBox();
            this.btnCancelarReserva = new System.Windows.Forms.Button();
            this.dgvReservas = new System.Windows.Forms.DataGridView();
            this.lblFechaReserva = new System.Windows.Forms.Label();
            this.lblClases = new System.Windows.Forms.Label();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnRegistrarReserva = new System.Windows.Forms.Button();
            this.dtpFechaReserva = new System.Windows.Forms.DateTimePicker();
            this.cmbClases = new System.Windows.Forms.ComboBox();
            this.lblUsuarioID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUsuarioID
            // 
            this.txtUsuarioID.Location = new System.Drawing.Point(176, 3);
            this.txtUsuarioID.Name = "txtUsuarioID";
            this.txtUsuarioID.Size = new System.Drawing.Size(100, 20);
            this.txtUsuarioID.TabIndex = 43;
            // 
            // btnCancelarReserva
            // 
            this.btnCancelarReserva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancelarReserva.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarReserva.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelarReserva.Location = new System.Drawing.Point(176, 132);
            this.btnCancelarReserva.Name = "btnCancelarReserva";
            this.btnCancelarReserva.Size = new System.Drawing.Size(100, 24);
            this.btnCancelarReserva.TabIndex = 42;
            this.btnCancelarReserva.Text = "Cancelar";
            this.btnCancelarReserva.UseVisualStyleBackColor = false;
            this.btnCancelarReserva.Click += new System.EventHandler(this.btnCancelarReserva_Click);
            // 
            // dgvReservas
            // 
            this.dgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservas.Location = new System.Drawing.Point(63, 219);
            this.dgvReservas.Name = "dgvReservas";
            this.dgvReservas.Size = new System.Drawing.Size(349, 129);
            this.dgvReservas.TabIndex = 41;
            // 
            // lblFechaReserva
            // 
            this.lblFechaReserva.AutoSize = true;
            this.lblFechaReserva.Location = new System.Drawing.Point(3, 58);
            this.lblFechaReserva.Name = "lblFechaReserva";
            this.lblFechaReserva.Size = new System.Drawing.Size(129, 13);
            this.lblFechaReserva.TabIndex = 40;
            this.lblFechaReserva.Text = "Fecha y Hora de Reserva";
            // 
            // lblClases
            // 
            this.lblClases.AutoSize = true;
            this.lblClases.Location = new System.Drawing.Point(3, 28);
            this.lblClases.Name = "lblClases";
            this.lblClases.Size = new System.Drawing.Size(99, 13);
            this.lblClases.TabIndex = 39;
            this.lblClases.Text = "Seleccione la clase";
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(3, 129);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(16, 13);
            this.lblMensaje.TabIndex = 37;
            this.lblMensaje.Text = "...";
            // 
            // btnRegistrarReserva
            // 
            this.btnRegistrarReserva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRegistrarReserva.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarReserva.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRegistrarReserva.Location = new System.Drawing.Point(176, 98);
            this.btnRegistrarReserva.Name = "btnRegistrarReserva";
            this.btnRegistrarReserva.Size = new System.Drawing.Size(99, 28);
            this.btnRegistrarReserva.TabIndex = 36;
            this.btnRegistrarReserva.Text = "Reservar";
            this.btnRegistrarReserva.UseVisualStyleBackColor = false;
            this.btnRegistrarReserva.Click += new System.EventHandler(this.btnRegistrarReserva_Click);
            // 
            // dtpFechaReserva
            // 
            this.dtpFechaReserva.Location = new System.Drawing.Point(176, 61);
            this.dtpFechaReserva.Name = "dtpFechaReserva";
            this.dtpFechaReserva.Size = new System.Drawing.Size(167, 20);
            this.dtpFechaReserva.TabIndex = 35;
            // 
            // cmbClases
            // 
            this.cmbClases.FormattingEnabled = true;
            this.cmbClases.Location = new System.Drawing.Point(176, 31);
            this.cmbClases.Name = "cmbClases";
            this.cmbClases.Size = new System.Drawing.Size(121, 21);
            this.cmbClases.TabIndex = 34;
            // 
            // lblUsuarioID
            // 
            this.lblUsuarioID.AutoSize = true;
            this.lblUsuarioID.Location = new System.Drawing.Point(3, 0);
            this.lblUsuarioID.Name = "lblUsuarioID";
            this.lblUsuarioID.Size = new System.Drawing.Size(99, 13);
            this.lblUsuarioID.TabIndex = 44;
            this.lblUsuarioID.Text = "Seleccione la clase";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.panel13);
            this.panel1.Controls.Add(this.panel11);
            this.panel1.Controls.Add(this.panel10);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.dgvReservas);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 369);
            this.panel1.TabIndex = 57;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.White;
            this.panel13.Location = new System.Drawing.Point(11, 121);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(19, 17);
            this.panel13.TabIndex = 51;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.White;
            this.panel11.Location = new System.Drawing.Point(11, 93);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(19, 17);
            this.panel11.TabIndex = 50;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.White;
            this.panel10.Location = new System.Drawing.Point(11, 67);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(19, 17);
            this.panel10.TabIndex = 50;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Location = new System.Drawing.Point(11, 43);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(19, 17);
            this.panel9.TabIndex = 49;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DarkGray;
            this.panel6.Controls.Add(this.panel12);
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(104, 30);
            this.panel6.TabIndex = 47;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.White;
            this.panel12.Location = new System.Drawing.Point(11, 21);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(19, 17);
            this.panel12.TabIndex = 50;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(435, 54);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(289, 193);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.BackColor = System.Drawing.Color.White;
            this.lblTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(101, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(349, 30);
            this.lblTitulo.TabIndex = 42;
            this.lblTitulo.Text = "Realizar reservas";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel16);
            this.panel2.Controls.Add(this.panel15);
            this.panel2.Location = new System.Drawing.Point(478, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(297, 366);
            this.panel2.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkGray;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Location = new System.Drawing.Point(79, 30);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(195, 270);
            this.panel5.TabIndex = 48;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.White;
            this.panel16.Location = new System.Drawing.Point(3, 318);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(19, 17);
            this.panel16.TabIndex = 50;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.White;
            this.panel15.Location = new System.Drawing.Point(28, 318);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(19, 17);
            this.panel15.TabIndex = 50;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(-3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(807, 82);
            this.panel3.TabIndex = 56;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel4.Controls.Add(this.pictureBox7);
            this.panel4.Controls.Add(this.pictureBox6);
            this.panel4.Controls.Add(this.pictureBox5);
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Location = new System.Drawing.Point(16, 14);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(774, 57);
            this.panel4.TabIndex = 29;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(606, 12);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(34, 28);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 32;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(646, 12);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(34, 28);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 31;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(686, 12);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(34, 28);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 30;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(726, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(36, 28);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 29;
            this.pictureBox4.TabStop = false;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(120, 12);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(165, 36);
            this.label9.TabIndex = 26;
            this.label9.Text = "Alpha Power Fit";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(114, 57);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Gainsboro;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnCancelarReserva, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblUsuarioID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtUsuarioID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblFechaReserva, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dtpFechaReserva, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblClases, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmbClases, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblMensaje, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnRegistrarReserva, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(66, 54);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.27586F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.72414F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(346, 159);
            this.tableLayoutPanel1.TabIndex = 52;
            // 
            // ReservaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "ReservaForm";
            this.Text = "ReservaForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuarioID;
        private System.Windows.Forms.Button btnCancelarReserva;
        private System.Windows.Forms.DataGridView dgvReservas;
        private System.Windows.Forms.Label lblFechaReserva;
        private System.Windows.Forms.Label lblClases;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnRegistrarReserva;
        private System.Windows.Forms.DateTimePicker dtpFechaReserva;
        private System.Windows.Forms.ComboBox cmbClases;
        private System.Windows.Forms.Label lblUsuarioID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}