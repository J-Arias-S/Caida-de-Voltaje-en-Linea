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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Form2 NuevaVentana;
 
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (tbContrasena.Text == "Josue" && tbUsuario.Text == "josue")
            {
                this.Hide();
                NuevaVentana = new Form2();
                NuevaVentana.FormClosed += new FormClosedEventHandler(NuevaVentana_FormClosed);
                NuevaVentana.Show();
            }
            else 
            {
                MessageBox.Show("Error de Usuario o Contraseña","Error",MessageBoxButtons.OKCancel,MessageBoxIcon.Exclamation);
                tbContrasena.Text = "";
                tbUsuario.Text = "";
            }
        }

        void NuevaVentana_FormClosed(object sender, FormClosedEventArgs e)
        {
            NuevaVentana = null;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
