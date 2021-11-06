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
    public partial class frmEspecies : Form
    {
        clsEEspecie unEE = new clsEEspecie();
        clsControladora unaC = new clsControladora();
        public frmEspecies()
        {
            InitializeComponent();
        }
        private void ocultarComponentes()
        {
            txtID.Visible = false;
            txtNombre.Visible = false;
            btnAgregar2.Visible = false;
            btnEliminar2.Visible = false;
            btnModificar2.Visible = false;
            dgvEspecie.Visible = false;
        }
       
        private void frmEspecies_Load(object sender, EventArgs e)
        {
            ocultarComponentes();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ocultarComponentes();
            txtNombre.Visible = true;
            btnAgregar2.Visible = true;
        }

        private void btnAgregar2_Click(object sender, EventArgs e)
        {
            unEE.nombre = txtNombre.Text;
            unaC.altaEspecie(unEE);
            MessageBox.Show("Especie agregada");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ocultarComponentes();
            txtID.Visible = true;
            btnEliminar2.Visible = true;
        }

        private void btnEliminar2_Click(object sender, EventArgs e)
        {
            unEE.idEspecie = Convert.ToInt32(txtID.Text);
            unaC.bajaEspecie(unEE);
            MessageBox.Show("Especie eliminada");
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ocultarComponentes();
            txtID.Visible = true;
            txtNombre.Visible = true;
            btnModificar2.Visible = true;
        }

        private void btnModificar2_Click(object sender, EventArgs e)
        {
            unEE.idEspecie = Convert.ToInt32(txtID.Text);
            unEE.nombre = txtNombre.Text;
            unaC.modificarEspecie(unEE);
            MessageBox.Show("Especie editada");
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            ocultarComponentes();
            dgvEspecie.Visible = true;
            dgvEspecie.DataSource = unaC.listarEspecie();
        }
    }
}
