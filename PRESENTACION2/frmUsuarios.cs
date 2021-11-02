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
    public partial class frmUsuarios : Form
    {
        public clsEUsuario elUsuario { get; set; }
        clsEUsuario unEU = new clsEUsuario();
        clsControladora unaC = new clsControladora();
        
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void ocultarCajas() {
            txtUID.Visible = false;
            txtUNombre.Visible = false;
            txtUApellido.Visible = false;
            txtUContrasenia.Visible = false;
            cmbUTipo.Visible = false;
            dgvUsuarios.Visible = false;
        }

        private void ocultarBotones2() {
            btnAgregar2.Visible = false;
            btnEliminar2.Visible = false;
            btnModificar2.Visible = false;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //if (elUsuario.tipo == "administrador") { 
            //    btnAgregar.Enabled = false;
            //    btnEliminar.Enabled = false;
            //    btnModificar.Enabled = false;
            //  }
            ocultarCajas();
            ocultarBotones2();
            

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ocultarCajas();
            ocultarBotones2();
            txtUID.Visible = true;
            txtUNombre.Visible = true;
            txtUApellido.Visible = true;
            txtUContrasenia.Visible = true;
            cmbUTipo.Visible = true;
            btnAgregar2.Visible = true;
        }

        private void btnAgregar2_Click(object sender, EventArgs e)
        {
            unEU.CI = Convert.ToInt32(txtUID.Text);
            unEU.nombre = txtUNombre.Text;
            unEU.apellido = txtUApellido.Text;
            unEU.contrasenia = txtUContrasenia.Text;
            unEU.tipo = cmbUTipo.Text;
            unaC.altaUsuario(unEU);
            MessageBox.Show("Usuario ingresado");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
           
           ocultarCajas();
           ocultarBotones2();
            txtUID.Visible = true;
            btnEliminar2.Visible = true;
        }

        private void btnEliminar2_Click(object sender, EventArgs e)
        {
            unEU.CI = Convert.ToInt32(txtUID.Text);
            unaC.bajaUsuario(unEU);
            MessageBox.Show("Usuario eliminado");
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            ocultarCajas();
            ocultarBotones2();
            dgvUsuarios.Visible = true;
            dgvUsuarios.DataSource = unaC.listarUsuarios();
        }

        private void txtVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal unFP = new frmPrincipal();
            unFP.Show();
            this.Hide();
           
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ocultarCajas();
            ocultarBotones2();
            txtUID.Visible = true;
            txtUNombre.Visible = true;
            txtUApellido.Visible = true;
            txtUContrasenia.Visible = true;
            cmbUTipo.Visible = true;
            btnModificar2.Visible = true;

        }

        private void btnModificar2_Click(object sender, EventArgs e)
        {
            unEU.CI = Convert.ToInt32(txtUID.Text);
            unEU.nombre = txtUNombre.Text;
            unEU.apellido = txtUApellido.Text;
            unEU.contrasenia = txtUContrasenia.Text;
            unEU.tipo = cmbUTipo.Text;
            unaC.modificarUsuario(unEU);
            MessageBox.Show("Usuario modificado");
        }

    }
}
