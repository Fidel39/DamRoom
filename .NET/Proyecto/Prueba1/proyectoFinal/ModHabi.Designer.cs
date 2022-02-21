
namespace proyectoFinal
{
    partial class modHabi
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
            this.groupBoxModHab = new System.Windows.Forms.GroupBox();
            this.labPregunta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxHabi = new System.Windows.Forms.GroupBox();
            this.labDire = new System.Windows.Forms.Label();
            this.tbTipo = new System.Windows.Forms.TextBox();
            this.labApellidos = new System.Windows.Forms.Label();
            this.tbImporte = new System.Windows.Forms.TextBox();
            this.labNombre = new System.Windows.Forms.Label();
            this.tbCaracteristicas = new System.Windows.Forms.TextBox();
            this.btModiHabi = new System.Windows.Forms.Button();
            this.cbHabi = new System.Windows.Forms.ComboBox();
            this.groupBoxModHab.SuspendLayout();
            this.groupBoxHabi.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxModHab
            // 
            this.groupBoxModHab.Controls.Add(this.cbHabi);
            this.groupBoxModHab.Controls.Add(this.labPregunta);
            this.groupBoxModHab.Controls.Add(this.label1);
            this.groupBoxModHab.Location = new System.Drawing.Point(25, 40);
            this.groupBoxModHab.Name = "groupBoxModHab";
            this.groupBoxModHab.Size = new System.Drawing.Size(615, 130);
            this.groupBoxModHab.TabIndex = 16;
            this.groupBoxModHab.TabStop = false;
            this.groupBoxModHab.Text = "Modificar una habitacion";
            // 
            // labPregunta
            // 
            this.labPregunta.AutoSize = true;
            this.labPregunta.Location = new System.Drawing.Point(129, 34);
            this.labPregunta.Name = "labPregunta";
            this.labPregunta.Size = new System.Drawing.Size(347, 13);
            this.labPregunta.TabIndex = 0;
            this.labPregunta.Text = "Que habitacion quieres modificar? Introduzca el numero de la habitacion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "NºHabitacion:";
            // 
            // groupBoxHabi
            // 
            this.groupBoxHabi.Controls.Add(this.labDire);
            this.groupBoxHabi.Controls.Add(this.tbTipo);
            this.groupBoxHabi.Controls.Add(this.labApellidos);
            this.groupBoxHabi.Controls.Add(this.tbImporte);
            this.groupBoxHabi.Controls.Add(this.labNombre);
            this.groupBoxHabi.Controls.Add(this.tbCaracteristicas);
            this.groupBoxHabi.Location = new System.Drawing.Point(21, 208);
            this.groupBoxHabi.Name = "groupBoxHabi";
            this.groupBoxHabi.Size = new System.Drawing.Size(619, 176);
            this.groupBoxHabi.TabIndex = 17;
            this.groupBoxHabi.TabStop = false;
            this.groupBoxHabi.Text = "Insertar Habitación";
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
            this.labNombre.Location = new System.Drawing.Point(27, 36);
            this.labNombre.Name = "labNombre";
            this.labNombre.Size = new System.Drawing.Size(79, 13);
            this.labNombre.TabIndex = 4;
            this.labNombre.Text = "Caracteristicas:";
            // 
            // tbCaracteristicas
            // 
            this.tbCaracteristicas.Location = new System.Drawing.Point(112, 33);
            this.tbCaracteristicas.Name = "tbCaracteristicas";
            this.tbCaracteristicas.Size = new System.Drawing.Size(471, 20);
            this.tbCaracteristicas.TabIndex = 5;
            // 
            // btModiHabi
            // 
            this.btModiHabi.FlatAppearance.BorderSize = 0;
            this.btModiHabi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btModiHabi.Image = global::proyectoFinal.Properties.Resources.modificar;
            this.btModiHabi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btModiHabi.Location = new System.Drawing.Point(534, 437);
            this.btModiHabi.Name = "btModiHabi";
            this.btModiHabi.Size = new System.Drawing.Size(106, 36);
            this.btModiHabi.TabIndex = 14;
            this.btModiHabi.Text = "Modificar";
            this.btModiHabi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btModiHabi.UseVisualStyleBackColor = true;
            this.btModiHabi.Click += new System.EventHandler(this.btModiHabi_Click);
            // 
            // cbHabi
            // 
            this.cbHabi.FormattingEnabled = true;
            this.cbHabi.Location = new System.Drawing.Point(254, 80);
            this.cbHabi.Name = "cbHabi";
            this.cbHabi.Size = new System.Drawing.Size(180, 21);
            this.cbHabi.TabIndex = 18;
            this.cbHabi.Text = "Numero Habitacion";
            // 
            // modHabi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(668, 522);
            this.Controls.Add(this.groupBoxHabi);
            this.Controls.Add(this.groupBoxModHab);
            this.Controls.Add(this.btModiHabi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "modHabi";
            this.Text = "Form11";
            this.Load += new System.EventHandler(this.modHabi_Load);
            this.groupBoxModHab.ResumeLayout(false);
            this.groupBoxModHab.PerformLayout();
            this.groupBoxHabi.ResumeLayout(false);
            this.groupBoxHabi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btModiHabi;
        private System.Windows.Forms.GroupBox groupBoxModHab;
        private System.Windows.Forms.Label labPregunta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxHabi;
        private System.Windows.Forms.Label labDire;
        private System.Windows.Forms.TextBox tbTipo;
        private System.Windows.Forms.Label labApellidos;
        private System.Windows.Forms.TextBox tbImporte;
        private System.Windows.Forms.Label labNombre;
        private System.Windows.Forms.TextBox tbCaracteristicas;
        private System.Windows.Forms.ComboBox cbHabi;
    }
}