using LogicaTarea.Terminales;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaTarea.Rutas
{
    public class AccesoDatosRuta
    {       
        BDComun cadenaConexion = new BDComun();       
        public bool AgregarRuta(Ruta pRuta) ////metodo para insetar la ruta que se registra en el servidor
        {
            bool result = false;
            SqlConnection connection = new SqlConnection(cadenaConexion.ObtenerConexion()); //se obtiene la cadena de conexion
            SqlCommand comando = new SqlCommand();
            string sentencia;

            sentencia = "Insert into RUTA (NUM_RUTA,COD_TERMINAL_SALIDA,COD_TERMINAL_LLEGADA,NUM_TARIFA,DSC_RUTA,NUM_TIPO_RUTA,BOL_ESTADO)" + //comando que se ejecuta en la base de datos
             "values(@NUM_RUTA,@COD_TERMINAL_SALIDA,@COD_TERMINAL_LLEGADA,@NUM_TARIFA,@DSC_RUTA,@NUM_TIPO_RUTA,@BOL_ESTADO)";

            comando.CommandType = CommandType.Text;
            comando.CommandText = sentencia;
            comando.Connection = connection;
            comando.Parameters.AddWithValue("@NUM_RUTA", pRuta.NUM_RUTA);
            comando.Parameters.AddWithValue("@COD_TERMINAL_SALIDA", pRuta.COD_TERMINAL_SALIDA);
            comando.Parameters.AddWithValue("@COD_TERMINAL_LLEGADA", pRuta.COD_TERMINAL_LLEGADA);
            comando.Parameters.AddWithValue("@NUM_TARIFA", pRuta.NUM_TARIFA);
            comando.Parameters.AddWithValue("@DSC_RUTA", pRuta.DSC_RUTA);
            comando.Parameters.AddWithValue("@NUM_TIPO_RUTA", pRuta.NUM_TIPO_RUTA);
            comando.Parameters.AddWithValue("@BOL_ESTADO", pRuta.BOL_ESTADO);
            connection.Open();
            if (comando.ExecuteNonQuery() > 0) result = true;
            connection.Close();
            return result;
        }
        public List<ConsultaRutas> ObtenerRuta() //metodo para obtener las rutas registradas 
        {
            List<ConsultaRutas> ListaRuta = new List<ConsultaRutas>();

            SqlConnection connection = new SqlConnection(cadenaConexion.ObtenerConexion());
            SqlCommand comando = new SqlCommand();
            string sentencia;
            SqlDataReader reader;
            sentencia =                   //esta seria la sentencia que se ejecuta en la base de datos para obtener las rutas con todos los datos que se piden en el enunciado
            " SELECT [NUM_RUTA] ,T1.[COD_TERMINAL] ,T1.[NOM_TERMINAL] ,T1.[DIR_TERMINAL] ,T1.[NUM_TELEFONO] ,T1.[TIM_HORA_APERTURA] ,T1.[TIM_HORA_CIERRE] ,T1.[BOL_ESTADO] " +
            ",T2.[COD_TERMINAL] ,T2.[NOM_TERMINAL] ,T2.[DIR_TERMINAL] ,T2.[NUM_TELEFONO] ,T2.[TIM_HORA_APERTURA] ,T2.[TIM_HORA_CIERRE] ,T2.[BOL_ESTADO] ,[NUM_TARIFA] ,[DSC_RUTA]" +
            " ,[NUM_TIPO_RUTA] ,[RUTA].[BOL_ESTADO] FROM [dbo].[RUTA] JOIN TERMINAL T1 ON [COD_TERMINAL_SALIDA] = T1.[COD_TERMINAL] JOIN TERMINAL T2 ON [COD_TERMINAL_SALIDA] = T2.[COD_TERMINAL];";

            comando.CommandType = CommandType.Text;
            comando.CommandText = sentencia;
            comando.Connection = connection;
            connection.Open();
            reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    ListaRuta.Add(new ConsultaRutas
                    {
                        NUM_RUTA_SALIDA = (int)reader.GetSqlDecimal(0),
                        COD_TERMINAL_SALIDA = (int)reader.GetSqlDecimal(1),
                        NOM_TERMINAL_SALIDA = reader.GetString(2),
                        DIR_TERMINAL_SALIDA = reader.GetString(3),
                        NUM_TELEFONO_SALIDA = reader.GetString(4),
                        TIM_HORA_APERTURA_SALIDA = reader.GetTimeSpan(5),
                        TIM_HORA_CIERRE_SALIDA = reader.GetTimeSpan(6),      //se agreg uno por uno a cada variable, para esto hice una clase nueva con todos los datos que se deben recibir
                        BOL_ESTADO_SALIDA = reader.GetBoolean(7),            //supongo que no sera la mejor manera pero es la que se me ocurrio
                        COD_TERMINAL_LLEGADA = (int)reader.GetSqlDecimal(8),
                        NOM_TERMINAL_LLEGADA = reader.GetString(9),
                        DIR_TERMINAL_LLEGADA = reader.GetString(10),
                        NUM_TELEFONO_LLEGADA = reader.GetString(11),
                        TIM_HORA_APERTURA_LLEGADA = reader.GetTimeSpan(12),
                        TIM_HORA_CIERRE_LLEGADA = reader.GetTimeSpan(13),
                        BOL_ESTADO_LLEGADA = reader.GetBoolean(14),
                        NUM_TARIFA = (int)reader.GetSqlDecimal(15),
                        DSC_RUTA = reader.GetString(16),
                        NUM_TIPO_RUTA = (int)reader.GetSqlDecimal(17),
                        BOL_ESTADO = reader.GetBoolean(18)

                    });

                }
            }
            
            connection.Close();
            return ListaRuta;
        }

        public List<Ruta> CargarIdRuta() //metodo para obtener solamente el numero de ruta para en el formulario de registrar ruta asignarlo
        {
            List<Ruta> ListaID = new List<Ruta>();
            SqlConnection connection = new SqlConnection(cadenaConexion.ObtenerConexion());
            SqlCommand comando = new SqlCommand();
            string sentencia;
            SqlDataReader reader;
            sentencia =
            "Select NUM_RUTA from RUTA ";

            comando.CommandType = CommandType.Text;
            comando.CommandText = sentencia;
            comando.Connection = connection;
            connection.Open();
            reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    ListaID.Add(new Ruta
                    {

                        NUM_RUTA = (int)reader.GetSqlDecimal(0)


                    });
                }
            }
            connection.Close();
            return ListaID;
        }

        public int ConsultarID()//aqui es donde recorro la lista de las rutas para contar la cantidad de rutas y asi poder asignarle un valor a la ruta
        {
            int contador = 1;
            List<Ruta> resultado = CargarIdRuta();
            for (int i = 0; i < resultado.Count; i++)
            {
                if (resultado[i] != null)
                {
                    contador++;
                }
            }
            
            return contador;
        }
        


    }
}
