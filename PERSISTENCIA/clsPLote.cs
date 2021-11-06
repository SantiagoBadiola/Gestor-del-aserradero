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
    public class clsPLote : clsPersistencia
    {
        public void altaLote(clsELote unEL)
        {
            string consulta;
            consulta = "INSERT INTO lote VALUES(0,'" + unEL.fecha + "','" + unEL.cantidad + "','" + unEL.usuario + "');";
            ejecutarSQL(consulta);
        }

        public void bajaLote(clsELote unEL)
        {
            string consulta;
            consulta = "DELETE FROM lote WHERE idLote=" + unEL.idLote;
            ejecutarSQL(consulta);
        }

        public void modificarLote(clsELote unEL)
        {
            string consulta;
            consulta = "UPDATE lote SET  fecha='" + unEL.fecha + "',cantidad='" + unEL.cantidad + "',usuario='" + unEL.usuario + "' WHERE idLote=" + unEL.idLote;
            ejecutarSQL(consulta);
        }

        public List<clsELote> listarLotes()
        {
            List<clsELote> colLotes = new List<clsELote>();
            MySqlDataReader datos;
            string consulta;
            clsELote unEL;
            consulta = "SELECT * FROM lote";
            datos = ejecutarYdevolver(consulta);

            while (datos.Read())
            {
                unEL = recrearLotes(datos);
                colLotes.Add(unEL);
            }

            return colLotes;
        }



        private clsELote recrearLotes(MySqlDataReader unaFila)
        {
            clsELote unEL = new clsELote();
            unEL.idLote = unaFila.GetInt32("idLote");
            unEL.fecha = unaFila.GetString("fecha");
            unEL.cantidad = unaFila.GetInt32("cantidad");
            unEL.usuario = unaFila.GetInt32("usuario");
            return unEL;

        }
    }
}
