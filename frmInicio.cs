using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryArmaniniSP1_N1
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        int intentos = 0;
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if ((txtUsuario1.Text == "Administrador" &&
                txtContrasenia1.Text == "adm135$") ||
                (txtUsuario1.Text == "Operador" &&
                txtContrasenia1.Text == "ope246$"))

            {
                this.Hide();
                frmBienvenido f = new frmBienvenido(); // crea el frmInicio
                f.Text = txtUsuario1.Text; // asigna el texto de título
                f.ShowDialog(); // visualiza y ejecuta el frmInicio
                this.Show(); // visualiza nuevamente este formulario
            }

            else

            {
                MessageBox.Show("Datos Incorrectos, Acceso Denegado.");
                intentos++; // incrementa el contador de intentos fallidos
                if (intentos == 3) // si es 3 se cierra el formulario
                {
                    this.Close();
                }
            }
        }


        private void frmInicio_Load(object sender, EventArgs e)
        {
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
