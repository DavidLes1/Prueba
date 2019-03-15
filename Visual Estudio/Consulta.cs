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
    public partial class Consulta : Form
    {

        SqlConnection con = new SqlConnection("Data Source=LAPTOP-U95R0S9C;Initial Catalog=Falabella;Integrated Security=True");
        SqlCommand cmd;
        public Consulta()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select * from Ventas where Id=@Id", con);
            cmd.Parameters.AddWithValue("@Id", txtbus.Text);
            con.Open();
            SqlDataReader Registro = cmd.ExecuteReader();
            if (Registro.Read())
            {
                txtId.Text = Registro["Id"].ToString();
                txtnom.Text = Registro["Nombre"].ToString();
                txtApe.Text = Registro["Apellido"].ToString();
                txtTel.Text = Registro["Telefono"].ToString();
                txtSer.Text = Registro["Servicio"].ToString();
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtbus.Text = " ";
            txtId.Text = " ";
            txtnom.Text = " ";
            txtApe.Text = " ";
            txtTel.Text = " ";
            txtSer.Text = " ";
        }
    }
}
