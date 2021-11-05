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

namespace PRESENTACION2
{
    public partial class frmInformesUsuario : Form
    {
        clsControladora unaC = new clsControladora();
        clsEUsuario unEU = new clsEUsuario();
        public frmInformesUsuario()
        {
            InitializeComponent();
        }

        private void btnI1_Click(object sender, EventArgs e)
        {
            unEU.CI = Convert.ToInt32(txtConsulta.Text);
        }
    }
}
