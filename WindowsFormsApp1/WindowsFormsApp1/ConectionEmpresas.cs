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
        //Verifica conexion
        public void conectionEmpresas()
        {
            try
            {
                SConection = new SqlConnection("Data Source=192.168.0.100,1433;Initial Catalog= moodCont;user id=mao;password=123");
                SConection.Open();
                MessageBox.Show("conectado");
            }
            catch(Exception ex){
                MessageBox.Show("no se conecto" + ex.ToString());
            }
        }
        //Insertar empresa
        public string insert(string RUC, string Nombre, int anio, int mes,string direccion,string libros_electronicos,string Regimen_tributario) 
        {
            string salida = "se inserto";
            try
            {
                SConection = new SqlConnection("Data Source=DARKPEARL\\SQLEXPRESS01;Initial Catalog= moodCont;Integrated Security=true");
                SConection.Open();
                cmd = new SqlCommand("Insert into Empresas(nombre,RUC,direccion,P_anio,P_mes,regimen_tributario,libros_electronicos) values('" + Nombre + "','" + RUC + "','" + direccion + "','" + anio + "','" + mes+ "','" + Regimen_tributario + "','" + libros_electronicos + "')", SConection);
                cmd.ExecuteNonQuery();
            } catch (Exception ex) {
                salida="no se inserto" + ex.ToString();
            }
            return salida;
        }
        //Validar existencia de empresa
        public int Validate(string RUC)
        {
            int existe = 0;
            try
            {
                SConection = new SqlConnection("Data Source=DARKPEARL\\SQLEXPRESS01;Initial Catalog= moodCont;Integrated Security=true");
                SConection.Open();
                cmd = new SqlCommand("SELECT * FROM Empresas Where RUC='"+ RUC +"'", SConection);
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
