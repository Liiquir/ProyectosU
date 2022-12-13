using LogicaTarea.Autobuses;
using LogicaTarea.Conductores;
using LogicaTarea.Rutas;
using LogicaTarea.Terminales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaTarea.Roles
{
    public class MetodosRol
    {
        private int posicion { get; set; }
        private Rol[] roles;

        MetodosRuta metodosRuta { get; set; }
        MetodosAutobus MetodosAutobus { get; set; }
        MetodosConductor MetodosConductor { get; set; }
        public MetodosRol(MetodosRuta metodosRuta, MetodosAutobus metodosAutobus, MetodosConductor metodosConductor)
        {
            //inicializacion de clases
            this.metodosRuta = metodosRuta;
            this.MetodosAutobus = metodosAutobus;
            this.MetodosConductor = metodosConductor;
            roles = new Rol[20];
            posicion = 0;

        }
        public void RegistrarRoles()//metodo para registrar los roles
        {
            try
            {

                Console.WriteLine("Ingrese la fecha(dd-MM-yyyy)");
                string fechaIngresada = Console.ReadLine();
                DateTime FechaRol = DateTime.ParseExact(fechaIngresada, "dd-MM-yyyy", null);
                DateTime FechaActual = DateTime.Now;
                string hora;

                FechaActual = FechaActual.AddDays(+1);
                if (FechaRol.CompareTo(FechaActual) > 0)// este validacion es para verificar que la fecha del rol a registrar se mayor a dos dias
                {

                    Console.WriteLine("Ingrese la hora de salida(HH:mm)");
                    hora = Console.ReadLine();
                    DateTime horaSalida = DateTime.ParseExact(hora, "HH:mm", null);
                    Console.WriteLine("Ingrese el id de la ruta");
                    int idRuta = int.Parse(Console.ReadLine());
                    Ruta ruta = this.metodosRuta.ExisteRuta(idRuta);
                    if (ruta != null)//si el numero de ruta que se ingreso es valido se procede a desplegar los datos de la misma
                    {
                        Console.WriteLine("Terminal de origen: " + ruta.Salida.NombreTerminal);
                        Console.WriteLine("Terminal de destino: " + ruta.Llegada.NombreTerminal);
                        Console.WriteLine("Tarifa:" + ruta.tarifa);
                        Console.WriteLine("Tipo:" + ruta.tipoRuta + "\n");
                        Console.WriteLine("Ingrese la identificacion del autobus");
                        int idAutobus = int.Parse(Console.ReadLine());
                        Autobus autobus = this.MetodosAutobus.ExisteAutobus(idAutobus);
                        if (autobus != null) //si el id de autobus que se ingreso es valido se procede a desplegar los datos del mismo
                        {
                            Console.WriteLine("Placa:" + autobus.IdPlaca);
                            Console.WriteLine("Marca:" + autobus.Marca);
                            Console.WriteLine("Capacidad:" + autobus.capacidad + "\n");
                            Console.WriteLine("Ingrese la identificación del conductor");
                            string idConductor = Console.ReadLine();
                            Conductor conductor = this.MetodosConductor.ExisteConductor(idConductor);
                            if (conductor != null) //si la identificacion del conductor existe y no es un conductor supervisor se procede a registrar la ruta y
                                                   //agregarla al arreglo
                            {
                                if (conductor.ConductorSupervisor == false)
                                {
                                    Console.WriteLine("Se ha registrado el rol");
                                    roles[posicion] = new Rol(FechaRol, horaSalida, ruta, autobus, conductor);
                                    posicion++;
                                }
                                else
                                {
                                    Console.WriteLine("El conductor no puede ser un conductor supervisor");
                                    Console.ReadKey();
                                }
                            }
                            else
                            {
                                Console.WriteLine("El conductor ingresado no existe");
                                Console.ReadKey();
                            }
                        }       //todos estos else a exepcion de ultimo es para cuando se ingresa un dato
                                //erroneo o un dato que no exista registrada en los arreglos
                        else
                        {
                            Console.WriteLine("El autobus ingresado no existe");
                            Console.ReadKey();
                        }
                    }
                    else
                    {
                        Console.WriteLine("La ruta ingresa no existe");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine("Para registrar un rol se debe hacer con al menos dos días de antelación");
                    Console.ReadKey();
                }




            }
            catch (Exception)
            {
                Console.WriteLine("Ha ocurrido un error");
                Console.ReadKey();
            }
        }
        public void ConsultarRoles()//metodo para imprimir los roles registrados
        {
            if (roles[0] != null)
            {
                foreach (Rol rol in roles)
                {
                    if (rol != null)
                    {
                        Console.WriteLine("Roles Registrados\n");
                        Console.WriteLine(rol.ImprimirDatos() + "\n");
                    }
                }
            }
            else
            {
                Console.WriteLine("No existen roles registrados.");
            }
        }
        public void Validaciones()
        {    //el enunciado decia que tenia que existir al menos una terminal para registrar un rol lo cual no le veia sentido ya que las terminales se validaban a la hora de añadir una ruta
            //por lo que aqui asumi que lo que se referia el enunciado era  a una ruta y no a una terminal, dicho esto entonces valido queo existan rutas registradas y no terminales.
            if (metodosRuta.rutas[0] == null)
            {
                Console.WriteLine("Se debe al menos registrar una ruta para incluir los Roles.");
                if (MetodosAutobus.autobuses[0] == null)
                {
                    Console.WriteLine(" se debe al menos registrar un autobús para incluir los Roles");
                    if (MetodosConductor.conductores[0] == null)
                    {
                        Console.WriteLine("Se debe al menos registrar un conductor para incluir los Roles.");
                    }
                }
            }
            else
            {
                if (MetodosAutobus.autobuses[0] == null)
                {
                    Console.WriteLine("Se debe al menos registrar un autobús para incluir los Roles");
                    if (MetodosConductor.conductores[0] == null)
                    {
                        Console.WriteLine("Se debe al menos registrar un conductor para incluir los Roles.");
                        Console.ReadKey();
                        return;
                    }
                    //es cierto que esto quedo un poco confuso y feo pero no encontre otra manera de hacerlo que probablemente si hay
                    //pero que en el momento o no se me ocurria o sencillamente no encontraba, al menos esto me funciono
                }
                else
                {
                    if (MetodosConductor.conductores[0] == null)
                    {
                        Console.WriteLine("Se debe al menos registrar un conductor para incluir los Roles.");
                    }
                    else
                    {
                        RegistrarRoles();
                    }
                }
            }




        }
    }
}
