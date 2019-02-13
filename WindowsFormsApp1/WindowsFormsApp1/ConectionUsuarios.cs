using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class ConectionUsuarios
    {
        SqlCommand cmd;
        SqlDataReader reader;
        SqlConnection SConection;
        public void conectar()
        {
            string ruta = "Data source=192.168.0.105; Initial Catalog=moodCont;user id=marcoConection; password=Conection";
            //string ruta = "Data Source=DARKPEARL\\SQLEXPRESS01;Initial Catalog= moodCont;integrated security=true";
            //string ruta = "Data source=192.168.0.105; Initial Catalog=moodCont;user id=marcoConection; password=Conection";
            SConection = new SqlConnection(ruta);
            SConection.Open();
        }
        public int Validate(string usuario,string password)
        {
            int validado = 0;
            try
            {
                conectar();
                cmd = new SqlCommand("SELECT * FROM usuarios  where usuario='"+usuario+"'and pwd='"+password+"'",SConection);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    validado++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("no existe " + ex.ToString());
            }
            return validado;
        }
    }
}
