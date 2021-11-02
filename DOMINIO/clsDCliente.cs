using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDADES;
using PERSISTENCIA;

namespace DOMINIO
{
    public class clsDCliente
    {
        public void altaCliente(clsECliente unEC)
        {
            clsPCliente unPC = new clsPCliente();
            unPC.altaCliente(unEC);

        }

        public void bajaCliente(clsECliente unEC)
        {
            clsPCliente unPC = new clsPCliente();
            unPC.bajaCliente(unEC);

        }

        public void modificarCliente(clsECliente unEC)
        {
            clsPCliente unPC = new clsPCliente();
            unPC.modificarCliente(unEC);

        }

        public List<clsECliente> listarClientes()
        {
            clsPCliente unPC = new clsPCliente();

            return unPC.listarClientes();

        }
    }
}
