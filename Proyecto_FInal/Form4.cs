using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_FInal
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            tbPunto.Focus();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();
            int cantFilas = dataGridView1.Rows.Count - 1;
            dataGridView1[0, cantFilas].Value = tbPunto.Text;
            dataGridView1[1, cantFilas].Value = tbMElec.Text;
            dataGridView1[2, cantFilas].Value = tbResis.Text;
            dataGridView1[3, cantFilas].Value = tbSecc.Text;
            tbPunto.Text = "";
            tbMElec.Text = "";
            tbResis.Text = "";
            tbSecc.Text = "";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                double Melec, Resis, Seccion, Fase, Linea;
                Melec = Convert.ToDouble(dataGridView1[1, i].Value);
                Resis = Convert.ToDouble(dataGridView1[2, i].Value);
                Seccion = Convert.ToDouble(dataGridView1[3, i].Value);
                Fase = Math.Round(Melec / (Resis * Seccion),2);
                dataGridView1[4, i].Value = Convert.ToString(Fase);
                Linea = Math.Round(Melec / (Resis * Seccion) * Math.Sqrt(3),2);
                dataGridView1[5, i].Value = Convert.ToString(Linea);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
