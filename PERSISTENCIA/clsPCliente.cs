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
    public class clsPCliente : clsPersistencia
    { 
        public void altaCliente(clsECliente unEC)
        {
            string consulta;
            consulta = "INSERT INTO cliente VALUES(0,'"  + unEC.nombre + "','" + unEC.telefono + "','" + unEC.direccion + "');";
            ejecutarSQL(consulta);
        }

        public void bajaCliente(clsECliente unEC)
        {
            string consulta;
            consulta = "DELETE FROM cliente WHERE idCliente=" + unEC.idCliente;
            ejecutarSQL(consulta);
        }

        public void modificarCliente(clsECliente unEC)
        {
            string consulta;
            consulta = "UPDATE cliente SET  nombre='" + unEC.nombre + "'telefono='" + unEC.telefono + "'direccion='" + unEC.direccion + "' WHERE idPedido=" + unEC.idCliente;
            ejecutarSQL(consulta);
        }

        public List<clsECliente> listarClientes()
        {
            List<clsECliente> colClientes = new List<clsECliente>();
            MySqlDataReader datos;
            string consulta;
            clsECliente unEC;
            consulta = "SELECT * FROM cliente";
            datos = ejecutarYdevolver(consulta);

            while (datos.Read())
            {
                unEC = recrearCliente(datos);
                colClientes.Add(unEC);
            }

            return colClientes;
        }

        private clsECliente recrearCliente(MySqlDataReader unaFila)
        {
            clsECliente unEC = new clsECliente();
            unEC.idCliente = unaFila.GetInt32("idCliente");
            unEC.nombre = unaFila.GetString("nombre");
            unEC.telefono = unaFila.GetInt32("telefono");
            unEC.direccion = unaFila.GetString("direccion");
            return unEC;

        }
    }
}
