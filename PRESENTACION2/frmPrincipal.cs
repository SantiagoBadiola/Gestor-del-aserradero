using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENTIDADES;

namespace PRESENTACION2
{
    public partial class frmPrincipal : Form
    {
        public clsEUsuario elUsuario { get; set; }
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblBienvenido.Text = "Hola " + elUsuario.nombre;
            if (elUsuario.tipo == "estandar")
            {
                btnUsuarios.Enabled = false;


            }

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            frmUsuarios unFU = new frmUsuarios();//
            unFU.Show();
            this.Hide();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            frmProductos unFU = new frmProductos();
            unFU.Show();
            this.Hide();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            frmPedidos unFP = new frmPedidos();
            unFP.Show();
            this.Hide();
        }
    }
}
