using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaGrados;

namespace formsGrados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Fahrenheit fahrenheit = new BibliotecaGrados.Fahrenheit(45);
            Celsius celsius = (Celsius)fahrenheit;

        }

        private void label1_Click(object sender, EventArgs e)
        {
            string wea = this.lblTitulo.Text;
            this.lblTitulo.Text = "Cambio el valor";

        }

        private void txtBoxPrueba_TextChanged(object sender, EventArgs e)
        {

            Fahrenheit fahrenheit = new Fahrenheit(this.txtBoxPrueba.Text);
            Celsius celsius = (Celsius)fahrenheit;
            this.lblTitulo.Text =toString( celsius.Grados);

        }
    }
}
