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
    public partial class frmClientes : Form
    {
        clsControladora unaC = new clsControladora();
        clsECliente unC = new clsECliente();
        public frmClientes()
        {
            InitializeComponent();
        }
        private void frmClientes_Load(object sender, EventArgs e)
        {
            ocultarComponentes();
        }
        private void ocultarComponentes()
        {
            btnAgregar2.Visible = false;
            btnEliminar2.Visible = false;
            btnModificar2.Visible = false;
            txtID.Visible = false;
            txtNombre.Visible = false;
            txtTelefono.Visible = false;
            txtDireccion.Visible = false;
            dgvClientes.Visible = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ocultarComponentes();
            txtNombre.Visible = true;
            txtTelefono.Visible = true;
            txtDireccion.Visible = true;
            btnAgregar2.Visible = true;
        }
        private void btnAgregar2_Click(object sender, EventArgs e)
        {
            unC.nombre = txtNombre.Text;
            unC.telefono = Convert.ToInt32(txtTelefono.Text);
            unC.direccion = txtDireccion.Text;
            unaC.altaCliente(unC);
            MessageBox.Show("Cliente agregado");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ocultarComponentes();
            txtID.Visible = true;
            btnEliminar2.Visible = true;
        }
        private void btnEliminar2_Click(object sender, EventArgs e)
        {
            unC.idCliente = Convert.ToInt32(txtID.Text);
            unaC.bajaCliente(unC);
            MessageBox.Show("Cliente eliminado");
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            ocultarComponentes();
            txtID.Visible = true;
            txtNombre.Visible = true;
            txtTelefono.Visible = true;
            txtDireccion.Visible = true;
            btnModificar2.Visible = true;
        }

        private void btnModificar2_Click(object sender, EventArgs e)
        {
            unC.idCliente = Convert.ToInt32(txtID.Text);
            unC.nombre = txtNombre.Text;
            unC.telefono = Convert.ToInt32(txtTelefono.Text);
            unC.direccion = txtDireccion.Text;
            unaC.modificarCliente(unC);
            MessageBox.Show("Cliente modificado");
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            dgvClientes.Visible = true;
            dgvClientes.DataSource = unaC.listarClientes();
        }

       
    }
}
