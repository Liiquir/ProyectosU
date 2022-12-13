using LogicaTarea.Roles;
using System;

namespace LogicaTarea.Terminales
{
    public class MetodosTerminal
    {
        private int posicion { get; set; }
        public Terminal[] terminales;
        public MetodosTerminal()
        {   //creo el arreglo de 20 posiciones como se pide
            terminales = new Terminal[20];
            posicion = 0;
        }
        public void RegistrarTerminal()//metodo para registrar las terminales
        {
            try
            {
                
                Console.WriteLine("Registro de Terminales\n");
                Console.WriteLine("ID de la terminal generado");
                int idTerminal;
                idTerminal = posicion+1;
                Console.WriteLine(idTerminal);
                Console.WriteLine("Ingrese el Nombre de la terminal");
                string nombreTerminal = Console.ReadLine();
                Console.WriteLine("Ingrese la dirección de la terminal");
                string direccionTerminal = Console.ReadLine();
                Console.WriteLine("Ingrese el telefono de la terminal");
                string telefonoTerminal = Console.ReadLine();
                Console.WriteLine("Ingrese la hora de apertura(HH:mm)");
                string hora = Console.ReadLine();
                DateTime horaApertura = DateTime.ParseExact(hora, "HH:mm", null);
                Console.WriteLine("Ingrese la hora de cierre(HH:mm)");
                hora = Console.ReadLine();
                DateTime horaCierre = DateTime.ParseExact(hora, "HH:mm", null);
                string estados;
                bool estado;
                do
                {
                    //while para que mientras ingrese algo distinto a activo o inactivo vuelva a pedirlo
                    Console.WriteLine("Estado(Activo o Inactivo)");
                    estados = Console.ReadLine();
                    estado = estados.ToLower().Equals("activo") ? true : false;
                } while (!estados.ToLower().Equals("activo") && !estados.ToLower().Equals("inactivo"));
                this.terminales[posicion] = new Terminal(idTerminal, nombreTerminal,
                direccionTerminal, telefonoTerminal, horaApertura, horaCierre, estado);
                this.posicion++;
                Console.WriteLine("Terminal agregada");
                Console.ReadKey();
                Console.Clear();
            }
            catch (Exception)
            {
                Console.WriteLine("error");
                Console.ReadKey();
                Console.Clear();
                RegistrarTerminal();
            }
        }

        public void ConsultarTerminales()//metodo para consultar las terminales
        {

            if (terminales[0] == null)
            {
                Console.WriteLine("\nNo existen terminales registradas\n");
                Console.ReadKey();
                return;
            }
            else
            {
                Console.WriteLine("\nConsulta de terminales\n");
                int id = 0;
                while (terminales[id] != null)
                {

                    Console.WriteLine(terminales[id].ImprimirDatos());

                    id++;
                }
            }

        }
        public Terminal ExisteTerminal(int idTerminal)//este metodo lo utilizo en la clase de metodos ruta que es para verificar que la id ingresada en
                                                     //metodos ruta existe, si existe me devuelve la terminal correspondiente a la id ingresada
        {
            int id = 0;
            while (terminales[id] != null)
            {
                if (terminales[id].IdTerminal == idTerminal)
                {
                    return terminales[id];
                }
                id++;
            }
            return null;
        }
        
    }

}
