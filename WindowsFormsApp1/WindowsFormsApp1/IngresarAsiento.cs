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
    public partial class IngresarAsiento : Form
    {
        public IngresarAsiento()
        {
            InitializeComponent();
        }

        private void buttonGuardarIngresarAsiento_Click(object sender, EventArgs e)
        {
            bool validar = true;
            //crear el periodo
            string periodo = "";
            if( textBoxPeriodoAnio.Text.Length == 4 && textBoxPeriodoMes.Text.Length == 2)
            {
                periodo = textBoxPeriodoAnio.Text + textBoxPeriodoMes + "00";
                MessageBox.Show(periodo);
            }
            else
            {
                MessageBox.Show("Periodo tiene formato incorrecto AAAA MM");
                textBoxPeriodoAnio.Text = "";
                textBoxPeriodoMes.Text = "";
                validar = false;
            }


        }
    }
}
