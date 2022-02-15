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
            this.listView1 = new System.Windows.Forms.ListView();
            this.tbImporte = new System.Windows.Forms.TextBox();
            this.labImporte = new System.Windows.Forms.Label();
            this.labFechFin = new System.Windows.Forms.Label();
            this.labFechIni = new System.Windows.Forms.Label();
            this.tbHabi = new System.Windows.Forms.TextBox();
            this.labHabit = new System.Windows.Forms.Label();
            this.tbDNICli = new System.Windows.Forms.TextBox();
            this.btDniCli = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btAtras
            // 
            this.btAtras.Location = new System.Drawing.Point(239, 393);
            this.btAtras.Name = "btAtras";
            this.btAtras.Size = new System.Drawing.Size(75, 23);
            this.btAtras.TabIndex = 33;
            this.btAtras.Text = "Atras";
            this.btAtras.UseVisualStyleBackColor = true;
            this.btAtras.Click += new System.EventHandler(this.btAtras_Click);
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(32, 393);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(75, 23);
            this.btBuscar.TabIndex = 32;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            // 
            // dtFechaFin
            // 
            this.dtFechaFin.Enabled = false;
            this.dtFechaFin.Location = new System.Drawing.Point(114, 185);
            this.dtFechaFin.Name = "dtFechaFin";
            this.dtFechaFin.Size = new System.Drawing.Size(200, 20);
            this.dtFechaFin.TabIndex = 27;
            // 
            // dtFechaIni
            // 
            this.dtFechaIni.Enabled = false;
            this.dtFechaIni.Location = new System.Drawing.Point(114, 140);
            this.dtFechaIni.Name = "dtFechaIni";
            this.dtFechaIni.Size = new System.Drawing.Size(200, 20);
            this.dtFechaIni.TabIndex = 26;
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(365, 51);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(270, 365);
            this.listView1.TabIndex = 25;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // tbImporte
            // 
            this.tbImporte.Enabled = false;
            this.tbImporte.Location = new System.Drawing.Point(114, 223);
            this.tbImporte.Name = "tbImporte";
            this.tbImporte.Size = new System.Drawing.Size(200, 20);
            this.tbImporte.TabIndex = 24;
            // 
            // labImporte
            // 
            this.labImporte.AutoSize = true;
            this.labImporte.Location = new System.Drawing.Point(29, 226);
            this.labImporte.Name = "labImporte";
            this.labImporte.Size = new System.Drawing.Size(45, 13);
            this.labImporte.TabIndex = 23;
            this.labImporte.Text = "Importe:";
            // 
            // labFechFin
            // 
            this.labFechFin.AutoSize = true;
            this.labFechFin.Location = new System.Drawing.Point(26, 185);
            this.labFechFin.Name = "labFechFin";
            this.labFechFin.Size = new System.Drawing.Size(69, 13);
            this.labFechFin.TabIndex = 22;
            this.labFechFin.Text = "Fecha de fin:";
            // 
            // labFechIni
            // 
            this.labFechIni.AutoSize = true;
            this.labFechIni.Location = new System.Drawing.Point(26, 140);
            this.labFechIni.Name = "labFechIni";
            this.labFechIni.Size = new System.Drawing.Size(82, 13);
            this.labFechIni.TabIndex = 21;
            this.labFechIni.Text = "Fecha de inicio:";
            // 
            // tbHabi
            // 
            this.tbHabi.Enabled = false;
            this.tbHabi.Location = new System.Drawing.Point(114, 94);
            this.tbHabi.Name = "tbHabi";
            this.tbHabi.Size = new System.Drawing.Size(200, 20);
            this.tbHabi.TabIndex = 20;
            // 
            // labHabit
            // 
            this.labHabit.AutoSize = true;
            this.labHabit.Location = new System.Drawing.Point(26, 94);
            this.labHabit.Name = "labHabit";
            this.labHabit.Size = new System.Drawing.Size(61, 13);
            this.labHabit.TabIndex = 19;
            this.labHabit.Text = "Habitacion:";
            // 
            // tbDNICli
            // 
            this.tbDNICli.Enabled = false;
            this.tbDNICli.Location = new System.Drawing.Point(114, 51);
            this.tbDNICli.Name = "tbDNICli";
            this.tbDNICli.Size = new System.Drawing.Size(200, 20);
            this.tbDNICli.TabIndex = 18;
            // 
            // btDniCli
            // 
            this.btDniCli.Location = new System.Drawing.Point(29, 48);
            this.btDniCli.Name = "btDniCli";
            this.btDniCli.Size = new System.Drawing.Size(75, 23);
            this.btDniCli.TabIndex = 34;
            this.btDniCli.Text = "DNI CLiente";
            this.btDniCli.UseVisualStyleBackColor = true;
            this.btDniCli.Click += new System.EventHandler(this.btDniCli_Click);
            // 
            // conReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 522);
            this.Controls.Add(this.btDniCli);
            this.Controls.Add(this.btAtras);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.dtFechaFin);
            this.Controls.Add(this.dtFechaIni);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.tbImporte);
            this.Controls.Add(this.labImporte);
            this.Controls.Add(this.labFechFin);
            this.Controls.Add(this.labFechIni);
            this.Controls.Add(this.tbHabi);
            this.Controls.Add(this.labHabit);
            this.Controls.Add(this.tbDNICli);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "conReservas";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAtras;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.DateTimePicker dtFechaFin;
        private System.Windows.Forms.DateTimePicker dtFechaIni;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox tbImporte;
        private System.Windows.Forms.Label labImporte;
        private System.Windows.Forms.Label labFechFin;
        private System.Windows.Forms.Label labFechIni;
        private System.Windows.Forms.TextBox tbHabi;
        private System.Windows.Forms.Label labHabit;
        private System.Windows.Forms.TextBox tbDNICli;
        private System.Windows.Forms.Button btDniCli;
    }
}