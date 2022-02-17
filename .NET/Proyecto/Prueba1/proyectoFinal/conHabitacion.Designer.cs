namespace proyectoFinal
{
    partial class conHabitacion
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
            this.labOcupadas = new System.Windows.Forms.Label();
            this.labLibres = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Caracteristicas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImporteNoche = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btVisualizarHabi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // labOcupadas
            // 
            this.labOcupadas.AutoSize = true;
            this.labOcupadas.Location = new System.Drawing.Point(437, 169);
            this.labOcupadas.Name = "labOcupadas";
            this.labOcupadas.Size = new System.Drawing.Size(121, 13);
            this.labOcupadas.TabIndex = 10;
            this.labOcupadas.Text = "Habitaciones Ocupadas";
            // 
            // labLibres
            // 
            this.labLibres.AutoSize = true;
            this.labLibres.Location = new System.Drawing.Point(92, 169);
            this.labLibres.Name = "labLibres";
            this.labLibres.Size = new System.Drawing.Size(100, 13);
            this.labLibres.TabIndex = 9;
            this.labLibres.Text = "Habitaciones Libres";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Tipo,
            this.Caracteristicas,
            this.ImporteNoche});
            this.dataGridView1.Location = new System.Drawing.Point(36, 213);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 183);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            // 
            // Caracteristicas
            // 
            this.Caracteristicas.HeaderText = "Caracteristicas";
            this.Caracteristicas.Name = "Caracteristicas";
            // 
            // ImporteNoche
            // 
            this.ImporteNoche.HeaderText = "Importe (Por Noche)";
            this.ImporteNoche.Name = "ImporteNoche";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridView2.Location = new System.Drawing.Point(364, 213);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(240, 183);
            this.dataGridView2.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Tipo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Caracteristicas";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Importe (Por Noche)";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // btVisualizarHabi
            // 
            this.btVisualizarHabi.FlatAppearance.BorderSize = 0;
            this.btVisualizarHabi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVisualizarHabi.Image = global::proyectoFinal.Properties.Resources.visualizar;
            this.btVisualizarHabi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btVisualizarHabi.Location = new System.Drawing.Point(269, 77);
            this.btVisualizarHabi.Name = "btVisualizarHabi";
            this.btVisualizarHabi.Size = new System.Drawing.Size(102, 48);
            this.btVisualizarHabi.TabIndex = 13;
            this.btVisualizarHabi.Text = "Visualizar";
            this.btVisualizarHabi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btVisualizarHabi.UseVisualStyleBackColor = true;
            this.btVisualizarHabi.Click += new System.EventHandler(this.btVisualizarHabi_Click);
            // 
            // conHabitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 483);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btVisualizarHabi);
            this.Controls.Add(this.labOcupadas);
            this.Controls.Add(this.labLibres);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "conHabitacion";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btVisualizarHabi;
        private System.Windows.Forms.Label labOcupadas;
        private System.Windows.Forms.Label labLibres;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Caracteristicas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImporteNoche;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}