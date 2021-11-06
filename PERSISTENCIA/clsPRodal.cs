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
    public class clsPRodal : clsPersistencia
    {
        public void altaRodal(clsERodal unER)
        {
            string consulta;
            consulta = "INSERT INTO rodal VALUES(0,'" + unER.tamanio + "','" + unER.fecha + "','" + unER.especie + "');";
            ejecutarSQL(consulta);
        }

        public void bajaRodal(clsERodal unER)
        {
            string consulta;
            consulta = "DELETE FROM rodal WHERE idRodal=" + unER.idRodal;
            ejecutarSQL(consulta);
        }

        public void modificarRodal(clsERodal unER)
        {
            string consulta;
            consulta = "UPDATE rodal SET  tamanio='" + unER.tamanio + "',fechaDePlantacion='" + unER.fecha + "',especie='" + unER.especie + "' WHERE idRodal=" + unER.idRodal;
            ejecutarSQL(consulta);
        }

        public List<clsERodal> listarRodales()
        {
            List<clsERodal> colRodales = new List<clsERodal>();
            MySqlDataReader datos;
            string consulta;
            clsERodal unER;
            consulta = "SELECT * FROM rodal";
            datos = ejecutarYdevolver(consulta);

            while (datos.Read())
            {
                unER = recrearRodal(datos);
                colRodales.Add(unER);
            }

            return colRodales;
        }

        private clsERodal recrearRodal(MySqlDataReader unaFila)
        {
            clsERodal unER = new clsERodal();
            unER.idRodal = unaFila.GetInt32("idRodal");
            unER.tamanio = unaFila.GetInt32("tamanio");
            unER.fecha = unaFila.GetString("fechaDePlantacion");
            unER.especie = unaFila.GetInt32("especie");
            return unER;

        }

    }
}
