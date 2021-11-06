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
            dtpFechI.Visible = false;
            dtpFechaL.Visible = false;
            lblFInicial.Visible = false;
            lblFLimite.Visible = false;
            txtCantSoli.Visible = false;
            txtCantAsig.Visible = false;
            txtClienteID.Visible = false;
            txtIDPro.Visible = false;
            cmbClientes.Visible = false;
            dgvPedidos.Visible = false;
        }
        private void frmPedidos_Load(object sender, EventArgs e)
        {
            ocultarCajas();
            ocultarbotones();
            //var colClientes = unaC.listarClientes();
            //foreach (clsECliente  unCliente in colClientes){
            //    cmbClientes.Items.Add(unCliente.nombre);
            //    cmbClientes.ValueMember = Convert.ToString(unCliente.idCliente);
            //}
            cmbClientes.DataSource = unaC.listarClientes();
            cmbClientes.ValueMember = "idCliente";
            cmbClientes.DisplayMember = "nombre";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ocultarbotones();
            ocultarCajas();
            cmbClientes.DataSource = unaC.listarClientes();
            cmbClientes.ValueMember = "idCliente";
            cmbClientes.DisplayMember = "nombre";
           // txtidPedido.Visible = true;
            dtpFechI.Visible = true;
            dtpFechaL.Visible = true;
            lblFInicial.Visible = true;
            lblFLimite.Visible = true;
            txtCantSoli.Visible = true;
            txtCantAsig.Visible = true;
            txtClienteID.Visible = true;
            txtIDPro.Visible = true;
            btnAgregar2.Visible = true;
            cmbClientes.Visible = true;
        }

        private void btnAgregar2_Click(object sender, EventArgs e)
        {
           // unEP.idPedido = Convert.ToInt32(txtidPedido.Text);
            unEP.FechaInicial = dtpFechI.Value.Date.ToShortDateString();
            unEP.FechaLimite = dtpFechaL.Value.Date.ToShortDateString();
            unEP.cantSoli = Convert.ToInt32(txtCantSoli.Text);
            unEP.cantAsig = Convert.ToInt32(txtCantAsig.Text);
            //unEP.idCliente = cmbClientes.SelectedValue.ToString();
            unEP.idProducto = Convert.ToInt32(txtIDPro.Text); ;
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
            dtpFechI.Visible = true;
            dtpFechaL.Visible = true;
            lblFInicial.Visible = true;
            lblFLimite.Visible = true;
            txtCantSoli.Visible = true;
            txtCantAsig.Visible = true;
            txtClienteID.Visible = true;
            txtIDPro.Visible = true;

            btnModificar2.Visible = true;
        }

        private void btnModificar2_Click(object sender, EventArgs e)
        {
            unEP.idPedido = Convert.ToInt32(txtidPedido.Text);
            unEP.FechaInicial = dtpFechI.Value.Date.ToShortDateString();
            unEP.FechaLimite = dtpFechaL.Value.Date.ToShortDateString();
            unEP.cantSoli = Convert.ToInt32(txtCantSoli.Text);
            unEP.cantAsig = Convert.ToInt32(txtCantAsig.Text);
            unEP.idCliente = Convert.ToInt32(txtClienteID.Text);
            unaC.modificarPedido(unEP);
            MessageBox.Show("Pedido modificado");
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            dgvPedidos.Visible = true;
            dgvPedidos.DataSource = unaC.listarPedidos();
        }

        private void cmbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtClienteID.Text = cmbClientes.ValueMember.ToString();

        }

        private void cmbClientes_SelectedValueChanged(object sender, EventArgs e)
        {
            txtClienteID.Text = cmbClientes.SelectedValue.ToString();
        }
    }
}
