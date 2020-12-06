namespace Proyecto_FInal
{
    partial class Form4
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCerrar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tbResis = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.tbMElec = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.tbPunto = new System.Windows.Forms.TextBox();
            this.tbSecc = new System.Windows.Forms.TextBox();
            this.Punto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Momento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Resistividad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Linea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCerrar.Location = new System.Drawing.Point(564, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Punto,
            this.Momento,
            this.Resistividad,
            this.Seccion,
            this.Fase,
            this.Linea});
            this.dataGridView1.Location = new System.Drawing.Point(22, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(584, 245);
            this.dataGridView1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(284, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "DATOS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbResis
            // 
            this.tbResis.Location = new System.Drawing.Point(177, 318);
            this.tbResis.Name = "tbResis";
            this.tbResis.Size = new System.Drawing.Size(68, 20);
            this.tbResis.TabIndex = 2;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAgregar.Location = new System.Drawing.Point(325, 316);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // tbMElec
            // 
            this.tbMElec.Location = new System.Drawing.Point(103, 318);
            this.tbMElec.Name = "tbMElec";
            this.tbMElec.Size = new System.Drawing.Size(68, 20);
            this.tbMElec.TabIndex = 1;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCalcular.Location = new System.Drawing.Point(510, 316);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // tbPunto
            // 
            this.tbPunto.Location = new System.Drawing.Point(42, 318);
            this.tbPunto.Name = "tbPunto";
            this.tbPunto.Size = new System.Drawing.Size(55, 20);
            this.tbPunto.TabIndex = 0;
            // 
            // tbSecc
            // 
            this.tbSecc.Location = new System.Drawing.Point(251, 318);
            this.tbSecc.Name = "tbSecc";
            this.tbSecc.Size = new System.Drawing.Size(68, 20);
            this.tbSecc.TabIndex = 3;
            // 
            // Punto
            // 
            this.Punto.HeaderText = "Punto";
            this.Punto.Name = "Punto";
            this.Punto.ReadOnly = true;
            this.Punto.Width = 40;
            // 
            // Momento
            // 
            this.Momento.HeaderText = "M. Electrico";
            this.Momento.Name = "Momento";
            this.Momento.ReadOnly = true;
            // 
            // Resistividad
            // 
            this.Resistividad.HeaderText = "Resistividad";
            this.Resistividad.Name = "Resistividad";
            this.Resistividad.ReadOnly = true;
            // 
            // Seccion
            // 
            this.Seccion.HeaderText = "Seccion";
            this.Seccion.Name = "Seccion";
            this.Seccion.ReadOnly = true;
            // 
            // Fase
            // 
            this.Fase.HeaderText = "C. en fase";
            this.Fase.Name = "Fase";
            this.Fase.ReadOnly = true;
            // 
            // Linea
            // 
            this.Linea.HeaderText = "C. en Linea";
            this.Linea.Name = "Linea";
            this.Linea.ReadOnly = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 367);
            this.Controls.Add(this.tbSecc);
            this.Controls.Add(this.tbPunto);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.tbResis);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.tbMElec);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCerrar);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbResis;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox tbMElec;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox tbPunto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Punto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Momento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Resistividad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fase;
        private System.Windows.Forms.DataGridViewTextBoxColumn Linea;
        private System.Windows.Forms.TextBox tbSecc;

    }
}