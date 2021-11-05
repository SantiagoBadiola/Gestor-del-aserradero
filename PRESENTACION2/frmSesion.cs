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

namespace WindowsFormsApplication2
{
    public partial class frmSesion : Form
    {
        public frmSesion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clsControladora unaC = new clsControladora();

            clsEUsuario unEU = new clsEUsuario();


            unEU = unaC.login(txtID.Text, Contrasena.Text);
        
             if((txtID == null) || (Contrasena == null))
            {
                MessageBox.Show("Campos vacios");
            }

            if (unEU == null)
            {
                MessageBox.Show("Usuario y/o constraseña incorrectos"); //Muestra un mensaje de error

            }
            else
            {   //Si los datos coinciden se abre el menu principal
                PRESENTACION2.frmPrincipal unFP = new PRESENTACION2.frmPrincipal();
                unFP.elUsuario = unEU;
                unFP.Show();
                this.Hide();
            }

            
        }
    }
}
