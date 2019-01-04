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
            // guardando valores del formulario
            string pNombre = textBoxNombre.Text;
            string pRUC = textBoxRUC.Text;
            string pDireccion = textBoxDireccion.Text;
            //Validando atributo año
            int pAnio = 0;
            if (textBoxAnio.Text == "")
            {
                MessageBox.Show("Campo de Año sin llenar");
                pAnio = -1;
            }
            else
            {
                try
                {
                    pAnio = int.Parse(textBoxAnio.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Campo de Año debe ser un número");
                    pAnio = -1;
                }
            }
            //Validando atributo mes
            int pMes = 0;
            if (textBoxMes.Text == "")
            {
                MessageBox.Show("Campo de Mes sin llenar");
                pMes = -1;
            }
            else
            {
                try
                {
                    pMes = int.Parse(textBoxMes.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Campo de Mes debe ser un número");
                    pMes = -1;
                }
            }
            string pRegimenTri = textBoxRegimenTri.Text;
            string pLibrosElectronicos = textBoxLibrosElectronicos.Text;

            //crear empresa con el boton registrar creando un obj Empresa
            bool validar = true;
            if (pNombre == "") { validar = false; }
            if (pRUC == "") { validar = false; }
            if (pDireccion == "") { validar = false; }
            if (pAnio == -1) { validar = false; }
            if (pMes == -1) { validar = false; }
            if (pRegimenTri == "") { validar = false; }
            if (pLibrosElectronicos == "") { validar = false; }
            //Despues de validar si no esta vacio validamos si existe para guardar o no
            if (validar == true)
            {
                //validar datos de entrada
                ConectionEmpresas CE = new ConectionEmpresas();
                if (CE.Validate(textBoxRUC.Text) == 0)
                {
                    string respuesta = CE.insert(textBoxRUC.Text, textBoxNombre.Text, int.Parse(textBoxAnio.Text), int.Parse(textBoxMes.Text), textBoxDireccion.Text, textBoxRegimenTri.Text, textBoxLibrosElectronicos.Text);
                    MessageBox.Show(respuesta);
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
            CE.Values(dataGridViewLista);
        }

        private void buttonPrueba_Click(object sender, EventArgs e)
        {
            Mood obj = new Mood();
            obj.Visible = true;
            Visible = false;
        }
    }
}
