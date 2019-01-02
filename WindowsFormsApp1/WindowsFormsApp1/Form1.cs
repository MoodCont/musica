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
        public partial class user
        {
            private string aUsuario;
            private string aPassword;
            public string usuario { get; set; }
            public string passwrod { get; set; }
        }
        ConectionUsuarios conectarUser = new ConectionUsuarios();
        ConectionEmpresas conectarSer = new ConectionEmpresas();
        user usuario = new user();
        public Form1()
        {
            conectarSer.conectionEmpresas();
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
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
        {
            int validate=conectarUser.Validate(textBox1.Text, textBox2.Text);
            if (validate == 1)
            {
                MessageBox.Show("usuario logeado");
            }
            else
            {
                MessageBox.Show("error");
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void id_user(object sender, EventArgs e)
        {
            usuario.usuario = sender.ToString();
        }
        private void password (object sender, EventArgs e)
        {
            usuario.passwrod = sender.ToString();
        }
    }
}
