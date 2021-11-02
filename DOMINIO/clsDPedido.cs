using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDADES;
using PERSISTENCIA;

namespace DOMINIO
{
    public class clsDPedido
    {
        public void altaPedido(clsEPedido unEP)
        {
            clsPPedido unPP = new clsPPedido();
            unPP.altaPedido(unEP);

        }

        public void bajaPedido(clsEPedido unEP)
        {
            clsPPedido unPP = new clsPPedido();
            unPP.bajaPedido(unEP);
        }

        public void modificarPedido(clsEPedido unEP)
        {
            clsPPedido unPP = new clsPPedido();
            unPP.modificarPedido(unEP);
        }

        public List<clsEPedido> listarPedidos()
        {
            clsPPedido unPP = new clsPPedido();

            return unPP.listarPedidos();

        }
    }
}
