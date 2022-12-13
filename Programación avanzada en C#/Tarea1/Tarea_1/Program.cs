using LogicaTarea;
using LogicaTarea.Autobuses;
using LogicaTarea.Conductores;
using LogicaTarea.Roles;
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
        static MetodosRol metodosRol;
        public static void Main(string[] args)
        {   //instancia de las clases
            metodosTerminal = new MetodosTerminal();
            metodosConductor = new MetodosConductor();
            metodosAutobus = new MetodosAutobus();
            metodosRuta = new MetodosRuta(metodosTerminal);
            metodosRol = new MetodosRol(metodosRuta, metodosAutobus, metodosConductor); 
                                                                                       
            
            
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
                Console.WriteLine("0.Salir");
                Console.WriteLine("1.Registrar Terminales");
                Console.WriteLine("2.Registrar Conductores");
                Console.WriteLine("3.Registrar Autobúses");
                Console.WriteLine("4.Registrar Rutas");
                Console.WriteLine("5.Registro de Roles");
                Console.WriteLine("6.Consulta de terminales");
                Console.WriteLine("7.Consulta de conductores");
                Console.WriteLine("8.Consulta de autobuses");
                Console.WriteLine("9.Consulta de rutas");
                Console.WriteLine("10.Consulta de roles");


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
                        metodosRol.Validaciones();
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
                        metodosRol.ConsultarRoles();
                        break;

                    default:
                        Console.WriteLine("Seleccione una opción valida");
                        break;


                }
            } while (op != 0);




        }
    }
}
