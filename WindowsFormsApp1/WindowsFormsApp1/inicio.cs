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
            string pRUC = textBoxRUC.Text ;
            string pDireccion = textBoxDireccion.Text;
            //Validando atributo año
            int pAnio = 0;
            if(textBoxAnio.Text=="")
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
                catch(Exception ex)
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
                catch(Exception ex)
                {
                    MessageBox.Show("Campo de Mes debe ser un número");
                    pMes = -1;
                }
            }
            string pRegimenTri = textBoxRegimenTri.Text;
            string pLibrosElectronicos = textBoxLibrosElectronicos.Text;
            
            //crear empresa con el boton registrar creando un obj Empresa
            Empresa NuevaEmpresa = new Empresa(pNombre,pRUC,pDireccion,pAnio,pMes,pRegimenTri,pLibrosElectronicos);
            //validar datos de entrada
            if(NuevaEmpresa.Validar())
            {

                //debemos crear un modulo para buscar si esta empresa ya esta en la base de datos

                //de no estar registrado debemos guardar y mostrar en la lista de empresas en la base de datos
                MessageBox.Show("Empresa Guardada");
                //puto el que lo lea :v
            }
            else
            {
                MessageBox.Show("Hay campos sin llenar");
            }


        }
    }
}
