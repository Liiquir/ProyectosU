using LogicaTarea1.Terminales;


namespace Tarea1
{
    public class Ruta
    {
                        
       public int id { get; set; }
       public Terminal Salida { get; set; }
       public Terminal Llegada { get; set; }
       public double tarifa { get; set; }
       public string descripcionRuta { get; set; }
       public int tipoRuta { get; set; }
       public bool estado { get; set; }

        public Ruta(int id, Terminal salida, Terminal llegada, double tarifa, string descripcionRuta, int tipoRuta, bool estado)
        {
            this.id = id;
            Salida = salida;
            Llegada = llegada;
            this.tarifa = tarifa;
            this.descripcionRuta = descripcionRuta;
            this.tipoRuta = tipoRuta;
            this.estado = estado;
        }
        private string GetEstado()
        {
            return estado ? "Activo" : "Inactivo";
        }
        public string ImprimirDatos()
        {
            return $"ID:{id}\n" +
                $"Terminal salida:{Salida.ImprimirDatos}\n" +
                $"Terminal llegada:{Llegada.ImprimirDatos}\n" +
                $"Tarifa:{tarifa}\n" +
                $"Descripción ruta{descripcionRuta}\n" +
                $"Tipo ruta:{tipoRuta}\n" +
                $"Estado:{GetEstado}";
        }
    }
}
