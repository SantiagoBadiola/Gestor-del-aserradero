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
            consulta = "INSERT INTO rodal VALUES(0,'" +  unER.CantArboles + "','" + unER.fechaDePlantacion + "','" + unER.especie + "');";
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
            consulta = "UPDATE rodal SET  CantArboles='" + unER.CantArboles + "'fechaDePlantacion='" + unER.fechaDePlantacion + "'especie='" + unER.especie + "' WHERE idRodal=" + unER.idRodal;
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
            unER.CantArboles = unaFila.GetInt32("cantArboles");
            unER.fechaDePlantacion = unaFila.GetString("fechaDePlantacion");
            unER.especie = unaFila.GetString("especie");
            return unER;

        }

    }
}
