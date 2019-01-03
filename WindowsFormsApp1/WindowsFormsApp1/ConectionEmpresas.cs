using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Net;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class ConectionEmpresas
    {
        SqlCommand cmd;
        SqlDataReader reader;
        SqlConnection SConection;

        public void conectionEmpresas()
        {
            try
            {
                SConection = new SqlConnection("Data Source=192.168.0.101,1433;Initial Catalog= moodCont;user id=sa;password=123456");
                SConection.Open();
                MessageBox.Show("conectado");
            }
            catch(Exception ex){
                MessageBox.Show("no se conecto" + ex.ToString());
            }
        }
        public string insert(string RUC, string Nombre, string anio, string mes,string direccion) 
        {
            string salida = "se inserto";
            try
            {
                cmd = new SqlCommand("Insert into empresas(Ruc,Nombre,Date_Anio,Date_mes,Direccion) values('" + RUC + "','" + Nombre + "','" + anio + "','" + mes + "','" + direccion + "')",SConection);
                cmd.ExecuteNonQuery();
            } catch (Exception ex) {
                salida="no se inserto" + ex.ToString();
            }
            return salida;
        }
        public int Validate(string RUC)
        {
            int existe = 0;
            try
            {
                cmd = new SqlCommand("Select * from Empresas Where RUC="+ RUC+"'", SConection);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    existe++;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("consulta fallida= " + ex.ToString());
            }
            return existe;
        }
    }
}
