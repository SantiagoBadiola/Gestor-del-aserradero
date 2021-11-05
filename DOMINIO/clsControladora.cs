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
        // LOGIN
        public clsEUsuario login(string usu, string contra) 
        {
            clsDUsuario unDU = new clsDUsuario();
            return unDU.login(usu, contra);
        }

        // USUARIOS
        public void altaUsuario(clsEUsuario unEU)
        {
            clsDUsuario unDU = new clsDUsuario();
            unDU.altaUsuario(unEU);
        }

        public void bajaUsuario(clsEUsuario unEU)
        {
            clsDUsuario unDU = new clsDUsuario();
            unDU.bajaUsuario(unEU);
        }

        public void modificarUsuario(clsEUsuario unEU)
        {
            clsDUsuario unDU = new clsDUsuario();
            unDU.modificarUsuario(unEU);
        }

        public List<clsEUsuario> listarUsuarios()
        {
            clsDUsuario unDU = new clsDUsuario();

            return unDU.listarUsuarios();

        }

        // PEDIDO

        public void altaPedido(clsEPedido unEP)
        {
            clsDPedido unDP = new clsDPedido();
            unDP.altaPedido(unEP);

        }

        public void bajaPedido(clsEPedido unEP)
        { 
        clsDPedido unDP = new clsDPedido();
        unDP.bajaPedido(unEP);
        }

        public void modificarPedido(clsEPedido unEP)
        {
            clsDPedido unDP = new clsDPedido();
            unDP.modificarPedido(unEP);
        }

        public List<clsEPedido> listarPedidos()
        {
            clsDPedido unDP = new clsDPedido();

            return unDP.listarPedidos();

        }

        // CLIENTE

        public void altaCliente(clsECliente unEC)
        {
            clsDCliente unDC = new clsDCliente();
            unDC.altaCliente(unEC);

        }

        public void bajaCliente(clsECliente unEC)
        {
            clsDCliente unDC = new clsDCliente();
            unDC.bajaCliente(unEC);

        }

        public void modificarCliente(clsECliente unEC)
        {
            clsDCliente unDC = new clsDCliente();
            unDC.modificarCliente(unEC);

        }

        public List<clsECliente> listarClientes()
        {
            clsDCliente unDC = new clsDCliente();

            return unDC.listarClientes();

        }

        //PRODUCTO

        public void altaProducto(clsEProducto unEP)
        {
            clsDProducto unDP = new clsDProducto();
            unDP.altaProducto(unEP);

        }
        public void bajaProducto(clsEProducto unEP)
        {
            clsDProducto unDP = new clsDProducto();
            unDP.bajaProducto(unEP);

        }
        public void modificarProducto(clsEProducto unEP)
        {
            clsDProducto unDP = new clsDProducto();
            unDP.modificarProducto(unEP);

        }
        public List<clsEProducto> listarProductos()
        {
            clsDProducto unDP = new clsDProducto();

            return unDP.listarProductos();

        }

        //RODAL

        public void altaRodal(clsERodal unER)
        {
            clsDRodal unDR = new clsDRodal();
            unDR.altaRodal(unER);

        }

        public void bajaRodal(clsERodal unER)
        {
            clsDRodal unDR = new clsDRodal();
            unDR.bajaRodal(unER);

        }

        public void modificarRodal(clsERodal unER)
        {
            clsDRodal unDR = new clsDRodal();
            unDR.modificarRodal(unER);

        }

        public List<clsERodal> listarRodales()
        {
            clsDRodal unDR = new clsDRodal();

            return unDR.listarRodales();

        }

        //TROZA

        public void altaTroza(clsETroza unET)
        {
            clsDTroza unDT = new clsDTroza();
            unDT.altaTroza(unET);

        }
        public void bajaTroza(clsETroza unET)
        {
            clsDTroza unDT = new clsDTroza();
            unDT.bajaTroza(unET);

        }

        public void modificarTroza(clsETroza unET)
        {
            clsDTroza unDT = new clsDTroza();
            unDT.modificarTroza(unET);

        }

        public List<clsETroza> listarTrozas()
        {
            clsDTroza unDT = new clsDTroza();

            return unDT.listarTrozas();

        }

        //ESPECIE
        public void altaEspecie(clsEEspecie unEE)
        {
            clsDEspecie unDE = new clsDEspecie();
            unDE.altaEspecie(unEE);
        }

        public void bajaEspecie(clsEEspecie unEE)
        {
            clsDEspecie unDE = new clsDEspecie();
            unDE.bajaEspecie(unEE);
        }

        public void modificarEspecie(clsEEspecie unEE)
        {
            clsDEspecie unDE = new clsDEspecie();
            unDE.modificarEspecie(unEE);
        }

        public List<clsEEspecie> listarEspecie()
        {
            clsDEspecie unDE = new clsDEspecie();

            return unDE.listarEspecies();
        }

        //LOTE
        public void altaLote(clsELote unEL)
        {
            clsDLote unDL = new clsDLote();
            unDL.altaLote(unEL);
        }
        public void bajaLote(clsELote unEL)
        {
            clsDLote unDL = new clsDLote();
            unDL.bajaLote(unEL);
        }
        public void modificarLote(clsELote unEL)
        {
            clsDLote unDL = new clsDLote();
            unDL.modificarLote(unEL);
        }
        public List<clsELote> listarLotes()
        {
            clsDLote unDL = new clsDLote();

            return unDL.listarLotes();
        }

    }
}
