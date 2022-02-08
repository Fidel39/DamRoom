namespace Prueba1
{
    partial class menu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btAReservas = new System.Windows.Forms.Button();
            this.btConReservas = new System.Windows.Forms.Button();
            this.btConHabitacion = new System.Windows.Forms.Button();
            this.btConCliente = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.imGif = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imGif)).BeginInit();
            this.SuspendLayout();
            // 
            // btAReservas
            // 
            this.btAReservas.Location = new System.Drawing.Point(482, 310);
            this.btAReservas.Name = "btAReservas";
            this.btAReservas.Size = new System.Drawing.Size(132, 25);
            this.btAReservas.TabIndex = 2;
            this.btAReservas.Text = "Añadir Rerserva";
            this.btAReservas.UseVisualStyleBackColor = true;
            this.btAReservas.Click += new System.EventHandler(this.btAReservas_Click);
            // 
            // btConReservas
            // 
            this.btConReservas.Location = new System.Drawing.Point(634, 310);
            this.btConReservas.Name = "btConReservas";
            this.btConReservas.Size = new System.Drawing.Size(132, 23);
            this.btConReservas.TabIndex = 3;
            this.btConReservas.Text = "Consultar Rservas";
            this.btConReservas.UseVisualStyleBackColor = true;
            this.btConReservas.Click += new System.EventHandler(this.btConReservas_Click);
            // 
            // btConHabitacion
            // 
            this.btConHabitacion.Location = new System.Drawing.Point(482, 352);
            this.btConHabitacion.Name = "btConHabitacion";
            this.btConHabitacion.Size = new System.Drawing.Size(132, 23);
            this.btConHabitacion.TabIndex = 4;
            this.btConHabitacion.Text = "Consultar Habitacion";
            this.btConHabitacion.UseVisualStyleBackColor = true;
            this.btConHabitacion.Click += new System.EventHandler(this.btConHabitacion_Click);
            // 
            // btConCliente
            // 
            this.btConCliente.Location = new System.Drawing.Point(634, 352);
            this.btConCliente.Name = "btConCliente";
            this.btConCliente.Size = new System.Drawing.Size(132, 23);
            this.btConCliente.TabIndex = 5;
            this.btConCliente.Text = "Consultar Habitacion";
            this.btConCliente.UseVisualStyleBackColor = true;
            this.btConCliente.Click += new System.EventHandler(this.btConCliente_Click);
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(634, 417);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(132, 23);
            this.btSalir.TabIndex = 6;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // logo
            // 
            this.logo.Image = global::Prueba1.Properties.Resources.logo;
            this.logo.InitialImage = global::Prueba1.Properties.Resources.logo;
            this.logo.Location = new System.Drawing.Point(482, 66);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(284, 202);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 1;
            this.logo.TabStop = false;
            // 
            // imGif
            // 
            this.imGif.Location = new System.Drawing.Point(46, 66);
            this.imGif.Name = "imGif";
            this.imGif.Size = new System.Drawing.Size(381, 309);
            this.imGif.TabIndex = 7;
            this.imGif.TabStop = false;
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 470);
            this.Controls.Add(this.imGif);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btConCliente);
            this.Controls.Add(this.btConHabitacion);
            this.Controls.Add(this.btConReservas);
            this.Controls.Add(this.btAReservas);
            this.Controls.Add(this.logo);
            this.Name = "menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imGif)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button btAReservas;
        private System.Windows.Forms.Button btConReservas;
        private System.Windows.Forms.Button btConHabitacion;
        private System.Windows.Forms.Button btConCliente;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.PictureBox imGif;
    }
}

