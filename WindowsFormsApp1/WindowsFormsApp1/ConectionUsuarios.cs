﻿using System;
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
        public int Validate(string usuario,string password)
        {
            int validado = 0;
            try
            {
                SConection = new SqlConnection("Data source= 192.168.0.101,1433; initial catalog=moodCont; user id=marcoConection; password=Conection");
                SConection.Open();
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
