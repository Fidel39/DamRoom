namespace proyectoFinal
{
    partial class conReservas
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
            this.btBuscar = new System.Windows.Forms.Button();
            this.dtFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtFechaIni = new System.Windows.Forms.DateTimePicker();
            this.tbImporte = new System.Windows.Forms.TextBox();
            this.btDniCli = new System.Windows.Forms.Button();
            this.btFechaIni = new System.Windows.Forms.Button();
            this.btFechaFin = new System.Windows.Forms.Button();
            this.btImporte = new System.Windows.Forms.Button();
            this.dgReserva = new System.Windows.Forms.DataGridView();
            this.idReserva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_fin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_ini = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.habitacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbDniCli = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgReserva)).BeginInit();
            this.SuspendLayout();
            // 
            // btBuscar
            // 
            this.btBuscar.FlatAppearance.BorderSize = 0;
            this.btBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBuscar.Image = global::proyectoFinal.Properties.Resources.lupa1;
            this.btBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btBuscar.Location = new System.Drawing.Point(239, 393);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(75, 23);
            this.btBuscar.TabIndex = 32;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // dtFechaFin
            // 
            this.dtFechaFin.Location = new System.Drawing.Point(114, 149);
            this.dtFechaFin.Name = "dtFechaFin";
            this.dtFechaFin.Size = new System.Drawing.Size(200, 20);
            this.dtFechaFin.TabIndex = 27;
            // 
            // dtFechaIni
            // 
            this.dtFechaIni.Location = new System.Drawing.Point(114, 99);
            this.dtFechaIni.Name = "dtFechaIni";
            this.dtFechaIni.Size = new System.Drawing.Size(200, 20);
            this.dtFechaIni.TabIndex = 26;
            // 
            // tbImporte
            // 
            this.tbImporte.Location = new System.Drawing.Point(114, 207);
            this.tbImporte.Name = "tbImporte";
            this.tbImporte.Size = new System.Drawing.Size(200, 20);
            this.tbImporte.TabIndex = 24;
            // 
            // btDniCli
            // 
            this.btDniCli.Location = new System.Drawing.Point(20, 49);
            this.btDniCli.Name = "btDniCli";
            this.btDniCli.Size = new System.Drawing.Size(75, 23);
            this.btDniCli.TabIndex = 34;
            this.btDniCli.Text = "DNI Cliente:";
            this.btDniCli.UseVisualStyleBackColor = true;
            this.btDniCli.Click += new System.EventHandler(this.btDniCli_Click);
            // 
            // btFechaIni
            // 
            this.btFechaIni.Location = new System.Drawing.Point(20, 96);
            this.btFechaIni.Name = "btFechaIni";
            this.btFechaIni.Size = new System.Drawing.Size(75, 23);
            this.btFechaIni.TabIndex = 36;
            this.btFechaIni.Text = "Fecha inicio:";
            this.btFechaIni.UseVisualStyleBackColor = true;
            this.btFechaIni.Click += new System.EventHandler(this.btFechaIni_Click);
            // 
            // btFechaFin
            // 
            this.btFechaFin.Location = new System.Drawing.Point(20, 146);
            this.btFechaFin.Name = "btFechaFin";
            this.btFechaFin.Size = new System.Drawing.Size(75, 23);
            this.btFechaFin.TabIndex = 37;
            this.btFechaFin.Text = "Fecha fin:";
            this.btFechaFin.UseVisualStyleBackColor = true;
            this.btFechaFin.Click += new System.EventHandler(this.btFechaFin_Click);
            // 
            // btImporte
            // 
            this.btImporte.Location = new System.Drawing.Point(20, 204);
            this.btImporte.Name = "btImporte";
            this.btImporte.Size = new System.Drawing.Size(75, 23);
            this.btImporte.TabIndex = 38;
            this.btImporte.Text = "Importe:";
            this.btImporte.UseVisualStyleBackColor = true;
            this.btImporte.Click += new System.EventHandler(this.btImporte_Click);
            // 
            // dgReserva
            // 
            this.dgReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReserva.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idReserva,
            this.dni_cliente,
            this.estado,
            this.fecha_fin,
            this.fecha_ini,
            this.importe,
            this.habitacion});
            this.dgReserva.Location = new System.Drawing.Point(346, 51);
            this.dgReserva.Name = "dgReserva";
            this.dgReserva.Size = new System.Drawing.Size(293, 365);
            this.dgReserva.TabIndex = 40;
            // 
            // idReserva
            // 
            this.idReserva.HeaderText = "idReserva";
            this.idReserva.Name = "idReserva";
            // 
            // dni_cliente
            // 
            this.dni_cliente.HeaderText = "DNI";
            this.dni_cliente.Name = "dni_cliente";
            // 
            // estado
            // 
            this.estado.HeaderText = "estado";
            this.estado.Name = "estado";
            // 
            // fecha_fin
            // 
            this.fecha_fin.HeaderText = "fechaFin";
            this.fecha_fin.Name = "fecha_fin";
            // 
            // fecha_ini
            // 
            this.fecha_ini.HeaderText = "fecha_ini";
            this.fecha_ini.Name = "fecha_ini";
            // 
            // importe
            // 
            this.importe.HeaderText = "importe";
            this.importe.Name = "importe";
            // 
            // habitacion
            // 
            this.habitacion.HeaderText = "habitacion";
            this.habitacion.Name = "habitacion";
            // 
            // cbDniCli
            // 
            this.cbDniCli.FormattingEnabled = true;
            this.cbDniCli.Location = new System.Drawing.Point(114, 49);
            this.cbDniCli.Name = "cbDniCli";
            this.cbDniCli.Size = new System.Drawing.Size(200, 21);
            this.cbDniCli.TabIndex = 41;
            this.cbDniCli.Text = "DNI Cliente";
            // 
            // conReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(668, 522);
            this.Controls.Add(this.cbDniCli);
            this.Controls.Add(this.dgReserva);
            this.Controls.Add(this.btImporte);
            this.Controls.Add(this.btFechaFin);
            this.Controls.Add(this.btFechaIni);
            this.Controls.Add(this.btDniCli);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.dtFechaFin);
            this.Controls.Add(this.dtFechaIni);
            this.Controls.Add(this.tbImporte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "conReservas";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.conReservas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgReserva)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.DateTimePicker dtFechaFin;
        private System.Windows.Forms.DateTimePicker dtFechaIni;
        private System.Windows.Forms.TextBox tbImporte;
        private System.Windows.Forms.Button btDniCli;
        private System.Windows.Forms.Button btFechaIni;
        private System.Windows.Forms.Button btFechaFin;
        private System.Windows.Forms.Button btImporte;
        private System.Windows.Forms.DataGridView dgReserva;
        private System.Windows.Forms.DataGridViewTextBoxColumn idReserva;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_fin;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_ini;
        private System.Windows.Forms.DataGridViewTextBoxColumn importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn habitacion;
        private System.Windows.Forms.ComboBox cbDniCli;
    }
}