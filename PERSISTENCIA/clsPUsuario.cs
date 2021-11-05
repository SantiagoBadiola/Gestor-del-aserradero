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
            consulta = "SELECT * FROM usuario WHERE  CI='" + usu + "' AND contrasenia='" + contra + "';"; //define la consulta
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

            unEU.CI = fila.GetInt32("CI");
            unEU.contrasenia = fila.GetString("contrasenia");
            unEU.nombre = fila.GetString("Nombre");
            unEU.apellido = fila.GetString("apellido");
            unEU.tipo = fila.GetString("tipo");
            return unEU; 

        }

        public void altaUsuario(clsEUsuario unEU)
        {
            string consulta;
            consulta = "INSERT INTO usuario VALUES('" + unEU.CI + "','" + unEU.nombre + "','" + unEU.apellido + "','" + unEU.contrasenia + "','" + unEU.tipo + "');";
            ejecutarSQL(consulta);
        }

        public void bajaUsuario(clsEUsuario unEU)
        {
            string consulta;
            consulta = "DELETE FROM usuario WHERE CI=" + unEU.CI;
            ejecutarSQL(consulta);
        }

        public void modificarUsuario(clsEUsuario unEU)
        {
            string consulta;
            consulta = "UPDATE usuario SET  nombre='" + unEU.nombre + "',apellido='" + unEU.apellido + "',contrasenia='" + unEU.contrasenia + "',tipo='" + unEU.tipo + "' WHERE CI=" + unEU.CI;
            ejecutarSQL(consulta);
        }

        public List<clsEUsuario> listarUsuarios()
        {
            List<clsEUsuario> colUsuarios = new List<clsEUsuario>();
            MySqlDataReader datos;
            string consulta;
            clsEUsuario unEU;
            consulta = "SELECT * FROM usuario";
            datos = ejecutarYdevolver(consulta);

            while (datos.Read())
            {
                unEU = recrearUsuario(datos);
                colUsuarios.Add(unEU);
            }

            return colUsuarios;
        }

        public List<clsEUsuario> informeU()
        {
            List<clsEUsuario> colUsuarios = new List<clsEUsuario>();
            MySqlDataReader datos;
            string consulta;
            clsEUsuario unEU;
            consulta = "SELECT * FROM usuario";
            datos = ejecutarYdevolver(consulta);

            while (datos.Read())
            {
                unEU = recrearUsuario(datos);
                colUsuarios.Add(unEU);
            }

            return colUsuarios;
        }
    }
}