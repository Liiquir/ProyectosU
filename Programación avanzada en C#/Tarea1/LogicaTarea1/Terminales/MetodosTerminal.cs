using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaTarea1.Terminales
{
    public class MetodosTerminal
    {
        private int posicion { get; set; }
        public Terminal[] terminales;
        public MetodosTerminal()
        {
            terminales = new Terminal[20];
            posicion = 0;

        }

        public void RegistrarTerminal()
        {

            try
            {
                Console.Clear();
                Console.WriteLine("Registro de Terminales\n");
                Console.WriteLine("ID de la terminal generado");
                int idTerminal;
                idTerminal = GenerarNum();
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
                Console.WriteLine("Ingrese el estado(Activo o Inactivo)");
                bool estado = Console.ReadLine().ToLower().Equals("activo") ? true : false;
                this.terminales[posicion] = new Terminal(idTerminal, nombreTerminal,
                direccionTerminal, telefonoTerminal, horaApertura, horaCierre, estado);
                this.posicion++;
                Console.WriteLine("Terminal agregada");

                Console.ReadKey();
                Console.Clear();
            }
            catch (Exception e)
            {
                Console.WriteLine("error");
                Console.ReadKey();
                Console.Clear();
                RegistrarTerminal();

            }





        }

        public void ConsultarTerminales()
        {           
            if (terminales.Any())
            {
                foreach(Terminal terminal in terminales)
                {
                    Console.WriteLine(terminal.ImprimirDatos+"\n");
                }
            }
            else
            {
                Console.WriteLine("No existen terminales registradas.");
            }


        }
        public Terminal? ExisteTerminal(int idTerminal)
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



        private static int GenerarNum()
        {
            int min = 1;
            int max = 999;
            Random rnd = new Random();
            int numero = rnd.Next(min, max);

            return numero;
        }
    }

}
