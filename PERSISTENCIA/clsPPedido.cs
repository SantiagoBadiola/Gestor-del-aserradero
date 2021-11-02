using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDADES;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace PERSISTENCIA
{
    public class clsPPedido : clsPersistencia
    {
        public void altaPedido(clsEPedido unEP)
        {
            string consulta;
            consulta= "INSERT INTO pedido VALUES('" + unEP.idPedido + "','" + unEP.FechaInicial + "','" + unEP.FechaLimite + "','" + unEP.cantSoli + "','" +unEP.cantAsig + "','" + unEP.idCliente + "');";
            ejecutarSQL(consulta);
        }

        public void bajaPedido(clsEPedido unEP)
        {
            string consulta;
            consulta = "DELETE FROM pedido WHERE idPedido=" + unEP.idPedido;
            ejecutarSQL(consulta);
        }

        public void modificarPedido(clsEPedido unEP)
        {
            string consulta;
            consulta = "UPDATE pedido SET  fechaInicial='" + unEP.FechaInicial+ "',fechaLimite='" + unEP.FechaLimite + "',cantSoli='" + unEP.cantSoli + "',cantAsig='" + unEP.cantAsig + "',idCliente='" + unEP.idCliente + "' WHERE idPedido=" + unEP.idPedido;
            ejecutarSQL(consulta);
        }

        public List<clsEPedido> listarPedidos()
        {
            List<clsEPedido> colPedidos = new List<clsEPedido>();
            MySqlDataReader datos;
            string consulta;
            clsEPedido unEP;
            consulta = "SELECT * FROM pedido";
            datos = ejecutarYdevolver(consulta);

            while (datos.Read())
            {
                unEP = recrearPedido(datos);
                colPedidos.Add(unEP);
            }

            return colPedidos;
        }

        private clsEPedido recrearPedido(MySqlDataReader unaFila)
        {
            clsEPedido unEP = new clsEPedido();
            unEP.idPedido = unaFila.GetInt32("idPedido");
            unEP.FechaInicial = unaFila.GetString("fechaInicial");
            unEP.FechaLimite = unaFila.GetString("fechaLimite");
            unEP.cantSoli = unaFila.GetInt32("cantSoli");
            unEP.cantAsig = unaFila.GetInt32("cantAsig");
            unEP.idCliente = unaFila.GetInt32("idCliente");
            return unEP;

        }
    }
}
