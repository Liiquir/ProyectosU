using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using LogicaTarea;
using System.Data;
using System.Data.SqlClient;

namespace AccesoDatos
{
    public class AccesoDatosConductor
    {
       
        public bool AgregarConductor(Conductor pConductor)
        {
            bool result = false;
            SqlConnection connection= new SqlConnection(cadenaConexion); 
            SqlCommand comando = new SqlCommand();
            string sentencia;
            
            sentencia =
            "Insert into Cliente(Identificacion,Nombre,PrimerApellido,SegundoApellido,FechaNacimiento,Genero,ConductorSupervisor)" +
            "values(@Identificacion,@nombre,@PrimerApellido,@SegundoApellido,@FechaNacimiento,Genero,Conductor)";
            comando.CommandType = CommandType.Text;
            comando.CommandText = sentencia;
            comando.Connection = connection;
            comando.Parameters.AddWithValue("@Identificacion", pConductor.Identificacion);
            comando.Parameters.AddWithValue("@nombre", pConductor.Nombre);
            comando.Parameters.AddWithValue("@PrimerApellido", pConductor.PrimerApellido);
            comando.Parameters.AddWithValue("@SegundoApellido", pConductor.SegundoApellido);
            comando.Parameters.AddWithValue("@FechaNacimiento", pConductor.FechaNacimiento);
            comando.Parameters.AddWithValue("@Genero", pConductor.Genero);
            comando.Parameters.AddWithValue("@Conductor", pConductor.ConductorSupervisor);
            connection.Open();
            if (comando.ExecuteNonQuery() > 0) result = true;
            connection.Close();
            return result;
        }
        public List<Conductor> ObtenerConductor()
        {
            List<Conductor> ListaConductor = new List<Conductor>();
            SqlConnection connection = new SqlConnection(cadenaConexion);
            SqlCommand comando = new SqlCommand();
            string sentencia;
            SqlDataReader reader;
            sentencia =
            "Select Identificacion,Nombre,PrimerApellido,SegundoApellido,FechaNacimiento,Genero,ConductorSupervisor from dtgvConductores";


            comando.CommandType = CommandType.Text;
            comando.CommandText = sentencia;
            comando.Connection = connection;         
            connection.Open();
            reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    ListaConductor.Add(new Conductor
                    {
                       Identificacion=reader.GetString(0),
                       Nombre=reader.GetString(1),
                       PrimerApellido=reader.GetString(2),
                       SegundoApellido=reader.GetString(3),
                       FechaNacimiento=reader.GetDateTime(4),
                       Genero=Char.Parse(reader.GetString(5)),
                       ConductorSupervisor=reader.GetBoolean(6)
                    });
                }
            }
            connection.Close();
            return ListaConductor;
        }
    }
}
