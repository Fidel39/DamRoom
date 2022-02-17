
namespace proyectoFinal
{
    partial class conCli
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
            this.btSalir = new System.Windows.Forms.Button();
            this.tBdniCli = new System.Windows.Forms.TextBox();
            this.labDNI = new System.Windows.Forms.Label();
            this.btBuscar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btSalir
            // 
            this.btSalir.FlatAppearance.BorderSize = 0;
            this.btSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSalir.Image = global::proyectoFinal.Properties.Resources.X;
            this.btSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSalir.Location = new System.Drawing.Point(535, 402);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(75, 23);
            this.btSalir.TabIndex = 9;
            this.btSalir.Text = "Salir";
            this.btSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSalir.UseVisualStyleBackColor = true;
            // 
            // tBdniCli
            // 
            this.tBdniCli.Location = new System.Drawing.Point(71, 402);
            this.tBdniCli.Name = "tBdniCli";
            this.tBdniCli.Size = new System.Drawing.Size(185, 20);
            this.tBdniCli.TabIndex = 7;
            // 
            // labDNI
            // 
            this.labDNI.AutoSize = true;
            this.labDNI.Location = new System.Drawing.Point(36, 405);
            this.labDNI.Name = "labDNI";
            this.labDNI.Size = new System.Drawing.Size(29, 13);
            this.labDNI.TabIndex = 6;
            this.labDNI.Text = "DNI:";
            // 
            // btBuscar
            // 
            this.btBuscar.FlatAppearance.BorderSize = 0;
            this.btBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBuscar.Image = global::proyectoFinal.Properties.Resources.lupa1;
            this.btBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btBuscar.Location = new System.Drawing.Point(345, 398);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(113, 27);
            this.btBuscar.TabIndex = 8;
            this.btBuscar.Text = "Buscar Cliente";
            this.btBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DNI,
            this.Nombre,
            this.apellidos,
            this.Direccion,
            this.Telefono});
            this.dataGridView1.Location = new System.Drawing.Point(54, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(542, 281);
            this.dataGridView1.TabIndex = 10;
            // 
            // DNI
            // 
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // apellidos
            // 
            this.apellidos.HeaderText = "Apellidos";
            this.apellidos.Name = "apellidos";
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            // 
            // conCli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(652, 483);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.tBdniCli);
            this.Controls.Add(this.labDNI);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "conCli";
            this.Text = "Consultar Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.TextBox tBdniCli;
        private System.Windows.Forms.Label labDNI;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
    }
}