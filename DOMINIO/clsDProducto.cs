using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDADES;
using PERSISTENCIA;

namespace DOMINIO
{
    public class clsDProducto
    {
        public void altaProducto(clsEProducto unEP)
        {
            clsPProducto unPP = new clsPProducto();
            unPP.altaProducto(unEP);

        }

        public void bajaProducto(clsEProducto unEP)
        {
            clsPProducto unPP = new clsPProducto();
            unPP.bajaProducto(unEP);

        }

        public void modificarProducto(clsEProducto unEP)
        {
            clsPProducto unPP = new clsPProducto();
            unPP.modificarProducto(unEP);

        }

        public List<clsEProducto> listarProductos()
        {
            clsPProducto unPP = new clsPProducto();

            return unPP.listarProductos();

        }
    }
}
