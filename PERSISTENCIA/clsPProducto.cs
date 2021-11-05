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
    public class clsPProducto : clsPersistencia
    {
        public void altaProducto(clsEProducto unEP)
        {
            string consulta;
            consulta = "INSERT INTO producto VALUES('"+ unEP.idProducto + "','" + unEP.NombrePro + "','" + unEP.cantidad + "','" + unEP.precio_u + "','"  + unEP.lote + "');";
            ejecutarSQL(consulta);
        }

        public void bajaProducto(clsEProducto unEP)
        {
            string consulta;
            consulta = "DELETE FROM producto WHERE idPro=" + unEP.idProducto;
            ejecutarSQL(consulta);
        }

        public void modificarProducto(clsEProducto unEP)
        {
            string consulta;
            consulta = "UPDATE producto SET  NombrePro='" + unEP.NombrePro + "',cantidad='" + unEP.cantidad  + "',precio_u='" + unEP.precio_u + "',lote='" + unEP.lote + "' WHERE idPro=" + unEP.idProducto;
            ejecutarSQL(consulta);
        }

        public List<clsEProducto> listarProductos()
        {
            List<clsEProducto> colProductos = new List<clsEProducto>();
            MySqlDataReader datos;
            string consulta;
            clsEProducto unEP;
            consulta = "SELECT * FROM producto";
            datos = ejecutarYdevolver(consulta);

            while (datos.Read())
            {
                unEP = recrearProducto(datos);
                colProductos.Add(unEP);
            }

            return colProductos;
        }

        private clsEProducto recrearProducto(MySqlDataReader unaFila)
        {
            clsEProducto unEP = new clsEProducto();
            unEP.idProducto = unaFila.GetInt32("idPro");
            unEP.NombrePro = unaFila.GetString("NombrePro");
            unEP.cantidad = unaFila.GetInt32("cantidad");
            unEP.precio_u = unaFila.GetInt32("precio_u");
            unEP.lote = unaFila.GetInt32("lote");
            return unEP;

        }
    }
}
