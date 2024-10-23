namespace RegistroDeVehiculo
{
    partial class FrmMarino
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
            this.label6 = new System.Windows.Forms.Label();
            this.cmbTipoMarinos = new System.Windows.Forms.ComboBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvVehiculosMarinos = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoMarinos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Año = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbUso = new System.Windows.Forms.ComboBox();
            this.numericAño = new System.Windows.Forms.NumericUpDown();
            this.btnRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculosMarinos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAño)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(181, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 22);
            this.label6.TabIndex = 44;
            this.label6.Text = "Tipo de vehículo:";
            // 
            // cmbTipoMarinos
            // 
            this.cmbTipoMarinos.FormattingEnabled = true;
            this.cmbTipoMarinos.Items.AddRange(new object[] {
            "Barco",
            "Crucero",
            "Lancha"});
            this.cmbTipoMarinos.Location = new System.Drawing.Point(381, 100);
            this.cmbTipoMarinos.Name = "cmbTipoMarinos";
            this.cmbTipoMarinos.Size = new System.Drawing.Size(202, 24);
            this.cmbTipoMarinos.TabIndex = 43;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.Thistle;
            this.btnActualizar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(741, 181);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(134, 37);
            this.btnActualizar.TabIndex = 42;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Thistle;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(741, 122);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(134, 37);
            this.btnEliminar.TabIndex = 41;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dgvVehiculosMarinos
            // 
            this.dgvVehiculosMarinos.BackgroundColor = System.Drawing.Color.Thistle;
            this.dgvVehiculosMarinos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehiculosMarinos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.TipoMarinos,
            this.Marca,
            this.Modelo,
            this.Año,
            this.Uso});
            this.dgvVehiculosMarinos.Location = new System.Drawing.Point(52, 245);
            this.dgvVehiculosMarinos.Name = "dgvVehiculosMarinos";
            this.dgvVehiculosMarinos.RowHeadersWidth = 51;
            this.dgvVehiculosMarinos.RowTemplate.Height = 24;
            this.dgvVehiculosMarinos.Size = new System.Drawing.Size(823, 150);
            this.dgvVehiculosMarinos.TabIndex = 40;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 125;
            // 
            // TipoMarinos
            // 
            this.TipoMarinos.HeaderText = "Tipo de vehículo";
            this.TipoMarinos.MinimumWidth = 6;
            this.TipoMarinos.Name = "TipoMarinos";
            this.TipoMarinos.Width = 125;
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
            // Uso
            // 
            this.Uso.HeaderText = "Uso";
            this.Uso.MinimumWidth = 6;
            this.Uso.Name = "Uso";
            this.Uso.Width = 125;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Thistle;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAgregar.Location = new System.Drawing.Point(741, 69);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(134, 37);
            this.btnAgregar.TabIndex = 39;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(377, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 22);
            this.label5.TabIndex = 38;
            this.label5.Text = "Uso:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(377, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 22);
            this.label4.TabIndex = 36;
            this.label4.Text = "Año:";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(137, 179);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(202, 22);
            this.txtModelo.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 22);
            this.label3.TabIndex = 34;
            this.label3.Text = "Modelo:";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(137, 141);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(202, 22);
            this.txtMarca.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 22);
            this.label2.TabIndex = 31;
            this.label2.Text = "Marca:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(343, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 27);
            this.label1.TabIndex = 30;
            this.label1.Text = "VEHÍCULOS MARINOS";
            // 
            // cmbUso
            // 
            this.cmbUso.FormattingEnabled = true;
            this.cmbUso.Items.AddRange(new object[] {
            "Transporte",
            "Pesca",
            "Vigilancia"});
            this.cmbUso.Location = new System.Drawing.Point(456, 181);
            this.cmbUso.Name = "cmbUso";
            this.cmbUso.Size = new System.Drawing.Size(202, 24);
            this.cmbUso.TabIndex = 45;
            // 
            // numericAño
            // 
            this.numericAño.Location = new System.Drawing.Point(456, 140);
            this.numericAño.Name = "numericAño";
            this.numericAño.Size = new System.Drawing.Size(201, 22);
            this.numericAño.TabIndex = 46;
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnRegresar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Location = new System.Drawing.Point(636, 423);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(239, 36);
            this.btnRegresar.TabIndex = 47;
            this.btnRegresar.Text = "Regresar al menú principal";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // FrmMarino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 496);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.numericAño);
            this.Controls.Add(this.cmbUso);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbTipoMarinos);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dgvVehiculosMarinos);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmMarino";
            this.Text = "FrmMarino";
            this.Load += new System.EventHandler(this.FrmMarino_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculosMarinos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAño)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbTipoMarinos;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvVehiculosMarinos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbUso;
        private System.Windows.Forms.NumericUpDown numericAño;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoMarinos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Año;
        private System.Windows.Forms.DataGridViewTextBoxColumn Uso;
    }
}