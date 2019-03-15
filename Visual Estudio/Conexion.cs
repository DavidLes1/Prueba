using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Falabella
{
    class Conexion
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader rd;

        public Conexion()
        {
            try
            {
                con = new SqlConnection("Data Source=LAPTOP-U95R0S9C;Initial Catalog=Falabella;Integrated Security=True");
                con.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error"+ex.ToString());
            }
        }

        public string insertar (int Id, string Nombre, string Apellido, string Telefono, string Servicio)
        {
            string Salida = "Se ha realizado la Venta";
            try
            {
                cmd = new SqlCommand("insert into Ventas(Id,Nombre,Apellido,Telefono,Servicio) values ("+Id+",'"+Nombre+"','"+Apellido+"','"+Telefono+"','"+Servicio+"') ",con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Salida = "No se puedo realizar la venta: " + ex.ToString();
            }
            return Salida;
        }

        public int PersonaRegistrada(int Id)
        {
            int contador = '0';
            try
            {
                cmd = new SqlCommand("Select Id from Ventas where Id="+Id+"", con);
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    contador++;
                }
                rd.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.ToString());
            }
            return contador;
        }

        public void Renault()
        {
            cmd = new SqlCommand("select * from Seguros where Id='Renault'",con);
            con.Open();
            SqlDataReader Registro = cmd.ExecuteReader();
            if (Registro.Read())
            {

            }

        }
    }
}
