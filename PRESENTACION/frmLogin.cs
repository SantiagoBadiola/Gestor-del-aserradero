using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DOMINIO;
using ENTIDADES;

namespace PRESENTACION
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            clsControladora unaC = new clsControladora();

            clsEUsuario unEU = new clsEUsuario(); 

            unEU = unaC.login(txtNombre.Text, txtContra.Text); 

            if (unEU == null)
            {  
                MessageBox.Show("Usuario y/o constraseña incorrectos"); //Muestra un mensaje de error

            }
            else
            {   //Si los datos coinciden se abre el menu principal
                
            }
        }
    }
}
