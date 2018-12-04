using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private string recibo;

        public Form1()
        {
            InitializeComponent();
        }


        //genera el recibo al hacer click en el boton
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            procesarDatos();
        }

        /*
         *
         *                            ATENCION!!!
         * 
         * hay que agregar el evento lostFocus en el archivo Form.Designer.cs
         * 
         *
         */
         
        // Genera un recibo cada vez que algun txtbox pierde el foco
        private void txtNombre_LostFocus(object sender, EventArgs e)
        {
            procesarDatos();
        }
        private void txtApellido_LostFocus(object sender, EventArgs e)
        {
            procesarDatos();
        }

        private void txtEdad_LostFocus(object sender, EventArgs e)
        {
            procesarDatos();
        }

        // genera el recibo cada vez que se hace click en el radioButton

        private void rdbHombre_CheckedChanged(object sender, EventArgs e)
        {
            procesarDatos();
        }

        private void rdbMujer_CheckedChanged(object sender, EventArgs e)
        {
            procesarDatos();
        }

        //esta funcion es la que se encarga de verificar cuales textbox se encuentran con datos para generar el recibo con los datos que correspondan
        private void procesarDatos()
        {
            recibo = "Datos del cliente" + System.Environment.NewLine;
            recibo += "=================" + System.Environment.NewLine;

            if(txtNombre.Text != "")
            {
                recibo += "Nombre: " + txtNombre.Text + System.Environment.NewLine;
            }

            if (txtApellido.Text != "")
            {
                recibo += "Apellido: " + txtApellido.Text + System.Environment.NewLine;
            }

            if (txtEdad.Text != "")
            {
                recibo += "Edad: " + txtEdad.Text + System.Environment.NewLine;
            }

            if(rdbHombre.Checked)
            {
                recibo += "Sexo: Hombre" + System.Environment.NewLine;
            }
            else if (rdbMujer.Checked)
            {
                recibo += "Sexo: Mujer" + System.Environment.NewLine;
            }

            txtRecibo.Text = recibo;
        }
    }
}
