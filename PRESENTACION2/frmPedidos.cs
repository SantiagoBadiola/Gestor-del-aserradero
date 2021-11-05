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
using DOMINIO;

namespace PRESENTACION2
{
    public partial class frmPedidos : Form
    {
        clsEPedido unEP = new clsEPedido();
        clsControladora unaC = new clsControladora();
        public frmPedidos()
        {
            InitializeComponent();
        }

        private void ocultarbotones() {
            btnAgregar2.Visible = false;
            btnEliminar2.Visible = false;
            btnModificar2.Visible = false;
        }

        private void ocultarCajas()
        {
            txtidPedido.Visible = false;
            txtFechaIni.Visible = false;
            txtFechaLim.Visible = false;
            txtCantSoli.Visible = false;
            txtCantAsig.Visible = false;
            txtClienteID.Visible = false;
            txtIDPro.Visible = false;
        }
        private void frmPedidos_Load(object sender, EventArgs e)
        {
            ocultarCajas();
            ocultarbotones();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ocultarbotones();
            ocultarCajas();
            txtidPedido.Visible = true;
            txtFechaIni.Visible = true;
            txtFechaLim.Visible = true;
            txtCantSoli.Visible = true;
            txtCantAsig.Visible = true;
            txtClienteID.Visible = true;
            
            btnAgregar2.Visible = true;
        }

        private void btnAgregar2_Click(object sender, EventArgs e)
        {
            unEP.idPedido = Convert.ToInt32(txtidPedido.Text);
            unEP.FechaInicial = txtFechaIni.Text;
            unEP.FechaLimite = txtFechaLim.Text;
            unEP.cantSoli = Convert.ToInt32(txtCantSoli.Text);
            unEP.cantAsig = Convert.ToInt32(txtCantAsig.Text);
            unEP.idCliente = Convert.ToInt32(txtClienteID.Text);
            unaC.altaPedido(unEP);
            MessageBox.Show(" Pedido agregado");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ocultarbotones();
            ocultarCajas();
            txtidPedido.Visible = true;
            btnEliminar2.Visible = true;
        }

        private void btnEliminar2_Click(object sender, EventArgs e)
        {
            unEP.idPedido = Convert.ToInt32(txtidPedido.Text);
            unaC.bajaPedido(unEP);
            MessageBox.Show(" Pedido eliminado");
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ocultarbotones();
            ocultarCajas();
            txtidPedido.Visible = true;
            txtFechaIni.Visible = true;
            txtFechaLim.Visible = true;
            txtCantSoli.Visible = true;
            txtCantAsig.Visible = true;
            txtClienteID.Visible = true;
            btnModificar2.Visible = true;
        }

        private void btnModificar2_Click(object sender, EventArgs e)
        {
            unEP.idPedido = Convert.ToInt32(txtidPedido.Text);
            unEP.FechaInicial = txtFechaIni.Text;
            unEP.FechaLimite = txtFechaLim.Text;
            unEP.cantSoli = Convert.ToInt32(txtCantSoli.Text);
            unEP.cantAsig = Convert.ToInt32(txtCantAsig.Text);
            unEP.idCliente = Convert.ToInt32(txtClienteID.Text);
            unaC.modificarPedido(unEP);
            MessageBox.Show(" Pedido modificado");
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            dgvPedidos.Visible = true;
            dgvPedidos.DataSource = unaC.listarPedidos();
        }

        
    }
}
