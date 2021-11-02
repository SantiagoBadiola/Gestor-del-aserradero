using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDADES;
using PERSISTENCIA;

namespace DOMINIO
{
    public class clsDRodal
    {
        public void altaRodal(clsERodal unER)
        {
            clsPRodal unPR = new clsPRodal();
            unPR.altaRodal(unER);

        }

        public void bajaRodal(clsERodal unER)
        {
            clsPRodal unPR = new clsPRodal();
            unPR.bajaRodal(unER);

        }

        public void modificarRodal(clsERodal unER)
        {
            clsPRodal unPR = new clsPRodal();
            unPR.modificarRodal(unER);

        }

        public List<clsERodal> listarRodales()
        {
            clsPRodal unPR = new clsPRodal();

            return unPR.listarRodales();

        }

    }
}
