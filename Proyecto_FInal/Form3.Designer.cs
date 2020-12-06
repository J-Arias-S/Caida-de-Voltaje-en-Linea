namespace Proyecto_FInal
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Punto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PotHp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rendi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Distancia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PotKw = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PotBornes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Corriente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Momento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbPunto = new System.Windows.Forms.TextBox();
            this.tbPotHp = new System.Windows.Forms.TextBox();
            this.tbRendi = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.tbDis = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMomento = new System.Windows.Forms.TextBox();
            this.tbResistividad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSeccion = new System.Windows.Forms.Button();
            this.tbSeccion = new System.Windows.Forms.TextBox();
            this.tbAwg = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(372, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "DATOS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCerrar.Location = new System.Drawing.Point(708, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCalcular.Location = new System.Drawing.Point(667, 369);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Punto,
            this.PotHp,
            this.Rendi,
            this.Distancia,
            this.PotKw,
            this.PotBornes,
            this.Corriente,
            this.Momento});
            this.dataGridView1.Location = new System.Drawing.Point(28, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(742, 297);
            this.dataGridView1.TabIndex = 70;
            // 
            // Punto
            // 
            this.Punto.HeaderText = "Punto";
            this.Punto.Name = "Punto";
            this.Punto.Width = 40;
            // 
            // PotHp
            // 
            this.PotHp.HeaderText = "Potencia HP";
            this.PotHp.Name = "PotHp";
            this.PotHp.Width = 95;
            // 
            // Rendi
            // 
            this.Rendi.HeaderText = "Rendimiento";
            this.Rendi.Name = "Rendi";
            this.Rendi.Width = 90;
            // 
            // Distancia
            // 
            this.Distancia.HeaderText = "Dis. Fuente";
            this.Distancia.Name = "Distancia";
            this.Distancia.Width = 95;
            // 
            // PotKw
            // 
            this.PotKw.HeaderText = "Potencia kW";
            this.PotKw.Name = "PotKw";
            this.PotKw.Width = 95;
            // 
            // PotBornes
            // 
            this.PotBornes.HeaderText = "Pot. Bornes";
            this.PotBornes.Name = "PotBornes";
            this.PotBornes.Width = 90;
            // 
            // Corriente
            // 
            this.Corriente.HeaderText = "C. Activa";
            this.Corriente.Name = "Corriente";
            this.Corriente.Width = 90;
            // 
            // Momento
            // 
            this.Momento.HeaderText = "Mom Electrico";
            this.Momento.Name = "Momento";
            // 
            // tbPunto
            // 
            this.tbPunto.Location = new System.Drawing.Point(68, 371);
            this.tbPunto.Name = "tbPunto";
            this.tbPunto.Size = new System.Drawing.Size(43, 20);
            this.tbPunto.TabIndex = 0;
            // 
            // tbPotHp
            // 
            this.tbPotHp.Location = new System.Drawing.Point(117, 371);
            this.tbPotHp.Name = "tbPotHp";
            this.tbPotHp.Size = new System.Drawing.Size(100, 20);
            this.tbPotHp.TabIndex = 1;
            // 
            // tbRendi
            // 
            this.tbRendi.Location = new System.Drawing.Point(223, 371);
            this.tbRendi.Name = "tbRendi";
            this.tbRendi.Size = new System.Drawing.Size(100, 20);
            this.tbRendi.TabIndex = 2;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAgregar.Location = new System.Drawing.Point(435, 369);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // tbDis
            // 
            this.tbDis.Location = new System.Drawing.Point(329, 371);
            this.tbDis.Name = "tbDis";
            this.tbDis.Size = new System.Drawing.Size(100, 20);
            this.tbDis.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 412);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 71;
            this.label2.Text = "M. electrico total";
            // 
            // tbMomento
            // 
            this.tbMomento.Location = new System.Drawing.Point(175, 411);
            this.tbMomento.Name = "tbMomento";
            this.tbMomento.Size = new System.Drawing.Size(100, 20);
            this.tbMomento.TabIndex = 72;
            // 
            // tbResistividad
            // 
            this.tbResistividad.Location = new System.Drawing.Point(404, 411);
            this.tbResistividad.Name = "tbResistividad";
            this.tbResistividad.Size = new System.Drawing.Size(52, 20);
            this.tbResistividad.TabIndex = 74;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(303, 412);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 73;
            this.label3.Text = "Resistividad  1/";
            // 
            // btnSeccion
            // 
            this.btnSeccion.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSeccion.Location = new System.Drawing.Point(497, 409);
            this.btnSeccion.Name = "btnSeccion";
            this.btnSeccion.Size = new System.Drawing.Size(75, 23);
            this.btnSeccion.TabIndex = 75;
            this.btnSeccion.Text = "Seccion";
            this.btnSeccion.UseVisualStyleBackColor = false;
            this.btnSeccion.Click += new System.EventHandler(this.btnSeccion_Click);
            // 
            // tbSeccion
            // 
            this.tbSeccion.Location = new System.Drawing.Point(600, 412);
            this.tbSeccion.Name = "tbSeccion";
            this.tbSeccion.Size = new System.Drawing.Size(60, 20);
            this.tbSeccion.TabIndex = 76;
            // 
            // tbAwg
            // 
            this.tbAwg.Location = new System.Drawing.Point(691, 411);
            this.tbAwg.Name = "tbAwg";
            this.tbAwg.Size = new System.Drawing.Size(60, 20);
            this.tbAwg.TabIndex = 77;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(795, 455);
            this.Controls.Add(this.tbAwg);
            this.Controls.Add(this.tbSeccion);
            this.Controls.Add(this.btnSeccion);
            this.Controls.Add(this.tbResistividad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbMomento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbDis);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.tbRendi);
            this.Controls.Add(this.tbPotHp);
            this.Controls.Add(this.tbPunto);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "DATOS";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox tbPunto;
        private System.Windows.Forms.TextBox tbPotHp;
        private System.Windows.Forms.TextBox tbRendi;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox tbDis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Punto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PotHp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rendi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Distancia;
        private System.Windows.Forms.DataGridViewTextBoxColumn PotKw;
        private System.Windows.Forms.DataGridViewTextBoxColumn PotBornes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Corriente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Momento;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMomento;
        private System.Windows.Forms.TextBox tbResistividad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSeccion;
        private System.Windows.Forms.TextBox tbSeccion;
        private System.Windows.Forms.TextBox tbAwg;
    }
}