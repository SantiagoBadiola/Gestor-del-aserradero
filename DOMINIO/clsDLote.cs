using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDADES;
using PERSISTENCIA;

namespace DOMINIO
{
    public class clsDLote
    {
        public void altaLote(clsELote unEL)
        {
            clsPLote unPL = new clsPLote();
            unPL.altaLote(unEL);
        }

        public void bajaLote(clsELote unEL)
        {
            clsPLote unPL = new clsPLote();
            unPL.bajaLote(unEL);
        }

        public void modificarLote(clsELote unEL)
        {
            clsPLote unPL = new clsPLote();
            unPL.modificarLote(unEL);
        }
        public List<clsELote> listarLotes()
        {
            clsPLote unPL = new clsPLote();

            return unPL.listarLotes();
        }
    }
}
