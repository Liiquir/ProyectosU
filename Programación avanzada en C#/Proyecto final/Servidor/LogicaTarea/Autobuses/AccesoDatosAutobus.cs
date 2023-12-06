using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicaTarea.Terminales;

namespace LogicaTarea.Autobuses
{
    public class AccesoDatosAutobus
    {
        
        BDComun cadenaConexion=new BDComun();
       
        public bool AgregarAutobus(Autobus pAutobus)  //metodo para agregar el autobus a la base de datos
        {
            bool result = false;
            SqlConnection connection = new SqlConnection(cadenaConexion.ObtenerConexion());
            SqlCommand comando = new SqlCommand();
            string sentencia;

            sentencia =
            "Insert into AUTOBUS(NUM_IDENTIFICACION,NUM_PLACA,DSC_MARCA,NUM_MODELO,NUM_CAPACIDAD,BOL_ESTADO)" +  // esta es la sentencia que se va a ejecutar en la base de datos y es lo que le dice que hacer
            "values(@NUM_IDENTIFICACION,@NUM_PLACA,@DSC_MARCA,@NUM_MODELO,@NUM_CAPACIDAD,@BOL_ESTADO)";
            comando.CommandType = CommandType.Text;
            comando.CommandText = sentencia;
            comando.Connection = connection;
            comando.Parameters.AddWithValue("@NUM_IDENTIFICACION", pAutobus.NUM_IDENTIFICACION);  //aqui se le va indicando el campo que corresponde a cada uno
            comando.Parameters.AddWithValue("@NUM_PLACA", pAutobus.NUM_PLACA);
            comando.Parameters.AddWithValue("@DSC_MARCA", pAutobus.DSC_MARCA);
            comando.Parameters.AddWithValue("@NUM_MODELO", pAutobus.NUM_MODELO);
            comando.Parameters.AddWithValue("@NUM_CAPACIDAD", pAutobus.NUM_CAPACIDAD);
            comando.Parameters.AddWithValue("@BOL_ESTADO", pAutobus.BOL_ESTADO);
            
            connection.Open();//para cerrar la conexion
            if (comando.ExecuteNonQuery() > 0) result = true;
            connection.Close();
            return result;
        }
        public List<Autobus> ObtenerAutobus() //metodo para obtener los autobuses que han sido registrados
        {
            List<Autobus> ListaAutobus = new List<Autobus>();
            SqlConnection connection = new SqlConnection(cadenaConexion.ObtenerConexion());
            SqlCommand comando = new SqlCommand();
            string sentencia;
            SqlDataReader reader;
            sentencia =
            "Select NUM_IDENTIFICACION,NUM_PLACA,DSC_MARCA,NUM_MODELO,NUM_CAPACIDAD,BOL_ESTADO from AUTOBUS";

            comando.CommandType = CommandType.Text;
            comando.CommandText = sentencia;
            comando.Connection = connection;
            connection.Open();
            reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    ListaAutobus.Add(new Autobus
                    {
                        NUM_IDENTIFICACION = (int)reader.GetSqlDecimal(0),
                        NUM_PLACA = reader.GetString(1),
                        DSC_MARCA = reader.GetString(2),
                        NUM_MODELO = (int)reader.GetSqlDecimal(3),
                        NUM_CAPACIDAD = (int)reader.GetSqlDecimal(4),
                        BOL_ESTADO = reader.GetBoolean(5)

                    }) ;  // los datos de guardan en una lista y luego esa lista de usa para cargar los data grid
                }
            }
            connection.Close();
            return ListaAutobus;
        }
        public List<Autobus> CargarIdAutobus() //metodo para consultar las terminales registras 
        {
            List<Autobus> ListaIdAutobus = new List<Autobus>();
            SqlConnection connection = new SqlConnection(cadenaConexion.ObtenerConexion());
            SqlCommand comando = new SqlCommand();
            string sentencia;
            SqlDataReader reader;
            sentencia =
            "Select NUM_IDENTIFICACION from AUTOBUS";

            comando.CommandType = CommandType.Text;
            comando.CommandText = sentencia;
            comando.Connection = connection;
            connection.Open();
            reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    ListaIdAutobus.Add(new Autobus
                    {

                        NUM_IDENTIFICACION = (int)reader.GetSqlDecimal(0)


                    });
                }
            }
            connection.Close();
            return ListaIdAutobus;
        }
        public int ConsultarID() // aqui se utiliza el metodo anterior para contrar la cantidad de autobuses y asi asignarle el numero siguiete en la txt de los registros
        {
            int contador = 1;
            List<Autobus> resultado = CargarIdAutobus();
            for (int i = 0; i < resultado.Count; i++)
            {
                if (resultado[i] != null)
                {
                    contador++;
                }
            }
            return contador;
        }
        public bool validarPlaca(string numeroPlaca)//para validar que el numero de placa no se repita
        {
            List<Autobus> idplaca=ObtenerAutobus();
            try
            {
                for (int i = 0; i < idplaca[i].NUM_PLACA.Length; i++)
                {
                    if (idplaca[i].NUM_PLACA.Equals(numeroPlaca))
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                return false;
            }
            catch (Exception)
            {

                return true;
            }
            
        }
    }
}
