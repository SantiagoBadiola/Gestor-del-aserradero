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
    public class clsPTroza : clsPersistencia
    {
        public void altaTroza(clsETroza unET)
        {
            string consulta;
            consulta = "INSERT INTO troza VALUES(0,'" + unET.medidad + "','" + unET.especie + "');";
            ejecutarSQL(consulta);

        }
        public void bajaTroza(clsETroza unET)
        {
            string consulta;
            consulta = "DELETE FROM troza WHERE idTroza=" + unET.idTroza;
            ejecutarSQL(consulta);

        }

        public void modificarTroza(clsETroza unET)
        {
            string consulta;
            consulta = "UPDATE TROZA SET  medida='" + unET.medidad + "'especie='" + unET.especie + "' WHERE idTroza=" + unET.idTroza;
            ejecutarSQL(consulta);

        }

        public List<clsETroza> listarTrozas()
        {
            List<clsETroza> colTrozas = new List<clsETroza>();
            MySqlDataReader datos;
            string consulta;
            clsETroza unET;
            consulta = "SELECT * FROM troza";
            datos = ejecutarYdevolver(consulta);

            while (datos.Read())
            {
                unET = recrearTroza(datos);
                colTrozas.Add(unET);
            }

            return colTrozas;
        }

        private clsETroza recrearTroza(MySqlDataReader unaFila)
        {
            clsETroza unET = new clsETroza();
            unET.idTroza = unaFila.GetInt32("idTroza");
            unET.medidad = unaFila.GetString("medida");
            unET.especie = unaFila.GetString("especie");
            return unET;

        }
    }
}
