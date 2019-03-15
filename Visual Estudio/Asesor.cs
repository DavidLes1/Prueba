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
    public partial class Asesor : Form
    {
        Conexion c = new Conexion();
        String nom;
        public Asesor(String nombre)

        {
            InitializeComponent();
            this.CenterToScreen();
            lblNombreAsesor.Text = nombre;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                nom = "Soat";
                lbl1.Text = "Placa del Auto";
                lbl2.Text = "Marca del Auto";
                tBox1.Enabled = true;
                tBox2.Enabled = true;
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                checkBox4.Enabled = false;
            }
        } 

        private void button2_Click(object sender, EventArgs e)
        {
            checkBox1.Enabled = true;
            checkBox2.Enabled = true;
            checkBox3.Enabled = true;
            checkBox4.Enabled = true;
            tBoxId.Text = " ";
            tBoxNom.Text = " ";
            tBoxApe.Text = " ";
            tBoxTel.Text = " ";
            lbl1.Text = " ";
            lbl2.Text = " ";
            tBox1.Enabled = false;
            tBox2.Enabled = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                nom = "Auto";
                lbl1.Text = "Placa del Auto";
                lbl2.Text = "Marca del Auto";
                tBox1.Enabled = true;
                tBox2.Enabled = true;
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                checkBox4.Enabled = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                nom = "Hogar";
                lbl1.Text = "Direccion";
                tBox1.Enabled = true;
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                checkBox4.Enabled = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                nom = "Vieaje";
                lbl1.Text = "Destino";
                tBox1.Enabled = true;
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                checkBox4.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //if (c.PersonaRegistrada(Convert.ToInt32(tBoxId.Text)) == 0)
            //{
                //MessageBox.Show(c.insertar(Convert.ToInt32(tBoxId.Text), tBoxNom.Text, tBoxApe.Text, tBoxTel.Text, nom));
            //} else
            //{
               MessageBox.Show("EL registro del Cliente ya Existe");
            //}
        }
    }
}
