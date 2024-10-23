namespace RegistroDeVehiculo
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAereo = new System.Windows.Forms.Button();
            this.btnMarino = new System.Windows.Forms.Button();
            this.btnTerrestre = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(206, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTRO DE VEHÍCULOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(151, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(361, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "¿Qué tipo de vehículo deseas registrar?";
            // 
            // btnAereo
            // 
            this.btnAereo.BackColor = System.Drawing.Color.LightPink;
            this.btnAereo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAereo.Image = ((System.Drawing.Image)(resources.GetObject("btnAereo.Image")));
            this.btnAereo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAereo.Location = new System.Drawing.Point(172, 447);
            this.btnAereo.Name = "btnAereo";
            this.btnAereo.Size = new System.Drawing.Size(361, 145);
            this.btnAereo.TabIndex = 3;
            this.btnAereo.Text = "Aéreo    ";
            this.btnAereo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAereo.UseVisualStyleBackColor = false;
            this.btnAereo.Click += new System.EventHandler(this.btnAereos_Click);
            // 
            // btnMarino
            // 
            this.btnMarino.BackColor = System.Drawing.Color.Thistle;
            this.btnMarino.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarino.Image = ((System.Drawing.Image)(resources.GetObject("btnMarino.Image")));
            this.btnMarino.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMarino.Location = new System.Drawing.Point(172, 294);
            this.btnMarino.Name = "btnMarino";
            this.btnMarino.Size = new System.Drawing.Size(361, 145);
            this.btnMarino.TabIndex = 2;
            this.btnMarino.Text = "Marino    ";
            this.btnMarino.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMarino.UseVisualStyleBackColor = false;
            this.btnMarino.Click += new System.EventHandler(this.btnMarinos_Click);
            // 
            // btnTerrestre
            // 
            this.btnTerrestre.BackColor = System.Drawing.Color.Moccasin;
            this.btnTerrestre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerrestre.Image = ((System.Drawing.Image)(resources.GetObject("btnTerrestre.Image")));
            this.btnTerrestre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTerrestre.Location = new System.Drawing.Point(172, 143);
            this.btnTerrestre.Name = "btnTerrestre";
            this.btnTerrestre.Size = new System.Drawing.Size(361, 145);
            this.btnTerrestre.TabIndex = 1;
            this.btnTerrestre.Text = "Terrestre    ";
            this.btnTerrestre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTerrestre.UseVisualStyleBackColor = false;
            this.btnTerrestre.Click += new System.EventHandler(this.btnTerrestres_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(720, 652);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAereo);
            this.Controls.Add(this.btnMarino);
            this.Controls.Add(this.btnTerrestre);
            this.Controls.Add(this.label1);
            this.Name = "FrmPrincipal";
            this.Text = "FrmPrincipal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTerrestre;
        private System.Windows.Forms.Button btnMarino;
        private System.Windows.Forms.Button btnAereo;
        private System.Windows.Forms.Label label2;
    }
}

