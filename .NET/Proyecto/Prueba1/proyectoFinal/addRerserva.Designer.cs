namespace proyectoFinal
{
    partial class anyReserva
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
            this.gbReservas = new System.Windows.Forms.GroupBox();
            this.tbImporte = new System.Windows.Forms.TextBox();
            this.lbImporte = new System.Windows.Forms.Label();
            this.dtFechaFin = new System.Windows.Forms.DateTimePicker();
            this.lbFechaFin = new System.Windows.Forms.Label();
            this.dtFechaIni = new System.Windows.Forms.DateTimePicker();
            this.lbDniCliRe = new System.Windows.Forms.Label();
            this.lbFechaIni = new System.Windows.Forms.Label();
            this.lbNumHab = new System.Windows.Forms.Label();
            this.btReservar = new System.Windows.Forms.Button();
            this.cbDniCli = new System.Windows.Forms.ComboBox();
            this.cbHabi = new System.Windows.Forms.ComboBox();
            this.gbReservas.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbReservas
            // 
            this.gbReservas.Controls.Add(this.cbHabi);
            this.gbReservas.Controls.Add(this.cbDniCli);
            this.gbReservas.Controls.Add(this.tbImporte);
            this.gbReservas.Controls.Add(this.lbImporte);
            this.gbReservas.Controls.Add(this.dtFechaFin);
            this.gbReservas.Controls.Add(this.lbFechaFin);
            this.gbReservas.Controls.Add(this.dtFechaIni);
            this.gbReservas.Controls.Add(this.lbDniCliRe);
            this.gbReservas.Controls.Add(this.lbFechaIni);
            this.gbReservas.Controls.Add(this.lbNumHab);
            this.gbReservas.Location = new System.Drawing.Point(29, 158);
            this.gbReservas.Name = "gbReservas";
            this.gbReservas.Size = new System.Drawing.Size(611, 140);
            this.gbReservas.TabIndex = 10;
            this.gbReservas.TabStop = false;
            this.gbReservas.Text = "Datos Reserva";
            // 
            // tbImporte
            // 
            this.tbImporte.Location = new System.Drawing.Point(486, 36);
            this.tbImporte.Name = "tbImporte";
            this.tbImporte.Size = new System.Drawing.Size(109, 20);
            this.tbImporte.TabIndex = 10;
            // 
            // lbImporte
            // 
            this.lbImporte.AutoSize = true;
            this.lbImporte.Location = new System.Drawing.Point(435, 39);
            this.lbImporte.Name = "lbImporte";
            this.lbImporte.Size = new System.Drawing.Size(45, 13);
            this.lbImporte.TabIndex = 9;
            this.lbImporte.Text = "Importe:";
            // 
            // dtFechaFin
            // 
            this.dtFechaFin.Location = new System.Drawing.Point(396, 90);
            this.dtFechaFin.Name = "dtFechaFin";
            this.dtFechaFin.Size = new System.Drawing.Size(199, 20);
            this.dtFechaFin.TabIndex = 8;
            // 
            // lbFechaFin
            // 
            this.lbFechaFin.AutoSize = true;
            this.lbFechaFin.Location = new System.Drawing.Point(338, 96);
            this.lbFechaFin.Name = "lbFechaFin";
            this.lbFechaFin.Size = new System.Drawing.Size(57, 13);
            this.lbFechaFin.TabIndex = 7;
            this.lbFechaFin.Text = "Fecha Fin:";
            // 
            // dtFechaIni
            // 
            this.dtFechaIni.Location = new System.Drawing.Point(96, 90);
            this.dtFechaIni.Name = "dtFechaIni";
            this.dtFechaIni.Size = new System.Drawing.Size(201, 20);
            this.dtFechaIni.TabIndex = 6;
            this.dtFechaIni.Value = new System.DateTime(2022, 2, 17, 12, 19, 24, 0);
            // 
            // lbDniCliRe
            // 
            this.lbDniCliRe.AutoSize = true;
            this.lbDniCliRe.Location = new System.Drawing.Point(205, 39);
            this.lbDniCliRe.Name = "lbDniCliRe";
            this.lbDniCliRe.Size = new System.Drawing.Size(63, 13);
            this.lbDniCliRe.TabIndex = 4;
            this.lbDniCliRe.Text = "DNI cliente:";
            // 
            // lbFechaIni
            // 
            this.lbFechaIni.AutoSize = true;
            this.lbFechaIni.Location = new System.Drawing.Point(17, 96);
            this.lbFechaIni.Name = "lbFechaIni";
            this.lbFechaIni.Size = new System.Drawing.Size(68, 13);
            this.lbFechaIni.TabIndex = 2;
            this.lbFechaIni.Text = "Fecha Inicio:";
            // 
            // lbNumHab
            // 
            this.lbNumHab.AutoSize = true;
            this.lbNumHab.Location = new System.Drawing.Point(17, 39);
            this.lbNumHab.Name = "lbNumHab";
            this.lbNumHab.Size = new System.Drawing.Size(73, 13);
            this.lbNumHab.TabIndex = 0;
            this.lbNumHab.Text = "NºHabitacion:";
            // 
            // btReservar
            // 
            this.btReservar.FlatAppearance.BorderSize = 0;
            this.btReservar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btReservar.Image = global::proyectoFinal.Properties.Resources.reserva;
            this.btReservar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btReservar.Location = new System.Drawing.Point(554, 462);
            this.btReservar.Name = "btReservar";
            this.btReservar.Size = new System.Drawing.Size(86, 23);
            this.btReservar.TabIndex = 12;
            this.btReservar.Text = "Reservar";
            this.btReservar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btReservar.UseVisualStyleBackColor = true;
            this.btReservar.Click += new System.EventHandler(this.btReservar_Click);
            // 
            // cbDniCli
            // 
            this.cbDniCli.FormattingEnabled = true;
            this.cbDniCli.Location = new System.Drawing.Point(274, 36);
            this.cbDniCli.Name = "cbDniCli";
            this.cbDniCli.Size = new System.Drawing.Size(121, 21);
            this.cbDniCli.TabIndex = 13;
            this.cbDniCli.Text = "DNI";
            // 
            // cbHabi
            // 
            this.cbHabi.FormattingEnabled = true;
            this.cbHabi.Location = new System.Drawing.Point(96, 36);
            this.cbHabi.Name = "cbHabi";
            this.cbHabi.Size = new System.Drawing.Size(86, 21);
            this.cbHabi.TabIndex = 13;
            this.cbHabi.Text = "NºHabitacion";
            // 
            // anyReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(668, 522);
            this.Controls.Add(this.btReservar);
            this.Controls.Add(this.gbReservas);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "anyReserva";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.anyReserva_Load);
            this.gbReservas.ResumeLayout(false);
            this.gbReservas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btReservar;
        private System.Windows.Forms.GroupBox gbReservas;
        private System.Windows.Forms.TextBox tbImporte;
        private System.Windows.Forms.Label lbImporte;
        private System.Windows.Forms.DateTimePicker dtFechaFin;
        private System.Windows.Forms.Label lbFechaFin;
        private System.Windows.Forms.DateTimePicker dtFechaIni;
        private System.Windows.Forms.Label lbDniCliRe;
        private System.Windows.Forms.Label lbFechaIni;
        private System.Windows.Forms.Label lbNumHab;
        private System.Windows.Forms.ComboBox cbDniCli;
        private System.Windows.Forms.ComboBox cbHabi;
    }
}