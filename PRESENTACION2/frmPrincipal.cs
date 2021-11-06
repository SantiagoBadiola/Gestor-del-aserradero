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
            string tipo = elUsuario.tipo;
            if (tipo == "estandar")
            {
                btnUsuarios.Enabled = false;
            }
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            frmUsuarios unFU = new frmUsuarios();//
            unFU.Show();   
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            frmProductos unFU = new frmProductos();
            unFU.Show();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            frmPedidos unFP = new frmPedidos();
            unFP.Show();
        }

        private void btnEspecies_Click(object sender, EventArgs e)
        {
            frmEspecies unFE = new frmEspecies();
            unFE.Show();
        }

        private void btnTrozas_Click(object sender, EventArgs e)
        {
            frmTrozas unFT = new frmTrozas();
            unFT.Show();
        }

        private void btnRodales_Click(object sender, EventArgs e)
        {
            frmRodales unFR = new frmRodales();
            unFR.Show();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmClientes unFR = new frmClientes();
            unFR.Show();
        }

        private void btnLotes_Click(object sender, EventArgs e)
        {
            frmLote unFL = new frmLote();
            unFL.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
