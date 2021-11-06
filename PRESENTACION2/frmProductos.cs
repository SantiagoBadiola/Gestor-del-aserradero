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
    public partial class frmProductos : Form
    {

        clsEProducto unEP = new clsEProducto();
        clsControladora unaC = new clsControladora();
        public frmProductos()
        {
            InitializeComponent();
        }

        private void ocultarComponentes()
        {
            txtidPro.Visible = false;
            txtPNombre.Visible = false;
            txtCantidad.Visible = false;
            txtPrecio.Visible = false;
            txtLote.Visible = false;
            btnAgregar2.Visible = false;
            btnEliminar2.Visible = false;
            btnModificar2.Visible = false;
            dgvProductos.Visible = false;
        }

        
        private void frmProductos_Load(object sender, EventArgs e)
        {
            ocultarComponentes();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ocultarComponentes();
            txtPNombre.Visible = true;
            txtCantidad.Visible = true;
            txtPrecio.Visible = true;
            txtLote.Visible = true; 
            btnAgregar2.Visible = true;
        }

        private void btnAgregar2_Click(object sender, EventArgs e)
        {
            unEP.NombrePro = txtPNombre.Text;
            unEP.cantidad = Convert.ToInt32(txtCantidad.Text);
            unEP.precio_u = Convert.ToInt32(txtPrecio.Text);
            unEP.lote = Convert.ToInt32(txtLote.Text);
            unaC.altaProducto(unEP);
            MessageBox.Show(" Producto agregado"); 
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ocultarComponentes();
            txtidPro.Visible = true;
            btnEliminar2.Visible = true;

        }

        private void btnEliminar2_Click(object sender, EventArgs e)
        {
            unEP.idProducto = Convert.ToInt32(txtidPro.Text);
            unaC.bajaProducto(unEP);
            MessageBox.Show(" Producto eliminado");
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ocultarComponentes();
            txtidPro.Visible = true;
            txtPNombre.Visible = true;
            txtCantidad.Visible = true;
            txtPrecio.Visible = true;
            txtLote.Visible = true;
            btnModificar2.Visible = true;
        }

        private void btnModificar2_Click(object sender, EventArgs e)
        {
            unEP.idProducto = Convert.ToInt32(txtidPro.Text);
            unEP.NombrePro = txtPNombre.Text;
            unEP.cantidad = Convert.ToInt32(txtCantidad.Text);
            unEP.precio_u = Convert.ToInt32(txtPrecio.Text);
            unEP.lote = Convert.ToInt32(txtLote.Text);
            unaC.modificarProducto(unEP);
            MessageBox.Show(" Producto modificado");
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            ocultarComponentes();
            dgvProductos.Visible = true;
            dgvProductos.DataSource = unaC.listarProductos();
        }

        
    }
    
}
