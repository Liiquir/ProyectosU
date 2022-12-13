using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using ProyectoServidor.Entidades;
using Newtonsoft.Json;

namespace ServidorProyecto
{
    public class ClienteTCP
    {
        private static IPAddress ipServidor;
        private static TcpClient cliente;
        private static IPEndPoint serverEndPoint;
        private static StreamWriter clienteStreamWriter;
        private static StreamReader clienteStreamReader;

        public static bool Conectar(string pIdentificadorCliente)  //metodo para conectarse al servidor
        {
            try
            {
                ipServidor = IPAddress.Parse("127.0.0.1");
                cliente = new TcpClient();
                serverEndPoint = new IPEndPoint(ipServidor, 14100);
                cliente.Connect(serverEndPoint);
                MensajeSocket<string> mensajeConectar = new MensajeSocket<string> { Metodo = "Conectar", Entidad = pIdentificadorCliente };

                clienteStreamReader = new StreamReader(cliente.GetStream());
                clienteStreamWriter = new StreamWriter(cliente.GetStream());
                clienteStreamWriter.WriteLine(JsonConvert.SerializeObject(mensajeConectar));
                clienteStreamWriter.Flush();


            }
            catch (SocketException)
            {

                return false;
            }

            return true;
        }
        public static List<Rol> ObtenerRoles(string idRuta) //este metodo era para intentar obtener los roles
        {
            List<Rol> listaRoles = new List<Rol>();
            MensajeSocket<string> mensajeObtenerLibrosDeAutor = new MensajeSocket<string> { Metodo = "ObtenerRoles", Entidad = idRuta };

            clienteStreamWriter.WriteLine(JsonConvert.SerializeObject(mensajeObtenerLibrosDeAutor));
            clienteStreamWriter.Flush();

            var mensaje = clienteStreamReader.ReadLine();
            listaRoles = JsonConvert.DeserializeObject<List<Rol>>(mensaje);

            return listaRoles;
        }

        public static void Desconectar(string pIdentificadorCliente)//metodo para desconectarse del servidor
        {
            MensajeSocket<string> mensajeDesconectar = new MensajeSocket<string> { Metodo = "Desconectar", Entidad = pIdentificadorCliente };

            clienteStreamWriter.WriteLine(JsonConvert.SerializeObject(mensajeDesconectar));
            clienteStreamWriter.Flush();
            //Se cierra la conexión del cliente
            cliente.Close();
        }

        public static bool RegistrarRol(Rol pNuevoRol)  //era para intentar regisrar el rol
        {
            try
            {
                MensajeSocket<Rol> mensajeRol = new MensajeSocket<Rol> { Metodo = "AgregarRol", Entidad = pNuevoRol };
                clienteStreamWriter.WriteLine(JsonConvert.SerializeObject(mensajeRol));
                clienteStreamWriter.Flush();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
