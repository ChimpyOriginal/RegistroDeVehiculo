namespace RegistroDeVehiculo
{
    partial class FrmAereo
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
            this.cmbTipoAereo = new System.Windows.Forms.ComboBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvVehiculosAereos = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoAereo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Año = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumMotores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericMotores = new System.Windows.Forms.NumericUpDown();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericAño = new System.Windows.Forms.NumericUpDown();
            this.btnRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculosAereos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMotores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAño)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(193, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 22);
            this.label6.TabIndex = 29;
            this.label6.Text = "Tipo de vehículo:";
            // 
            // cmbTipoAereo
            // 
            this.cmbTipoAereo.FormattingEnabled = true;
            this.cmbTipoAereo.Items.AddRange(new object[] {
            "Avión",
            "Helicóptero",
            "Avioneta"});
            this.cmbTipoAereo.Location = new System.Drawing.Point(374, 97);
            this.cmbTipoAereo.Name = "cmbTipoAereo";
            this.cmbTipoAereo.Size = new System.Drawing.Size(202, 24);
            this.cmbTipoAereo.TabIndex = 28;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.LightPink;
            this.btnActualizar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(745, 180);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(131, 37);
            this.btnActualizar.TabIndex = 27;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.LightPink;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(745, 121);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(131, 37);
            this.btnEliminar.TabIndex = 26;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dgvVehiculosAereos
            // 
            this.dgvVehiculosAereos.BackgroundColor = System.Drawing.Color.LightPink;
            this.dgvVehiculosAereos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehiculosAereos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.TipoAereo,
            this.Marca,
            this.Modelo,
            this.Año,
            this.NumMotores});
            this.dgvVehiculosAereos.Location = new System.Drawing.Point(55, 247);
            this.dgvVehiculosAereos.Name = "dgvVehiculosAereos";
            this.dgvVehiculosAereos.RowHeadersWidth = 51;
            this.dgvVehiculosAereos.RowTemplate.Height = 24;
            this.dgvVehiculosAereos.Size = new System.Drawing.Size(821, 150);
            this.dgvVehiculosAereos.TabIndex = 25;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 125;
            // 
            // TipoAereo
            // 
            this.TipoAereo.HeaderText = "Tipo de vehículo";
            this.TipoAereo.MinimumWidth = 6;
            this.TipoAereo.Name = "TipoAereo";
            this.TipoAereo.Width = 125;
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
            // NumMotores
            // 
            this.NumMotores.HeaderText = "Num. de motores";
            this.NumMotores.MinimumWidth = 6;
            this.NumMotores.Name = "NumMotores";
            this.NumMotores.Width = 125;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.LightPink;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(745, 68);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(131, 37);
            this.btnAgregar.TabIndex = 24;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(380, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 22);
            this.label5.TabIndex = 23;
            this.label5.Text = "Num. de motores:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(380, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 22);
            this.label4.TabIndex = 21;
            this.label4.Text = "Año:";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(140, 179);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(202, 22);
            this.txtModelo.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 22);
            this.label3.TabIndex = 19;
            this.label3.Text = "Modelo:";
            // 
            // numericMotores
            // 
            this.numericMotores.Location = new System.Drawing.Point(563, 179);
            this.numericMotores.Name = "numericMotores";
            this.numericMotores.Size = new System.Drawing.Size(107, 22);
            this.numericMotores.TabIndex = 18;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(140, 141);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(202, 22);
            this.txtMarca.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 22);
            this.label2.TabIndex = 16;
            this.label2.Text = "Marca:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(349, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 27);
            this.label1.TabIndex = 15;
            this.label1.Text = "VEHÍCULOS AÉREOS";
            // 
            // numericAño
            // 
            this.numericAño.Location = new System.Drawing.Point(563, 136);
            this.numericAño.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.numericAño.Name = "numericAño";
            this.numericAño.Size = new System.Drawing.Size(107, 22);
            this.numericAño.TabIndex = 30;
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnRegresar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Location = new System.Drawing.Point(637, 419);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(239, 36);
            this.btnRegresar.TabIndex = 31;
            this.btnRegresar.Text = "Regresar al menú principal";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // FrmAereo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 488);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.numericAño);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbTipoAereo);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dgvVehiculosAereos);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericMotores);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmAereo";
            this.Text = "FrmAereo";
            this.Load += new System.EventHandler(this.FrmAereo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculosAereos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMotores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAño)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbTipoAereo;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvVehiculosAereos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericMotores;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericAño;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoAereo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Año;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumMotores;
    }
}