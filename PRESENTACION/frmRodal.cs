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

namespace PRESENTACION
{
    public partial class frmRodal : Form
    {
        public frmRodal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clsERodal unER = new clsERodal();
            unER.CantArboles = Convert.ToInt32(txtArboles.Text);
            unER.fechaDePlantacion = txtFecha.Text;
            unER.especie = txtEspecie.Text;

            clsControladora unaC = new clsControladora();
            unaC.altaRodal(unER);

         
        }

        

    }
}
