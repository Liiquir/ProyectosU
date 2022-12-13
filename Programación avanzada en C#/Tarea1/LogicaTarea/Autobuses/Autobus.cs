using LogicaTarea.Terminales;

namespace LogicaTarea
{
    public class Autobus
    {
        public int Identificacion { get; set; }
        public string IdPlaca { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int capacidad { get; set; }
        public bool Estado { get; set; }

        public Autobus(int identificacion, string idPlaca, string marca, string modelo, int capacidad, bool estado)
        {
            Identificacion = identificacion;
            IdPlaca = idPlaca;
            Marca = marca;
            Modelo = modelo;
            this.capacidad = capacidad;
            Estado = estado;
        }

        private string GetEstado()
        {
            return Estado ? "Activo" : "Inactivo";
        }
        public string ImprimirDatos()
        {
            return $"Identificación: {Identificacion} " + "\n" +
                $"ID placa:{IdPlaca}" + "\n" +
                $"Marca:{Marca}" + "\n" +
                $"Modelo:{Modelo}" + "\n" +
                $"Capacidad:{capacidad}" + "\n" +
                $"Estado:{GetEstado()}" + "\n";
        }
    }
}
