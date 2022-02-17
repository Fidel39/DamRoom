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
            this.btAtras = new System.Windows.Forms.Button();
            this.btBuscar = new System.Windows.Forms.Button();
            this.dtFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtFechaIni = new System.Windows.Forms.DateTimePicker();
            this.listViewReservas = new System.Windows.Forms.ListView();
            this.tbImporte = new System.Windows.Forms.TextBox();
            this.tbHabi = new System.Windows.Forms.TextBox();
            this.tbDNICli = new System.Windows.Forms.TextBox();
            this.btDniCli = new System.Windows.Forms.Button();
            this.btHabi = new System.Windows.Forms.Button();
            this.btFechaIni = new System.Windows.Forms.Button();
            this.btFechaFin = new System.Windows.Forms.Button();
            this.btImporte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btAtras
            // 
            this.btAtras.FlatAppearance.BorderSize = 0;
            this.btAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAtras.Image = global::proyectoFinal.Properties.Resources.X;
            this.btAtras.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btAtras.Location = new System.Drawing.Point(239, 393);
            this.btAtras.Name = "btAtras";
            this.btAtras.Size = new System.Drawing.Size(75, 23);
            this.btAtras.TabIndex = 33;
            this.btAtras.Text = "Atras";
            this.btAtras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAtras.UseVisualStyleBackColor = true;
            this.btAtras.Click += new System.EventHandler(this.btAtras_Click);
            // 
            // btBuscar
            // 
            this.btBuscar.FlatAppearance.BorderSize = 0;
            this.btBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBuscar.Image = global::proyectoFinal.Properties.Resources.lupa1;
            this.btBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btBuscar.Location = new System.Drawing.Point(20, 393);
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
            this.dtFechaFin.Location = new System.Drawing.Point(114, 185);
            this.dtFechaFin.Name = "dtFechaFin";
            this.dtFechaFin.Size = new System.Drawing.Size(200, 20);
            this.dtFechaFin.TabIndex = 27;
            // 
            // dtFechaIni
            // 
            this.dtFechaIni.Location = new System.Drawing.Point(114, 140);
            this.dtFechaIni.Name = "dtFechaIni";
            this.dtFechaIni.Size = new System.Drawing.Size(200, 20);
            this.dtFechaIni.TabIndex = 26;
            // 
            // listViewReservas
            // 
            this.listViewReservas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewReservas.HideSelection = false;
            this.listViewReservas.Location = new System.Drawing.Point(365, 51);
            this.listViewReservas.Name = "listViewReservas";
            this.listViewReservas.Size = new System.Drawing.Size(270, 365);
            this.listViewReservas.TabIndex = 25;
            this.listViewReservas.UseCompatibleStateImageBehavior = false;
            // 
            // tbImporte
            // 
            this.tbImporte.Location = new System.Drawing.Point(114, 231);
            this.tbImporte.Name = "tbImporte";
            this.tbImporte.Size = new System.Drawing.Size(200, 20);
            this.tbImporte.TabIndex = 24;
            // 
            // tbHabi
            // 
            this.tbHabi.Location = new System.Drawing.Point(114, 94);
            this.tbHabi.Name = "tbHabi";
            this.tbHabi.Size = new System.Drawing.Size(200, 20);
            this.tbHabi.TabIndex = 20;
            // 
            // tbDNICli
            // 
            this.tbDNICli.Location = new System.Drawing.Point(114, 51);
            this.tbDNICli.Name = "tbDNICli";
            this.tbDNICli.Size = new System.Drawing.Size(200, 20);
            this.tbDNICli.TabIndex = 18;
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
            // btHabi
            // 
            this.btHabi.Location = new System.Drawing.Point(20, 94);
            this.btHabi.Name = "btHabi";
            this.btHabi.Size = new System.Drawing.Size(75, 23);
            this.btHabi.TabIndex = 35;
            this.btHabi.Text = "Habitacion:";
            this.btHabi.UseVisualStyleBackColor = true;
            this.btHabi.Click += new System.EventHandler(this.btHabi_Click);
            // 
            // btFechaIni
            // 
            this.btFechaIni.Location = new System.Drawing.Point(20, 140);
            this.btFechaIni.Name = "btFechaIni";
            this.btFechaIni.Size = new System.Drawing.Size(75, 23);
            this.btFechaIni.TabIndex = 36;
            this.btFechaIni.Text = "Fecha inicio:";
            this.btFechaIni.UseVisualStyleBackColor = true;
            this.btFechaIni.Click += new System.EventHandler(this.btFechaIni_Click);
            // 
            // btFechaFin
            // 
            this.btFechaFin.Location = new System.Drawing.Point(20, 182);
            this.btFechaFin.Name = "btFechaFin";
            this.btFechaFin.Size = new System.Drawing.Size(75, 23);
            this.btFechaFin.TabIndex = 37;
            this.btFechaFin.Text = "Fecha fin:";
            this.btFechaFin.UseVisualStyleBackColor = true;
            this.btFechaFin.Click += new System.EventHandler(this.btFechaFin_Click);
            // 
            // btImporte
            // 
            this.btImporte.Location = new System.Drawing.Point(20, 227);
            this.btImporte.Name = "btImporte";
            this.btImporte.Size = new System.Drawing.Size(75, 23);
            this.btImporte.TabIndex = 38;
            this.btImporte.Text = "Importe:";
            this.btImporte.UseVisualStyleBackColor = true;
            this.btImporte.Click += new System.EventHandler(this.btImporte_Click);
            // 
            // conReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 522);
            this.Controls.Add(this.btImporte);
            this.Controls.Add(this.btFechaFin);
            this.Controls.Add(this.btFechaIni);
            this.Controls.Add(this.btHabi);
            this.Controls.Add(this.btDniCli);
            this.Controls.Add(this.btAtras);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.dtFechaFin);
            this.Controls.Add(this.dtFechaIni);
            this.Controls.Add(this.listViewReservas);
            this.Controls.Add(this.tbImporte);
            this.Controls.Add(this.tbHabi);
            this.Controls.Add(this.tbDNICli);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "conReservas";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.conReservas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAtras;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.DateTimePicker dtFechaFin;
        private System.Windows.Forms.DateTimePicker dtFechaIni;
        private System.Windows.Forms.ListView listViewReservas;
        private System.Windows.Forms.TextBox tbImporte;
        private System.Windows.Forms.TextBox tbHabi;
        private System.Windows.Forms.TextBox tbDNICli;
        private System.Windows.Forms.Button btDniCli;
        private System.Windows.Forms.Button btHabi;
        private System.Windows.Forms.Button btFechaIni;
        private System.Windows.Forms.Button btFechaFin;
        private System.Windows.Forms.Button btImporte;
    }
}