using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicaTarea.Terminales;

namespace LogicaTarea.Roles
{
    public class AccesoDatosRol
    {
        BDComun cadenaConexion = new BDComun();
        public bool AgregarRol(Rol pRol)//metodo para agregar el rol
        {
            bool result = false;
            SqlConnection connection = new SqlConnection(cadenaConexion.ObtenerConexion()); // se obtiene la cadena de conexion
            SqlCommand comando = new SqlCommand();
            string sentencia;

            sentencia = "Insert into ROL (FEC_ROL,TIM_HORA_SALIDA,NUM_RUTA,NUM_IDENTIFICACION_BUS,NUM_CEDULA_CONDUCTOR)" + //se ejecuta la sentencia para indicar lo que se quiere hacer
             "values(@FEC_ROL,@TIM_HORA_SALIDA,@NUM_RUTA,@NUM_IDENTIFICACION_BUS,@NUM_CEDULA_CONDUCTOR)";                  //en este caso es para insertar el rol en la base de datos

            comando.CommandType = CommandType.Text;
            comando.CommandText = sentencia;
            comando.Connection = connection;
            comando.Parameters.AddWithValue("@FEC_ROL", pRol.FEC_ROL);
            comando.Parameters.AddWithValue("@TIM_HORA_SALIDA", pRol.TIM_HORA_SALIDA); //se le indica cada espacio a cada variable
            comando.Parameters.AddWithValue("@NUM_RUTA", pRol.NUM_RUTA);
            comando.Parameters.AddWithValue("@NUM_IDENTIFICACION_BUS", pRol.NUM_IDENTIFICACION_BUS);
            comando.Parameters.AddWithValue("@NUM_CEDULA_CONDUCTOR", pRol.NUM_CEDULA_CONDUCTOR);
            
            connection.Open();
            if (comando.ExecuteNonQuery() > 0) result = true;
            connection.Close();
            return result;
        }
        public bool logins(string numeroCedula) //metodo para obtener el numero de cedula de conductor y verificar si existe
        {
            List<Conductor> listaConductores = new List<Conductor>(); //se recorre la lista que guarda los conductores
            
            for (int i = 0; i < listaConductores.Count; i++)
            {
                if (listaConductores[i].NUM_CEDULA.Contains(numeroCedula)) // si el numero de cedula existe que devuelda verdadero, el metodo recibe un string por paramero
                {                                                          //que vendria a ser los datos que se escribirian en la caja de texto
                   
                    
                    return true;

                }
                else
                {
                    return false;
                }
            }
            return false;
        }
    }
}
