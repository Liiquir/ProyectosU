using LogicaTarea.Roles;
using LogicaTarea.Terminales;
using System;

namespace LogicaTarea.Autobuses
{
    public class MetodosAutobus
    {
        private int posicion { get; set; }
        public Autobus[] autobuses;
        public MetodosAutobus()
        {
            autobuses = new Autobus[20];
            posicion = 0;

        }
        public void RegistrarAutobus() //metodo para registrar los autobuses
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Registro de Autobuses\n");
                Console.WriteLine("Identificación generada");
                int identificacion = posicion + 1;
                Console.WriteLine(identificacion);
                Console.WriteLine("ID de placa");
                string IDplaca = Console.ReadLine();
                foreach (Autobus ra in autobuses)
                {
                    if (ra != null)
                    {
                        if (IDplaca.Equals(ra.IdPlaca))//verifico que la placa no se haya registrado antes
                        {
                            Console.WriteLine("Este numero de placa ya se ha registado");
                            Console.ReadKey();
                            return;
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

                string estados;
                bool estado;
                do
                {
                    //el while para volver a pedir el estado si ingresa algo diferente a activo o inactivo
                    Console.WriteLine("Estado(Activo o Inactivo)");
                    estados = Console.ReadLine();
                    estado = estados.ToLower().Equals("activo") ? true : false;
                } while (!estados.ToLower().Equals("activo") && !estados.ToLower().Equals("inactivo"));
                this.autobuses[posicion] = new Autobus(identificacion, IDplaca, Marca, Modelo, Capacidad, estado);
                Console.WriteLine("Autobus registrado");
                posicion++;
                Console.ReadKey();
            }
            catch (Exception)
            {
                Console.WriteLine("Ha ocurrido un error");
                Console.ReadKey();
                RegistrarAutobus();
            }
        }


        public void ConsultarAutobus()//metodo para consultar los autobuses
        {
            if (autobuses[0] != null)
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


                }
            }
            else
            {
                Console.WriteLine("No existen autobuses registrados");
                Console.ReadKey();
            }





        }
        public Autobus ExisteAutobus(int idAutobus)//este metodo lo utilizo en la clase de metodosrol que es para verificar que la id ingresada en
                                                   //metodos rol existe, si existe me devuelve el autobus correspondiente a la id ingresada
        {
            int id = 0;
            while (autobuses[id] != null)
            {
                if (autobuses[id].Identificacion == idAutobus)
                {
                    return autobuses[id];
                }
                id++;
            }
            return null;
        }

    }
}
