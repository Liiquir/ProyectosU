using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea1;

namespace LogicaTarea1.Conductores
{
    public class MetodosConductor
    {
        private int posicion { get; set; }
        private Conductor[] conductores;
        public MetodosConductor()
        {
            conductores = new Conductor[20];
            posicion = 0;

        }


        public void RegistrarConductor()

        {
            try
            {
                Console.WriteLine("Registro de Conductores\n");
                Console.WriteLine("Ingrese la identificación");
                string identificacion = Console.ReadLine();
                foreach (Conductor rc in conductores)
                {
                    if (rc != null)
                    {
                        if (identificacion.Equals(rc.Identificacion))
                        {
                            Console.WriteLine("Esta identificación ya se ha registado");
                            Console.ReadKey();
                            Console.Clear();
                            RegistrarConductor();
                        }
                    }
                }
                Console.WriteLine("Ingrese el Nombre");
                string nombre = Console.ReadLine();
                Console.WriteLine("Ingrese el primer apellido");
                string primerApellido = Console.ReadLine();
                Console.WriteLine("Ingrese el segundo apellido");
                string segundoApellido = Console.ReadLine();
                Console.WriteLine("Ingrese la fecha de nacimiento(dd-MM-yyyy)");
                string fecha = Console.ReadLine();
                DateTime fechaNacimiento = DateTime.ParseExact(fecha, "dd-MM-yyyy", null);
                Console.WriteLine("Ingrese el genero(M o F)");
                char genero = char.Parse(Console.ReadLine());
                Console.WriteLine("¿Es un conductor supervisor?(Si o no)");
                bool conductorSupervisor = Console.ReadLine().ToLower().Equals("Si") ? true : false;
                this.conductores[posicion] = new Conductor(identificacion, nombre, primerApellido,
                 segundoApellido, fechaNacimiento, genero, conductorSupervisor);
                Console.WriteLine("Conductor registrado");
                this.posicion++;
                Console.ReadKey();

            }
            catch (Exception e) { Console.WriteLine("error"); }

        }
        public void ConsultarConductores()
        {
            foreach (Conductor rc in conductores)
            {
                if (rc != null)
                {
                    Console.WriteLine("Identificación: " + rc.Identificacion + "\n" + "Nombre: " + rc.Nombre + "\n" + "Primer apellido: " + rc.PrimerApellido +
                    "\n" + "Segundo apeliido: " + rc.SegundoApellido + "\n" + "Fecha nacimento: " + rc.FechaNacimiento.ToShortDateString() + "\n" +
                    "Genero: " + rc.Genero);
                    if (rc.ConductorSupervisor == true)
                    {
                        Console.WriteLine("Si");
                    }
                    else { Console.WriteLine("No"); }
                }


            }
            Console.ReadKey();
        }
    }
}
