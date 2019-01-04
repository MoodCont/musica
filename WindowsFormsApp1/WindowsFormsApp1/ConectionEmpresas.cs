using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
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
        SqlDataAdapter dataSet;
        DataTable dataTable;
        //Verifica conexion
        public void conectar()
        {
            string ruta="Data Source=192.168.0.101,1433;Initial Catalog= moodCont;user id=marcoConection;password=Conection";
            SConection = new SqlConnection(ruta);
        }
        public void conectionEmpresas()
        {
            try
            {
                conectar();
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
                conectar();
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
                conectar();
                cmd = new SqlCommand("SELECT * FROM Empresas Where RUC='"+ RUC +"'", SConection);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    existe++;
                }
                reader.Close();
            }catch (Exception ex)
            {
                MessageBox.Show("consulta fallida= " + ex.ToString());
            }
            return existe;
        }
        public void Values(DataGridView DGV)
        {
            try
            {
                conectar();
                dataSet = new SqlDataAdapter("select * from Empresas",SConection);
                dataTable = new DataTable();
                dataSet.Fill(dataTable);
                DGV.DataSource = dataTable;
            }
            catch(Exception ex)
            {
                MessageBox.Show("no se pudo mostrar " + ex.ToString());
            }
        }
    }
}
