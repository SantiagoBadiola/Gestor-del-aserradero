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
    public partial class frmTrozas : Form
    {
        clsControladora unaC = new clsControladora();
        clsETroza unET = new clsETroza();
        public frmTrozas()
        {
            InitializeComponent();
        }
        private void frmTrozas_Load(object sender, EventArgs e)
        {
            ocultarComponentes();
        }
        private void ocultarComponentes()
        {
            btnAgregar2.Visible = false;
            btnEliminar2.Visible = false;
            btnModificar2.Visible = false;
            txtIDTroza.Visible = false;
            txtMedida.Visible = false;
            txtRodal.Visible = false;
            dgvTrozas.Visible = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ocultarComponentes();
            txtMedida.Visible = true;
            txtRodal.Visible = true;
            btnAgregar2.Visible = true;
        }

        private void btnAgregar2_Click(object sender, EventArgs e)
        {
            unET.medidad = txtMedida.Text;
            unET.rodal = Convert.ToInt32(txtRodal.Text);
            unaC.altaTroza(unET);
            MessageBox.Show("Troza agregada");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ocultarComponentes();
            txtIDTroza.Visible = true;
            btnEliminar2.Visible = true;
        }

        private void btnEliminar2_Click(object sender, EventArgs e)
        {
            unET.idTroza = Convert.ToInt32(txtIDTroza.Text);
            unaC.bajaTroza(unET);
            MessageBox.Show("Troza agregada");
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ocultarComponentes();
            txtIDTroza.Visible = true;
            txtMedida.Visible = true;
            txtRodal.Visible = true;
            btnModificar2.Visible = true;

        }

        private void btnModificar2_Click(object sender, EventArgs e)
        {
            unET.idTroza = Convert.ToInt32(txtIDTroza.Text);
            unET.medidad = txtMedida.Text;
            unET.rodal = Convert.ToInt32(txtRodal.Text);
            unaC.modificarTroza(unET);
            MessageBox.Show("Troza modificada");
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            ocultarComponentes();
            dgvTrozas.Visible = true;
            dgvTrozas.DataSource = unaC.listarTrozas();
        }

        
    }
}
