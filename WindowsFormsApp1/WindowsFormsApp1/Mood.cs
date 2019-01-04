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

        private void button4_Click(object sender, EventArgs e)
        {
            if (panelSubMenuAsientos.Visible == true) { panelSubMenuAsientos.Visible = false; }
            else { panelSubMenuAsientos.Visible = true; }
        }

        
        
    }
}
