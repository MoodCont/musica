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
    public partial class SingUp : Form
    {
        public SingUp()
        {
            InitializeComponent();
            ConectionEmpresas CE = new ConectionEmpresas();
            CE.conectionEmpresas();
        }
        private void button1_Click(object sender, EventArgs e)
        {//visor de Contraseña
            if(textBox2.UseSystemPasswordChar == false)
            {
                textBox2.UseSystemPasswordChar = true;
            }
            else
            {
                textBox2.UseSystemPasswordChar = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {//boton de inicio de sesión ...
            ConectionUsuarios CU = new ConectionUsuarios();
            int validar = CU.Validate(textBox1.Text, textBox2.Text);
            if (validar == 1)
            {
                MessageBox.Show("Correcto");
            }
            else
            {
                MessageBox.Show("Incorrecto");
            }
            bool Valor = true;
            // validar inicio de sección
            if (textBox1.Text == "")
            {
                MessageBox.Show("Usuario Vacio");
                Valor = false;
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("Contraseña Vacia");
                Valor = false;
            }
            if (Valor && validar == 1)
            {
                inicio obj = new inicio();
                obj.Visible = true;
                Visible = false;
            }  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SingUp_Load(object sender, EventArgs e)
        {

        }
    }
}
