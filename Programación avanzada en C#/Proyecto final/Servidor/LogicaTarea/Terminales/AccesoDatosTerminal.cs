using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaTarea.Terminales
{
    
    public class AccesoDatosTerminal
    {
        
        BDComun cadenaConexion = new BDComun();

        
        public bool AgregarTerminal(Terminal pTerminal)  //metodo para registrar la terminal en la base de datos
        {
            bool result = false;
            SqlConnection connection = new SqlConnection(cadenaConexion.ObtenerConexion());
            SqlCommand comando = new SqlCommand();
            string sentencia;

            sentencia = "Insert into TERMINAL(COD_TERMINAL,NOM_TERMINAL,DIR_TERMINAL,NUM_TELEFONO,TIM_HORA_APERTURA,TIM_HORA_CIERRE,BOL_ESTADO)" +
             "values(@COD_TERMINAL,@NOM_TERMINAL,@DIR_TERMINAL,@NUM_TELEFONO,@TIM_HORA_APERTURA,@TIM_HORA_CIERRE,@BOL_ESTADO)";
            
            comando.CommandType = CommandType.Text;
            comando.CommandText = sentencia;
            comando.Connection = connection;
            comando.Parameters.AddWithValue("@COD_TERMINAL", pTerminal.COD_TERMINAL);
            comando.Parameters.AddWithValue("@NOM_TERMINAL", pTerminal.NOM_TERMINAL);
            comando.Parameters.AddWithValue("@DIR_TERMINAL", pTerminal.DIR_TERMINAL);
            comando.Parameters.AddWithValue("@NUM_TELEFONO", pTerminal.NUM_TELEFONO);
            comando.Parameters.AddWithValue("@TIM_HORA_APERTURA", pTerminal.TIM_HORA_APERTURA);
            comando.Parameters.AddWithValue("@TIM_HORA_CIERRE", pTerminal.TIM_HORA_CIERRE);
            comando.Parameters.AddWithValue("@BOL_ESTADO", pTerminal.BOL_ESTADO);

            connection.Open();
            if (comando.ExecuteNonQuery() > 0) result = true;
            connection.Close();
            return result;
        }
        public List<Terminal> ObtenerTerminales()  //metodo para obtener las terminales registradas en la base de datos
        {
            List<Terminal> ListaTerminales = new List<Terminal>();
            SqlConnection connection = new SqlConnection(cadenaConexion.ObtenerConexion());
            SqlCommand comando = new SqlCommand();
            string sentencia;
            SqlDataReader reader;
            sentencia =
            "Select COD_TERMINAL,NOM_TERMINAL,DIR_TERMINAL,NUM_TELEFONO,TIM_HORA_APERTURA,TIM_HORA_CIERRE,BOL_ESTADO from TERMINAL";// sentencia para obtenerlas

            comando.CommandType = CommandType.Text;
            comando.CommandText = sentencia;
            comando.Connection = connection;
            connection.Open();
            reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    ListaTerminales.Add(new Terminal
                    {
                        COD_TERMINAL = (int)reader.GetSqlDecimal(0),
                        NOM_TERMINAL = reader.GetString(1),
                        DIR_TERMINAL = reader.GetString(2),
                        NUM_TELEFONO = reader.GetString(3),
                        TIM_HORA_APERTURA =reader.GetTimeSpan(4),     //cada espacio se agrega a la lista
                        TIM_HORA_CIERRE = reader.GetTimeSpan(5),
                        BOL_ESTADO=reader.GetBoolean(6)

                    });
                }
            }
            connection.Close();
            return ListaTerminales;
        }
        public List<Terminal> CargarTerminales() //esto es para obtener el nombre de las terminales registras y cargas los combo box
        {
            List<Terminal> ListaTerminales = new List<Terminal>();
            SqlConnection connection = new SqlConnection(cadenaConexion.ObtenerConexion());
            SqlCommand comando = new SqlCommand();
            string sentencia;
            SqlDataReader reader;
            sentencia =
            "Select NOM_TERMINAL from TERMINAL";

            comando.CommandType = CommandType.Text;
            comando.CommandText = sentencia;
            comando.Connection = connection;
            connection.Open();
            reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    ListaTerminales.Add(new Terminal
                    {
                        
                        NOM_TERMINAL = reader.GetString(0)
                       

                    });
                }
            }
            connection.Close();
            return ListaTerminales;
        }
        public List<Terminal> CargarIdTerminal() //metodo para consultar las terminales registras 
        {
            List<Terminal> ListaTerminales = new List<Terminal>();
            SqlConnection connection = new SqlConnection(cadenaConexion.ObtenerConexion());
            SqlCommand comando = new SqlCommand();
            string sentencia;
            SqlDataReader reader;
            sentencia =
            "Select COD_TERMINAL from TERMINAL";

            comando.CommandType = CommandType.Text;
            comando.CommandText = sentencia;
            comando.Connection = connection;
            connection.Open();
            reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    ListaTerminales.Add(new Terminal
                    {

                        COD_TERMINAL = (int)reader.GetSqlDecimal(0)


                    });
                }
            }
            connection.Close();
            return ListaTerminales;
        }
        public int ConsultarID() // aqui se utiliza el metodo anterior para contrar la cantidad de terminales y asi asignarle el numero siguiete en la txt de los registros
        {
            int contador = 1;
            List<Terminal> resultado = CargarIdTerminal();
            for (int i = 0; i < resultado.Count; i++)
            {
                if (resultado[i]!=null)
                {
                    contador++;
                }
            }
            return contador;
        }
        
        
    }
}
