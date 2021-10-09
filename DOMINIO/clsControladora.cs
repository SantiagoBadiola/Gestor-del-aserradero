using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDADES;

namespace DOMINIO
{
    public class clsControladora
    {
        public clsEUsuario login(string usu, string contra) 
        {
            clsDUsuario unDU = new clsDUsuario();
            return unDU.login(usu, contra);
        }
    }
}
