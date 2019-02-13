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
    public partial class Mood : Form
    {
        public Mood()
        {
            InitializeComponent();
        }
        //creando funcion para abrir un formulario dentro de otro
        private void AbrirFormulario(object FormularioHijo)
        {
            if (this.panelMoodPrincipal.Controls.Count > 0)
                this.panelMoodPrincipal.Controls.RemoveAt(0);
            Form formulario = FormularioHijo as Form;
            formulario.TopLevel = false;
            formulario.Dock = DockStyle.Fill;
            this.panelMoodPrincipal.Controls.Add(formulario);
            this.panelMoodPrincipal.Tag = formulario;
            formulario.Show();
        }
        //fin

        private void Mood_Load(object sender, EventArgs e)
        {

        }

        private void planDeCuentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new PlanDeCuentas());
        }

        private void panelMoodPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
