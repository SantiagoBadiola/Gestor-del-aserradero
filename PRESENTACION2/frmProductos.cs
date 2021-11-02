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
            this.Load += Form1_Load;
        }

        private void ocultarCajas()
        {
            txtidPro.Visible = false;
            txtPNombre.Visible = false;
            txtCantidad.Visible = false;
            txtPrecio.Visible = false;
            txtLote.Visible = false;

        }
        private void ocultarbotones()
        {
            btnAgregar2.Visible = false;
            btnEliminar2.Visible = false;
            btnModificar2.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e) { 
            ocultarCajas();
            ocultarbotones();

        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ocultarCajas();
            ocultarbotones();
            txtidPro.Visible = true;
            txtPNombre.Visible = true;
            txtCantidad.Visible = true;
            txtPrecio.Visible = true;
            txtLote.Visible = true; 
            btnAgregar2.Visible = true;
        }

        private void btnAgregar2_Click(object sender, EventArgs e)
        {
            unEP.idProducto = Convert.ToInt32(txtidPro.Text);
            unEP.NombrePro = txtPNombre.Text;
            unEP.cantidad = Convert.ToInt32(txtCantidad.Text);
            unEP.precio_u = Convert.ToInt32(txtPrecio.Text);
            unEP.lote = Convert.ToInt32(txtLote.Text);
            unaC.altaProducto(unEP);
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ocultarbotones();
            ocultarCajas();
            txtidPro.Visible = true;
            btnEliminar2.Visible = true;

        }

        private void btnEliminar2_Click(object sender, EventArgs e)
        {
            unEP.idProducto = Convert.ToInt32(txtidPro.Text);
            unaC.bajaProducto(unEP);

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ocultarbotones();
            ocultarCajas();
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
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            ocultarbotones();
            ocultarCajas();
            dgvProductos.Visible = true;
            dgvProductos.DataSource = unaC.listarProductos();
        }

        
    }
    
}
