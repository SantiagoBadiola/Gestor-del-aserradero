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
    public partial class frmRodales : Form
    {
        clsControladora unaC = new clsControladora();
        clsERodal unER = new clsERodal();
        public frmRodales()
        {
            InitializeComponent();
        }
        private void frmRodales_Load(object sender, EventArgs e)
        {
            ocultarComponentes();
        }
        private void ocultarComponentes()
        {
            btnAgregar2.Visible = false;
            btnEliminar2.Visible = false;
            btnModificar2.Visible = false;
            txtIDRodal.Visible = false;
            txtFecha.Visible = false;
            txtTamanio.Visible = false;
            txtEspecie.Visible = false;
            dgvRodales.Visible = false;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ocultarComponentes();
            btnAgregar2.Visible = true;
            txtIDRodal.Visible = true;
            txtFecha.Visible = true;
            txtTamanio.Visible = true;
            txtEspecie.Visible = true;
        }

        private void btnAgregar2_Click(object sender, EventArgs e)
        {
            unER.idRodal = Convert.ToInt32(txtIDRodal.Text);
            unER.tamanio = Convert.ToInt32(txtTamanio.Text);
            unER.fecha = txtTamanio.Text;
            unER.especie = Convert.ToInt32(txtEspecie.Text);
            unaC.altaRodal(unER);
            MessageBox.Show("Rodal agregado");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ocultarComponentes();
            txtIDRodal.Visible = true;
            btnEliminar2.Visible = true;
        }

        private void btnEliminar2_Click(object sender, EventArgs e)
        {
            unER.idRodal = Convert.ToInt32(txtIDRodal.Text);
            unaC.bajaRodal(unER);
            MessageBox.Show("Rodal eliminado");
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ocultarComponentes();
            btnModificar2.Visible = true;
            txtIDRodal.Visible = true;
            txtFecha.Visible = true;
            txtTamanio.Visible = true;
            txtEspecie.Visible = true;
        }

        private void btnModificar2_Click(object sender, EventArgs e)
        {
            unER.idRodal = Convert.ToInt32(txtIDRodal.Text);
            unER.tamanio = Convert.ToInt32(txtTamanio.Text);
            unER.fecha = txtTamanio.Text;
            unER.especie = Convert.ToInt32(txtEspecie.Text);
            unaC.modificarRodal(unER);
            MessageBox.Show("Rodal modificado");
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            dgvRodales.Visible = true;
            dgvRodales.DataSource = unaC.listarRodales();
        }
    }
}
