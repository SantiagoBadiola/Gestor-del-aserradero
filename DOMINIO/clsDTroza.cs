using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDADES;
using PERSISTENCIA;

namespace DOMINIO
{
    public class clsDTroza
    {
        public void altaTroza(clsETroza unET)
        {
            clsPTroza unPT = new clsPTroza();
            unPT.altaTroza(unET);

        }

        public void bajaTroza(clsETroza unET)
        {
            clsPTroza unPT = new clsPTroza();
            unPT.bajaTroza(unET);

        }

        public void modificarTroza(clsETroza unET)
        {
            clsPTroza unPT = new clsPTroza();
            unPT.modificarTroza(unET);

        }

        public List<clsETroza> listarTrozas()
        {
            clsPTroza unPT = new clsPTroza();

            return unPT.listarTrozas();

        }
    }
}
