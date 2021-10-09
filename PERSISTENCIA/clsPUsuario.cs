using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDADES;
using MySql.Data.MySqlClient;

namespace PERSISTENCIA
{
    public class clsPUsuario : clsPersistencia
    {
        public clsEUsuario login(string usu, string contra)
        {
            MySqlDataReader datos; //objeto que representa las filas de la tabla en memoria
            clsEUsuario unEU = null;
            string consulta; //crea la variable que almacena la consulta
            consulta = "SELECT * FROM aserrader INNER JOIN personas ON usuario.cedula = personas.cedula WHERE usuario='" + usu + "' AND contrasenia='" + contra + "';"; //define la consulta
            datos = ejecutarYdevolver(consulta); //almacena en la variable datos los resultas de la consulta con la BD
            if (datos.Read())
            { 

                unEU = recrearUsuario(datos);

            }
            return unEU; 
        }
        private clsEUsuario recrearUsuario(MySqlDataReader fila) //Recrea al bibliotecario con los datos de la BD
        {
            clsEUsuario unEU = new clsEUsuario();

            unEU.contrasenia = fila.GetString("contrasenia");
            unEU.Nombre = fila.GetString("Nombre");
            

            return unEU; 

        }
    }
}