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
    public partial class frmLote : Form
    {
        clsControladora unaC = new clsControladora();
        clsELote unEL = new clsELote();
        public frmLote()
        {
            InitializeComponent();
        }
        private void frmLote_Load(object sender, EventArgs e)
        {
            ocultarComponentes();
        }
        private void ocultarComponentes()
        {
            btnAgregar2.Visible = false;
            btnEliminar2.Visible = false;
            btnModificar2.Visible = false;
            txtID.Visible = false;
            txtFecha.Visible = false;
            txtCantidad.Visible = false;
            txtUsuario.Visible = false;
            dgvLotes.Visible = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ocultarComponentes();
            txtID.Visible = true;
            txtFecha.Visible = true;
            txtCantidad.Visible = true;
            txtUsuario.Visible = true;
            btnAgregar2.Visible = true;
        }

        private void btnAgregar2_Click(object sender, EventArgs e)
        {
            unEL.idLote = Convert.ToInt32(txtID.Text);
            unEL.fecha = txtFecha.Text;
            unEL.cantidad = Convert.ToInt32(txtCantidad.Text);
            unEL.usuario = Convert.ToInt32(txtUsuario.Text);
            unaC.altaLote(unEL);
            MessageBox.Show("Lote agregado");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ocultarComponentes();
            txtID.Visible = true;
            btnEliminar2.Visible = true;
        }

        private void btnEliminar2_Click(object sender, EventArgs e)
        {
            unEL.idLote = Convert.ToInt32(txtID.Text);
            unaC.bajaLote(unEL);
            MessageBox.Show("Lote eliminado");
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ocultarComponentes();
            txtID.Visible = true;
            txtFecha.Visible = true;
            txtCantidad.Visible = true;
            txtUsuario.Visible = true;
            btnModificar2.Visible = true;
        }

        private void btnModificar2_Click(object sender, EventArgs e)
        {
            unEL.idLote = Convert.ToInt32(txtID.Text);
            unEL.fecha = txtFecha.Text;
            unEL.cantidad = Convert.ToInt32(txtCantidad.Text);
            unEL.usuario = Convert.ToInt32(txtUsuario.Text);
            unaC.modificarLote(unEL);
            MessageBox.Show("Lote modificado");
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            dgvLotes.Visible = true;
            dgvLotes.DataSource = unaC.listarLotes();
        }
    }
}
