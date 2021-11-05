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

        public void altaUsuario(clsEUsuario unEU)
        {
            clsPUsuario unPU = new clsPUsuario();
            unPU.altaUsuario(unEU);
        }

        public void bajaUsuario(clsEUsuario unEU)
        {
            clsPUsuario unPU = new clsPUsuario();
            unPU.bajaUsuario(unEU);
        }

        public void modificarUsuario(clsEUsuario unEU)
        {
            clsPUsuario unPU = new clsPUsuario();
            unPU.modificarUsuario(unEU);
        }
        public List<clsEUsuario> listarUsuarios()
        {
            clsPUsuario unPU = new clsPUsuario();

            return unPU.listarUsuarios();

        }
        public List<clsEUsuario> informeU()
        {
            clsDUsuario unPU = new clsDUsuario();

            return unPU.informeU();

        }
    }
}
