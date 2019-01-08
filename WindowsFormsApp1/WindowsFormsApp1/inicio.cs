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
    public partial class inicio : Form
    {
        public inicio()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //crear empresa con el boton registrar creando un obj Empresa
            bool validar = true;
            if (textBoxNombre.Text == "") { validar = false; }
            if (textBoxRUC.Text.Length != 10)
            {
                MessageBox.Show("el RUC no valido");
                textBoxRUC.Text = "";
            }
            if (textBoxRUC.Text == "") { validar = false; }
            if (textBoxDireccion.Text == "") { validar = false; }
            try
            {
                int.Parse(textBoxAnio.Text);
                int.Parse(textBoxMes.Text);
            }catch{
                MessageBox.Show("El campo de fecha debe ser Entero = error ");
                textBoxAnio.Text = "";
                textBoxMes.Text = "";
                validar = false;
            }
            if (textBoxRegimenTri.Text == "") { validar = false; }
            if (textBoxLibrosElectronicos.Text == "") { validar = false; }
            //Despues de validar si no esta vacio validamos si existe para guardar o no
            if (validar == true)
            {
                //validar datos de entrada
                ConectionEmpresas CE = new ConectionEmpresas();
                if (CE.Validate(textBoxRUC.Text) == 0)
                {
                    string respuesta = CE.insert(textBoxRUC.Text, textBoxNombre.Text, int.Parse(textBoxAnio.Text), int.Parse(textBoxMes.Text), textBoxDireccion.Text, textBoxRegimenTri.Text, textBoxLibrosElectronicos.Text);
                    MessageBox.Show(respuesta);
                    textBoxAnio.Text = "";
                    textBoxMes.Text = "";
                    textBoxNombre.Text = "";
                    textBoxRegimenTri.Text = "";
                    textBoxRUC.Text = "";
                    textBoxLibrosElectronicos.Text = "";
                    textBoxDireccion.Text = "";
                }
                else
                {
                    MessageBox.Show("Esta empresa ya existe");
                }
            }
            else
            {
                MessageBox.Show("Hay campos sin llenar");
            }

        }
        private void mostrar(object sender, EventArgs e)
        {
            ConectionEmpresas CE = new ConectionEmpresas();
            if (textBoxBuscar.Text == "")
            {
                CE.Values(dataGridViewLista);
            }
            else
            {
                string buscar = textBoxBuscar.Text;
                CE.search(buscar,dataGridViewLista);
            }
        }
        private void buttonPrueba_Click(object sender, EventArgs e)
        {
            Mood obj = new Mood();
            obj.Visible = true;
            Visible = false;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
