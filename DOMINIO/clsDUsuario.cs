using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDADES;
using PERSISTENCIA;

namespace DOMINIO
{
    public class clsDUsuario
    {
        public clsEUsuario login(string usu, string contra) //Pasa la entidad bibliotecario a la capa de Persistencia 
        {
            clsPUsuario unPU = new clsPUsuario();
            return unPU.login(usu, contra);
        }
    }
}
