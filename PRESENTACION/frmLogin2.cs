using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DOMINIO;
using ENTIDADES;

namespace WindowsFormsApplication2
{
    public partial class InicioDeSesion : Form
    {
        public InicioDeSesion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clsControladora unaC = new clsControladora();

            clsEUsuario unEU = new clsEUsuario();

            unEU = unaC.login(Usuario.Text, Contrasena.Text);

            if (unEU == null)
            {
                MessageBox.Show("Usuario y/o constraseña incorrectos"); //Muestra un mensaje de error

            }
            else
            {   //Si los datos coinciden se abre el menu principal

            }
        }

        private void Contraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
