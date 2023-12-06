using LogicaTarea.Autobuses;
using LogicaTarea.Conductores;
using LogicaTarea.Rutas;
using LogicaTarea.Terminales;
using System;


namespace Tarea_1
{
    public class Program
    {
        static MetodosTerminal metodosTerminal;
        static MetodosConductor metodosConductor;
        static MetodosAutobus metodosAutobus;
        static MetodosRuta metodosRuta;
        public static void Main(string[] args)
        {
            metodosTerminal = new MetodosTerminal();
            metodosConductor = new MetodosConductor();
            metodosAutobus = new MetodosAutobus();
            metodosRuta = new MetodosRuta(metodosTerminal);
            metodosTerminal.terminales[0] = new Terminal(20, "quepos", "quepos", "20", DateTime.Now, DateTime.Now, true);
            metodosTerminal.terminales[1] = new Terminal(30, "san jose", "san jose", "10", DateTime.Now, DateTime.Now, false);
            do
            {
                try
                {
                    MostrarMenu();
                    break;
                }
                catch (Exception)
                { Console.WriteLine("Ingrese el numero correctamente"); }
                Console.ReadKey();
                Console.Clear();
            } while (true);
        }

        private static void MostrarMenu()
        {
            int op;
            do
            {//aqui se crea el menu de la consola

                Console.WriteLine("Elige una opción\n");
                Console.WriteLine("1.Registrar Terminales");
                Console.WriteLine("2.Registrar Conductores");
                Console.WriteLine("3.Registrar Autobúses");
                Console.WriteLine("4.Registrar Rutas");
                Console.WriteLine("5.Registro de Roles");
                Console.WriteLine("6.Consultar Terminales");
                Console.WriteLine("7.Consultar Conductores");
                Console.WriteLine("8.Consultar Autobuses");
                Console.WriteLine("9.Consultar Rutas");
                Console.WriteLine("10.Consultar de Roles");


                op = int.Parse(Console.ReadLine());

                //aqui se entra a la opción que digite la persona
                switch (op)
                {
                    case 1:
                        metodosTerminal.RegistrarTerminal();


                        break;


                    case 2:
                        metodosConductor.RegistrarConductor();
                        break;

                    case 3:
                        metodosAutobus.RegistrarAutobus();
                        break;

                    case 4:
                        metodosRuta.RegistrarRutas();

                        break;

                    case 5:

                        break;

                    case 6:
                        metodosTerminal.ConsultarTerminales();
                        break;

                    case 7:
                        metodosConductor.ConsultarConductores();
                        break;

                    case 8:
                        metodosAutobus.ConsultarAutobus();
                        break;
                    case 9:

                        metodosRuta.ConsultarRutas();

                        break;
                    case 10:

                        break;

                    default:
                        Console.WriteLine("Seleccione una opción valida");
                        break;


                }
            } while (op != 0);




        }
    }
}
