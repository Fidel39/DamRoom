
namespace proyectoFinal
{
    partial class altaHabi
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
            this.groupBoxCli = new System.Windows.Forms.GroupBox();
            this.labDire = new System.Windows.Forms.Label();
            this.tbTipo = new System.Windows.Forms.TextBox();
            this.labApellidos = new System.Windows.Forms.Label();
            this.tbImporte = new System.Windows.Forms.TextBox();
            this.labNombre = new System.Windows.Forms.Label();
            this.tbCaracteristicas = new System.Windows.Forms.TextBox();
            this.btInserHabi = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.groupBoxCli.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCli
            // 
            this.groupBoxCli.Controls.Add(this.labDire);
            this.groupBoxCli.Controls.Add(this.tbTipo);
            this.groupBoxCli.Controls.Add(this.labApellidos);
            this.groupBoxCli.Controls.Add(this.tbImporte);
            this.groupBoxCli.Controls.Add(this.labNombre);
            this.groupBoxCli.Controls.Add(this.tbCaracteristicas);
            this.groupBoxCli.Location = new System.Drawing.Point(25, 149);
            this.groupBoxCli.Name = "groupBoxCli";
            this.groupBoxCli.Size = new System.Drawing.Size(619, 176);
            this.groupBoxCli.TabIndex = 12;
            this.groupBoxCli.TabStop = false;
            this.groupBoxCli.Text = "Insertar Habitación";
            // 
            // labDire
            // 
            this.labDire.AutoSize = true;
            this.labDire.Location = new System.Drawing.Point(297, 108);
            this.labDire.Name = "labDire";
            this.labDire.Size = new System.Drawing.Size(31, 13);
            this.labDire.TabIndex = 8;
            this.labDire.Text = "Tipo:";
            // 
            // tbTipo
            // 
            this.tbTipo.Location = new System.Drawing.Point(334, 105);
            this.tbTipo.Name = "tbTipo";
            this.tbTipo.Size = new System.Drawing.Size(249, 20);
            this.tbTipo.TabIndex = 9;
            // 
            // labApellidos
            // 
            this.labApellidos.AutoSize = true;
            this.labApellidos.Location = new System.Drawing.Point(27, 108);
            this.labApellidos.Name = "labApellidos";
            this.labApellidos.Size = new System.Drawing.Size(45, 13);
            this.labApellidos.TabIndex = 2;
            this.labApellidos.Text = "Importe:";
            // 
            // tbImporte
            // 
            this.tbImporte.Location = new System.Drawing.Point(85, 105);
            this.tbImporte.Name = "tbImporte";
            this.tbImporte.Size = new System.Drawing.Size(139, 20);
            this.tbImporte.TabIndex = 3;
            // 
            // labNombre
            // 
            this.labNombre.AutoSize = true;
            this.labNombre.Location = new System.Drawing.Point(249, 32);
            this.labNombre.Name = "labNombre";
            this.labNombre.Size = new System.Drawing.Size(79, 13);
            this.labNombre.TabIndex = 4;
            this.labNombre.Text = "Caracteristicas:";
            // 
            // tbCaracteristicas
            // 
            this.tbCaracteristicas.Location = new System.Drawing.Point(332, 29);
            this.tbCaracteristicas.Name = "tbCaracteristicas";
            this.tbCaracteristicas.Size = new System.Drawing.Size(251, 20);
            this.tbCaracteristicas.TabIndex = 5;
            // 
            // btInserHabi
            // 
            this.btInserHabi.Location = new System.Drawing.Point(466, 440);
            this.btInserHabi.Name = "btInserHabi";
            this.btInserHabi.Size = new System.Drawing.Size(75, 23);
            this.btInserHabi.TabIndex = 13;
            this.btInserHabi.Text = "Insertar";
            this.btInserHabi.UseVisualStyleBackColor = true;
            this.btInserHabi.Click += new System.EventHandler(this.btInserHabi_Click);
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(569, 440);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(75, 23);
            this.btSalir.TabIndex = 14;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // altaHabi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(668, 522);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btInserHabi);
            this.Controls.Add(this.groupBoxCli);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "altaHabi";
            this.Text = "Form9";
            this.groupBoxCli.ResumeLayout(false);
            this.groupBoxCli.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCli;
        private System.Windows.Forms.Label labDire;
        private System.Windows.Forms.TextBox tbTipo;
        private System.Windows.Forms.Label labApellidos;
        private System.Windows.Forms.TextBox tbImporte;
        private System.Windows.Forms.Label labNombre;
        private System.Windows.Forms.TextBox tbCaracteristicas;
        private System.Windows.Forms.Button btInserHabi;
        private System.Windows.Forms.Button btSalir;
    }
}