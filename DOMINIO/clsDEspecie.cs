using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDADES;
using PERSISTENCIA;

namespace DOMINIO
{
    public class clsDEspecie
    {
        public void altaEspecie(clsEEspecie unEE)
        {
            clsPEspecie unPE = new clsPEspecie();
            unPE.altaEspecie(unEE);

        }

        public void bajaEspecie(clsEEspecie unEE)
        {
            clsPEspecie unPE = new clsPEspecie();
            unPE.bajaEspecie(unEE);
        }

        public void modificarEspecie(clsEEspecie unEE)
        {
            clsPEspecie unPE = new clsPEspecie();
            unPE.modificarEspecie(unEE);
        }

        public List<clsEEspecie> listarEspecies()
        {
            clsPEspecie unPE = new clsPEspecie();

            return unPE.listarEspecies();

        }
    }
}
