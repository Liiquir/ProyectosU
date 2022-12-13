using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea1;

namespace LogicaTarea1.Autobuses
{
    public class MetodosAutobus
    {
        private int posicion { get; set; }
        private Autobus[] autobuses;
        public MetodosAutobus()
        {
            autobuses = new Autobus[20];
            posicion = 0;

        }
        public  void RegistrarAutobus()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Registro de Autobuses\n");
                Console.WriteLine("Identificación generada");
                int identificacion = GenerarNum();
                Console.WriteLine(identificacion);
                Console.WriteLine("ID de placa");//validar que no existan repetidas
                string IDplaca = Console.ReadLine();
                foreach (Autobus ra in autobuses)
                {
                    if (ra != null)
                    {
                        if (IDplaca.Equals(ra.IdPlaca))
                        {
                            Console.WriteLine("Este numero de placa ya se ha registado");
                            Console.ReadKey();
                            Console.Clear();
                            RegistrarAutobus();
                        }
                    }
                }
                Console.WriteLine("Marca");
                string Marca = Console.ReadLine();
                Console.WriteLine("Modelo");
                string Modelo = Console.ReadLine();

                string n;
                bool esNumero;
                int Capacidad;
                do
                {
                    //esta idea ha sido tomada del siguiente enlace
                    //https://es.stackoverflow.com/questions/66668/validaci%C3%B3n-de-solo-n%C3%BAmeros-programa-en-consola-c
                    Console.WriteLine("Capacidad");
                    n = Console.ReadLine();
                    /* Si es número correcto retornará true y saldrá
                       *  del Ciclo*/
                    esNumero = int.TryParse(n, out Capacidad);
                    //el if lo agregue yo para dar la indicación
                    if (!esNumero)
                    {
                        Console.WriteLine("Escriba solamente numeros enteros");
                    }
                }
                while (!esNumero);

                Console.WriteLine("Ingrese el estado(Activo o Inactivo)");
                bool estado = Console.ReadLine().ToLower().Equals("activo") ? true : false;
                this.autobuses[posicion] = new Autobus(identificacion, IDplaca, Marca, Modelo, Capacidad, estado);
                Console.WriteLine("Autobus registrado");
                posicion++;
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Ha ocurrido un error");
                Console.ReadKey();
                RegistrarAutobus();
            }
        }


        public  void ConsultarAutobus()
        {

            foreach (Autobus ca in autobuses)
            {
                if (ca != null)
                {
                    Console.WriteLine("Autobuses registrados");
                    Console.WriteLine("Numero de identifación: " + ca.Identificacion + "\n" + "ID placa: " + ca.IdPlaca + "\n" + "Marca: " + ca.Marca + "\n" + "Modelo: " + ca.Modelo + "\n" +
                        "Capacidad: " + ca.capacidad + "\n");
                    if (ca.Estado == true)
                    { Console.WriteLine("Estado: Activo\n"); }

                    else
                    { Console.WriteLine("Estado: Inactivo\n"); }
                }
                else
                {
                    if (ca == null)
                    {
                        Console.WriteLine("No existen mas autobuses registrados");
                        Console.ReadKey();
                        MostrarMenu();
                    }
                }
            }




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
