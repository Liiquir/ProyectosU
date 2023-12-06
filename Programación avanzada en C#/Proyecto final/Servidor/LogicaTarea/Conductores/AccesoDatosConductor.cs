using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using LogicaTarea.Terminales;

namespace LogicaTarea.Conductores
{
    public class AccesoDatosConductor
    {
        
        BDComun cadenaConexion = new BDComun();
        
        public bool AgregarConductor(Conductor pConductor)//metodo para agregar el conductor a la base de datos
        {

            bool result = false;
            SqlConnection connection = new SqlConnection(cadenaConexion.ObtenerConexion());//para obtener la cadena de conexion
            SqlCommand comando = new SqlCommand();
            string sentencia;

            sentencia =
                "Insert into Conductor(NUM_CEDULA,NOM_NOMBRE,NOM_APELLIDO_1,NOM_APELLIDO_2,FEC_NACIMIENTO,TIP_GENERO,BIT_SUPERVISOR)" + // la sentencia que se ejecuta en la base de datos y le 
                "values(@NUM_CEDULA,@NOM_NOMBRE,@NOM_APELLIDO_1,@NOM_APELLIDO_2,@FEC_NACIMIENTO,@TIP_GENERO,@BIT_SUPERVISOR)";          //dice que hacer
            comando.CommandType = CommandType.Text;
            comando.CommandText = sentencia;
            comando.Connection = connection;
            comando.Parameters.AddWithValue("@NUM_CEDULA", pConductor.NUM_CEDULA);//se guarda cada dato en su respectivo espacio
            comando.Parameters.AddWithValue("@NOM_NOMBRE", pConductor.NOM_NOMBRE);
            comando.Parameters.AddWithValue("@NOM_APELLIDO_1", pConductor.NOM_APELLIDO_1);
            comando.Parameters.AddWithValue("@NOM_APELLIDO_2", pConductor.NOM_APELLIDO_2);
            comando.Parameters.AddWithValue("@FEC_NACIMIENTO", pConductor.FEC_NACIMIENTO);
            comando.Parameters.AddWithValue("@TIP_GENERO", pConductor.TIP_GENERO);
            comando.Parameters.AddWithValue("@BIT_SUPERVISOR", pConductor.BIT_SUPERVISOR);
            connection.Open();
            if (comando.ExecuteNonQuery() > 0) result = true;
            connection.Close();
            return result;
        }
        public List<Conductor> ObtenerConductores()//metodo para obtener los conductores registrados
        {
            List<Conductor> ListaConductores = new List<Conductor>();
            SqlConnection connection = new SqlConnection(cadenaConexion.ObtenerConexion());
            SqlCommand comando = new SqlCommand();
            string sentencia;
            SqlDataReader reader;
            sentencia =
            "Select NUM_CEDULA,NOM_NOMBRE,NOM_APELLIDO_1,NOM_APELLIDO_2,FEC_NACIMIENTO,TIP_GENERO,BIT_SUPERVISOR from CONDUCTOR";

            comando.CommandType = CommandType.Text;
            comando.CommandText = sentencia;
            comando.Connection = connection;
            connection.Open();
            reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    ListaConductores.Add(new Conductor
                    {
                        NUM_CEDULA = reader.GetString(0),
                        NOM_NOMBRE = reader.GetString(1),
                        NOM_APELLIDO_1 = reader.GetString(2),
                        NOM_APELLIDO_2 = reader.GetString(3),
                        FEC_NACIMIENTO = reader.GetDateTime(4),
                        TIP_GENERO = reader.GetString(5).ToCharArray()[0],
                        BIT_SUPERVISOR = reader.GetBoolean(6)

                    }); //todos estos datos de guardan en un lista que se muestra usando un datagrid
                }
            }
            connection.Close();
            return ListaConductores;//devuelve la lista
        }
    }
}
