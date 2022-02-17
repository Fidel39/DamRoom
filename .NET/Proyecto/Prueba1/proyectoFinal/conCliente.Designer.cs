
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
            this.listViewClientes = new System.Windows.Forms.ListView();
            this.btBuscar = new System.Windows.Forms.Button();
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
            // listViewClientes
            // 
            this.listViewClientes.HideSelection = false;
            this.listViewClientes.Location = new System.Drawing.Point(39, 55);
            this.listViewClientes.Name = "listViewClientes";
            this.listViewClientes.Size = new System.Drawing.Size(571, 322);
            this.listViewClientes.TabIndex = 5;
            this.listViewClientes.UseCompatibleStateImageBehavior = false;
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
            // conCli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 483);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.tBdniCli);
            this.Controls.Add(this.labDNI);
            this.Controls.Add(this.listViewClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "conCli";
            this.Text = "Consultar Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.TextBox tBdniCli;
        private System.Windows.Forms.Label labDNI;
        private System.Windows.Forms.ListView listViewClientes;
    }
}