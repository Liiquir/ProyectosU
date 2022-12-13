using LogicaTarea1.Terminales;
using Tarea1;

namespace LogicaTarea1.Rutas
{
    public class MetodosRuta
    {
        private int posicion { get; set; }
        private Ruta[] rutas;
        MetodosTerminal metodosTerminal { get; set; }
        public MetodosRuta(MetodosTerminal metodosTerminal)
        {
            this.metodosTerminal = metodosTerminal;
            rutas = new Ruta[20];
            posicion = 0;

        }
        public bool RegistrarRutas()
        {
            try
            {
                Console.WriteLine("Registro de Rutas\n");
                Console.WriteLine("ID generada");
                int ID = GenerarNum();
                Console.WriteLine(ID);
                int idTerminalSalida;
                int idTerminalLlegada = 0;
                double tarifa = 0;
                string descripcionRuta = "";
                int tipoRuta = 0;
                bool estado = true;
                Console.WriteLine("ID terminal de salida");
                idTerminalSalida = int.Parse(Console.ReadLine());
                Terminal salida = this.metodosTerminal.ExisteTerminal(idTerminalSalida);
                if (salida != null)
                {
                    Console.WriteLine("La terminal de salida es:" + salida.NombreTerminal);
                    Console.WriteLine("ID terminal de llegada");
                    idTerminalLlegada = int.Parse(Console.ReadLine());
                    Terminal llegada = this.metodosTerminal.ExisteTerminal(idTerminalLlegada);
                    if (llegada != null)
                    {
                        Console.WriteLine("La terminal de llegada es:" + llegada.NombreTerminal);
                        if (llegada.IdTerminal != salida.IdTerminal)
                        {
                            Console.WriteLine("Tarifa");
                            tarifa = double.Parse(Console.ReadLine());
                            Console.WriteLine("Descripcion de la ruta");
                            descripcionRuta = Console.ReadLine();
                            Console.WriteLine("Tipode ruta (1=Directo, 2=Regular)");
                            tipoRuta = int.Parse(Console.ReadLine());
                            Console.WriteLine("Estado(Activo o Inactivo)");
                            estado = Console.ReadLine().ToLower().Equals("activo") ? true : false;
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

                    }
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
            catch (Exception e)
            {
                Console.WriteLine("Ha ocurrido un error");
                Console.ReadKey();
                return false;
            }
        }



        private void ConsultarRutas()
        {
            if (rutas.Any())
            {
                foreach (Ruta ruta in rutas)
                {
                    Console.WriteLine(ruta.ImprimirDatos + "\n");
                }
            }
            else
            {
                Console.WriteLine("No existen rutas registradas.");
            }
        }
        private int GenerarNum()
        {
            int min = 1;
            int max = 999;
            Random rnd = new Random();
            int numero = rnd.Next(min, max);

            return numero;
        }
    }

}
