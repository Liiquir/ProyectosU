using LogicaTarea.Terminales;
using System;

namespace LogicaTarea.Rutas
{
    public class MetodosRuta
    {
        private int posicion { get; set; }
        public Ruta[] rutas;
        MetodosTerminal metodosTerminal { get; set; }
        public MetodosRuta(MetodosTerminal metodosTerminal)
        {
            this.metodosTerminal = metodosTerminal;
            rutas = new Ruta[20];
            posicion = 0;

        }
        public bool RegistrarRutas()//metodo para registrar las rutas
        {
            try
            {
                Console.WriteLine("Registro de Rutas\n");
                Console.WriteLine("ID generada");
                int ID = posicion+1;
                Console.WriteLine(ID);
                int idTerminalSalida;
                int idTerminalLlegada = 0;
                double tarifa = 0;
                string descripcionRuta ="";
                int tipoRuta = 0;
                bool estado = true;
                Console.WriteLine("ID terminal de salida");
                idTerminalSalida = int.Parse(Console.ReadLine());
                Terminal salida = this.metodosTerminal.ExisteTerminal(idTerminalSalida);
                if (salida != null)//si la id de terminal que ingreso existe entonces procedo a mostrar los datos//
                {
                    Console.WriteLine("La terminal de salida es:" + salida.NombreTerminal);
                    Console.WriteLine("ID terminal de llegada");
                    idTerminalLlegada = int.Parse(Console.ReadLine());
                    Terminal llegada = this.metodosTerminal.ExisteTerminal(idTerminalLlegada);
                    if (llegada != null)
                    {
                        
                        if (llegada.IdTerminal != salida.IdTerminal)//si la terminal de salida y llegada son distintas y la terminal existe entonces se muestra
                                                                    //el nombre
                        {
                            Console.WriteLine("La terminal de llegada es:" + llegada.NombreTerminal);
                            Console.WriteLine("Tarifa");
                            tarifa = double.Parse(Console.ReadLine());
                            Console.WriteLine("Descripcion de la ruta");
                            descripcionRuta=Console.ReadLine();
                            do
                            {   Console.WriteLine("Tipo de ruta (1=Directo, 2=Regular)");
                                tipoRuta = int.Parse(Console.ReadLine());
                                
                            } while (tipoRuta != int.Parse("1") && tipoRuta!= int.Parse("2"));
                            string estados;//estos dos do while es para que mientras digite algo distinto a los datos que se le
                                           //solicitan se los vuelta a pedir hasta que los ingrese correctamente
                            do
                            {
                                
                                Console.WriteLine("Estado(Activo o Inactivo)");
                                estados = Console.ReadLine();
                                estado = estados.ToLower().Equals("activo") ? true : false;
                            } while (!estados.ToLower().Equals("activo")&& !estados.ToLower().Equals("inactivo")); 
                            
                            rutas[posicion] = new Ruta(ID, salida, llegada, tarifa, descripcionRuta, tipoRuta, estado);
                            posicion++;
                            Console.WriteLine("Ruta registrada");
                            return true;
                        }
                        else
                        {
                            Console.WriteLine("La terminal de salida y llegada no pueden ser las mismas");
                            Console.ReadKey();
                        }

                    }        //else por si ingresa datos que no estan registrados
                    else
                    {
                        Console.WriteLine("La terminal ingresa no existe");
                        Console.ReadKey();

                    }
                }
                else
                {
                    Console.WriteLine("La terminal ingresa no existe");
                    Console.ReadKey();

                }
                return false;
            }
            catch (Exception)
            {
                Console.WriteLine("Ha ocurrido un error");
                Console.ReadKey();
                return false;
            }
        }



        public void ConsultarRutas()//metodo para consultar las rutas
        {
            if (rutas[0] != null)
            {
                foreach (Ruta ruta in rutas)
                {
                    if (ruta != null)
                    { Console.WriteLine(ruta.ImprimirDatos() + "\n"); }

                }
            }
            else
            {
                Console.WriteLine("No existen rutas registradas.");
            }
        }
        public Ruta ExisteRuta(int idRuta)//este metodo lo utilizo en la clase de metodosrol que es para verificar que la id ingresada en
                                          //metodos rol existe, si existe me devuelve la ruta correspondiente a la id ingresada
        {
            int id = 0;
            while (rutas[id] != null)
            {
                if (rutas[id].id == idRuta)
                {
                    return rutas[id];
                }
                id++;
            }
            return null;
        }
       
    }

}
