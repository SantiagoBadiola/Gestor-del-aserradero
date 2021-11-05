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
    public class clsPEspecie : clsPersistencia
    {
        public void altaEspecie(clsEEspecie unEE)
        {
            string consulta;
            consulta = "INSERT INTO especie VALUES('" + unEE.idEspecie + "','" + unEE.nombre + "');";
            ejecutarSQL(consulta);
        }

        public void bajaEspecie(clsEEspecie unEE)
        {
            string consulta;
            consulta = "DELETE FROM especie WHERE idEspecie=" + unEE.idEspecie;
            ejecutarSQL(consulta);
        }

        public void modificarEspecie(clsEEspecie unEE)
        {
            string consulta;
            consulta = "UPDATE especie SET  nombreEspecie='" + unEE.nombre +  "' WHERE idEspecie=" + unEE.idEspecie;
            ejecutarSQL(consulta);
        }

        public List<clsEEspecie> listarEspecies()
        {
            List<clsEEspecie> colEspecies = new List<clsEEspecie>();
            MySqlDataReader datos;
            string consulta;
            clsEEspecie unEE;
            consulta = "SELECT * FROM especie";
            datos = ejecutarYdevolver(consulta);

            while (datos.Read())
            {
                unEE = recrearEspecie(datos);
                colEspecies.Add(unEE);
            }

            return colEspecies;
        }

        private clsEEspecie recrearEspecie(MySqlDataReader unaFila)
        {
            clsEEspecie unEE = new clsEEspecie();
            unEE.idEspecie = unaFila.GetInt32("idEspecie");
            unEE.nombre = unaFila.GetString("nombreEspecie");
            return unEE;

        }
    }
}
