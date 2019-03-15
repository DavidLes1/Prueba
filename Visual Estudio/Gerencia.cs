using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Falabella
{
    public partial class Gerencia : Form
    {
        public Gerencia(String nombre)
        {
            InitializeComponent();
            this.CenterToScreen();
            lblNombreGerente.Text = nombre;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Renault().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Ford().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Fraiz().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Avianca().Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new Consulta().Show();
        }
    }
}
