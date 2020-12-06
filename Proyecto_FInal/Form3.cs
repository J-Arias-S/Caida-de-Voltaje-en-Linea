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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            tbPunto.Focus();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();
            int cantFilas = dataGridView1.Rows.Count - 1;
            dataGridView1[0, cantFilas].Value = tbPunto.Text;
            dataGridView1[1, cantFilas].Value = tbPotHp.Text;
            dataGridView1[2, cantFilas].Value = tbRendi.Text;
            dataGridView1[3, cantFilas].Value = tbDis.Text;
            tbPunto.Text = "";
            tbPotHp.Text = "";
            tbRendi.Text = "";
            tbDis.Text = "";
        }

        double Num, Res, Ren, Resp, Corr, Dis, Mom, Total = 0;
        public void btnCalcular_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++ )
            {
                Num = Convert.ToDouble(dataGridView1[1, i].Value);
                Ren = Convert.ToDouble(dataGridView1[2, i].Value);
                Dis = Convert.ToDouble(dataGridView1[3, i].Value);
                Res = Math.Round(Num * 0.746,2);
                dataGridView1[4, i].Value = Convert.ToString(Res);
                Resp = Math.Round(Res / Ren,2);
                dataGridView1[5, i].Value = Convert.ToString(Resp);
                Corr =  Math.Round((Resp * 1000) / (380 * Math.Sqrt(3)),2);
                dataGridView1[6, i].Value = Convert.ToString(Corr);
                Mom = Math.Round(Dis * Corr, 2);
                dataGridView1[7, i].Value = Convert.ToString(Mom);
                Total = Total + Mom;
            }
            tbMomento.Text = Convert.ToString(Total);
        }

        public void btnSeccion_Click(object sender, EventArgs e)
        {
            double Resistividad, Seccion;
            Resistividad = Convert.ToDouble(tbResistividad.Text);
            Seccion = Math.Round(Total / (Resistividad * 7.68), 2);
            tbSeccion.Text = Convert.ToString(Seccion);
            if (Seccion < 21.1) 
            {
                tbAwg.Text = "4 AWG";
            }
            if (Seccion > 21.1 && Seccion < 26.7)
            {
                tbAwg.Text = "3 AWG";
            }
            if (Seccion > 26.7 && Seccion < 33.6)
            {
                tbAwg.Text = "2 AWG";
            }
            if (Seccion > 33.6 && Seccion < 42.4)
            {
                tbAwg.Text = "1 AWG";
            }
            if (Seccion > 42.4 && Seccion < 53.5)
            {
                tbAwg.Text = "1/0 AWG";
            }
            if (Seccion > 53.5 && Seccion < 67.4)
            {
                tbAwg.Text = "2/0 AWG";
            }
            if (Seccion > 67.4 && Seccion < 85)
            {
                tbAwg.Text = "3/0 AWG";
            }
            if (Seccion > 85 && Seccion < 107)
            {
                tbAwg.Text = "4/0 AWG";
            }
        }
    }
}
