using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Falabella
{

    public partial class Fraiz : Form
    {

        SqlConnection con = new SqlConnection("Data Source=LAPTOP-U95R0S9C;Initial Catalog=Falabella;Integrated Security=True");
        SqlCommand cmd;
        public Fraiz()
        {
            InitializeComponent();
            this.CenterToScreen();
            Rena();
        }

        public void Rena()
        {
            cmd = new SqlCommand("select * from Seguros where Id='F_raiz'", con);
            con.Open();
            SqlDataReader Registro = cmd.ExecuteReader();
            if (Registro.Read())
            {
                txtPrecio.Text = Registro["Precio_Seguro"].ToString();
                txtTiempo.Text = Registro["Tiempo_Validacion"].ToString();
            }
            con.Close();
        }
    }
}
