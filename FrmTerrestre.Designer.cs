namespace RegistroDeVehiculo
{
    partial class FrmTerrestre
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvVehiculosTerrestres = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.cmbTipoTerrestre = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numericAño = new System.Windows.Forms.NumericUpDown();
            this.numericCilindros = new System.Windows.Forms.NumericUpDown();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoTerrestre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Año = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroCilindros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculosTerrestres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAño)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCilindros)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(323, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "VEHÍCULOS TERRESTRES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Marca:";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(139, 138);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(202, 22);
            this.txtMarca.TabIndex = 2;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(139, 176);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(202, 22);
            this.txtModelo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Modelo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(366, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Año:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(366, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Num. de cilindros:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Moccasin;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAgregar.Location = new System.Drawing.Point(738, 65);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(131, 37);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvVehiculosTerrestres
            // 
            this.dgvVehiculosTerrestres.BackgroundColor = System.Drawing.Color.Moccasin;
            this.dgvVehiculosTerrestres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehiculosTerrestres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.TipoTerrestre,
            this.Marca,
            this.Modelo,
            this.Año,
            this.NumeroCilindros});
            this.dgvVehiculosTerrestres.Location = new System.Drawing.Point(54, 237);
            this.dgvVehiculosTerrestres.Name = "dgvVehiculosTerrestres";
            this.dgvVehiculosTerrestres.RowHeadersWidth = 51;
            this.dgvVehiculosTerrestres.RowTemplate.Height = 24;
            this.dgvVehiculosTerrestres.Size = new System.Drawing.Size(815, 150);
            this.dgvVehiculosTerrestres.TabIndex = 10;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Moccasin;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEliminar.Location = new System.Drawing.Point(738, 118);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(131, 37);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.Moccasin;
            this.btnActualizar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnActualizar.Location = new System.Drawing.Point(738, 177);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(131, 37);
            this.btnActualizar.TabIndex = 12;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // cmbTipoTerrestre
            // 
            this.cmbTipoTerrestre.FormattingEnabled = true;
            this.cmbTipoTerrestre.Items.AddRange(new object[] {
            "Automóvil",
            "Motocicleta",
            "Camión"});
            this.cmbTipoTerrestre.Location = new System.Drawing.Point(370, 97);
            this.cmbTipoTerrestre.Name = "cmbTipoTerrestre";
            this.cmbTipoTerrestre.Size = new System.Drawing.Size(202, 24);
            this.cmbTipoTerrestre.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(180, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 22);
            this.label6.TabIndex = 14;
            this.label6.Text = "Tipo de vehículo:";
            // 
            // numericAño
            // 
            this.numericAño.Location = new System.Drawing.Point(553, 138);
            this.numericAño.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.numericAño.Name = "numericAño";
            this.numericAño.Size = new System.Drawing.Size(107, 22);
            this.numericAño.TabIndex = 15;
            // 
            // numericCilindros
            // 
            this.numericCilindros.Location = new System.Drawing.Point(553, 177);
            this.numericCilindros.Name = "numericCilindros";
            this.numericCilindros.Size = new System.Drawing.Size(107, 22);
            this.numericCilindros.TabIndex = 16;
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnRegresar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRegresar.Location = new System.Drawing.Point(630, 413);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(239, 36);
            this.btnRegresar.TabIndex = 32;
            this.btnRegresar.Text = "Regresar al menú principal";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 125;
            // 
            // TipoTerrestre
            // 
            this.TipoTerrestre.HeaderText = "Tipo de vehículo";
            this.TipoTerrestre.MinimumWidth = 6;
            this.TipoTerrestre.Name = "TipoTerrestre";
            this.TipoTerrestre.Width = 125;
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.MinimumWidth = 6;
            this.Marca.Name = "Marca";
            this.Marca.Width = 125;
            // 
            // Modelo
            // 
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.MinimumWidth = 6;
            this.Modelo.Name = "Modelo";
            this.Modelo.Width = 125;
            // 
            // Año
            // 
            this.Año.HeaderText = "Año";
            this.Año.MinimumWidth = 6;
            this.Año.Name = "Año";
            this.Año.Width = 125;
            // 
            // NumeroCilindros
            // 
            this.NumeroCilindros.HeaderText = "Num. de cilindros";
            this.NumeroCilindros.MinimumWidth = 6;
            this.NumeroCilindros.Name = "NumeroCilindros";
            this.NumeroCilindros.Width = 125;
            // 
            // FrmTerrestre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(928, 479);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.numericCilindros);
            this.Controls.Add(this.numericAño);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbTipoTerrestre);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dgvVehiculosTerrestres);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmTerrestre";
            this.Text = "FrmTerrestre";
            this.Load += new System.EventHandler(this.FrmTerrestre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculosTerrestres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAño)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCilindros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvVehiculosTerrestres;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.ComboBox cmbTipoTerrestre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericAño;
        private System.Windows.Forms.NumericUpDown numericCilindros;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoTerrestre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Año;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroCilindros;
    }
}