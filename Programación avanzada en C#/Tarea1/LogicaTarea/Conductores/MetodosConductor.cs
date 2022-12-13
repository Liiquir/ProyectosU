using System;

namespace LogicaTarea.Conductores
{
    public class MetodosConductor
    {
        private int posicion { get; set; }
        public Conductor[] conductores;
        public MetodosConductor()
        {
            conductores = new Conductor[20];
            posicion = 0;

        }


        public void RegistrarConductor() //metodo para registrar los conductores

        {
            try
            {
                Console.WriteLine("Registro de Conductores\n");
                Console.WriteLine("Ingrese la identificación");
                string identificacion = Console.ReadLine();
                foreach (Conductor rc in conductores)// se recorre el arreglo de los conductores
                {
                    if (rc != null)
                    {
                        if (identificacion.Equals(rc.Identificacion))// si la identificación que se ingresa ya existe muestra el mensaje y se devuelve al menú 
                        {
                            Console.WriteLine("Esta identificación ya se ha registado");
                            Console.ReadKey();
                            Console.Clear();
                            return;
                        }
                    }
                }// si la identificación no se encuentra registrada continua con el metodo
                Console.WriteLine("Ingrese el Nombre");
                string nombre = Console.ReadLine();
                Console.WriteLine("Ingrese el primer apellido");
                string primerApellido = Console.ReadLine();
                Console.WriteLine("Ingrese el segundo apellido");
                string segundoApellido = Console.ReadLine();
                Console.WriteLine("Ingrese la fecha de nacimiento(dd-MM-yyyy)");
                string fecha = Console.ReadLine();
                DateTime fechaNacimiento = DateTime.ParseExact(fecha, "dd-MM-yyyy", null);
                string generos;
                char genero;
                do
                {   //aqui hice un ciclo do while para que mientras el dato ingresado sea diferente de m o f se repita hasta que sea alguno de los dos
                    Console.WriteLine("Ingrese el genero(M=Masculino o F=Femenino)");
                    generos = Console.ReadLine();
                    genero = char.Parse(generos);

                } while (!generos.ToLower().Equals("m") && !generos.ToLower().Equals("f")); 
                
                bool conductorSupervisor;
                string supervisor;
                do
                {
                    //aqui es basicamente lo mismo mientras sea diferente de si o no se repetira
                    Console.WriteLine("¿Es un conductor supervisor?(si o no)");
                    supervisor = Console.ReadLine();
                    
                } while (!supervisor.ToLower().Equals("si") && !supervisor.ToLower().Equals("no"));
                conductorSupervisor = supervisor.ToLower().Equals("si") ? true : false;
                this.conductores[posicion] = new Conductor(identificacion, nombre, primerApellido,
                 segundoApellido, fechaNacimiento, genero, conductorSupervisor);
                Console.WriteLine("Conductor registrado");
                this.posicion++;
                Console.ReadKey();

            }
            catch (Exception) { Console.WriteLine("error"); } //el catch en caso de no haber previsto algun error y que no se caiga el programa

        }
        public void ConsultarConductores()//metodo para consultar los conductores
        {
            if (conductores[0] != null)//primero compruebo que el arreglo no este vacio ya que si esta vacio se muestra un mensaje
            {
                foreach (Conductor rc in conductores)//reccoro el arreglo para imprimir los datos
                {
                    if (rc != null)
                    {
                        Console.WriteLine("Identificación: " + rc.Identificacion + "\n" + "Nombre: " + rc.Nombre + "\n" + "Primer apellido: " + rc.PrimerApellido +
                        "\n" + "Segundo apeliido: " + rc.SegundoApellido + "\n" + "Fecha nacimento: " + rc.FechaNacimiento.ToShortDateString());
                        if (rc.Genero==char.Parse("M")|| rc.Genero == char.Parse("m"))//esto es para validar que si se recibe una m se escriba masculino
                        {                                                             //en lugar de escribir solamente la m
                            Console.WriteLine("Genero: Masculino");
                        }
                        else
                        {
                            Console.WriteLine("Genero: Femenino");//y aqui caso contrario para femenino
                        }
                        if (rc.ConductorSupervisor == true)//aqui es que si recibe un true entonces escribir que el conductor supervisor sino entonces no
                        {
                            Console.WriteLine("Es un conductor supervisor: Si");
                        }
                        else { Console.WriteLine("Es un conductor supervisor: No\n"); }
                    }         
                    
                    
                }
            }
            else
            {
                Console.WriteLine("No existen conductores registrados");  //esto es por si el arreglo esta vacio
                Console.ReadKey();
                return;
            }
            


        }
        public Conductor ExisteConductor(string idConductor)//este metodo lo utilizo en la clase de metodosrol que es para verificar que la id ingresada en
                                                            //metodos rol existe, si existe me devuelve el conductor correspondiente a la id ingresada
        {
            int id = 0;
            while (conductores[id] != null)
            {
                if (conductores[id].Identificacion == idConductor)
                {
                    return conductores[id];
                }
                id++;
            }
            return null;
        }


    }
}
