using LogicaTarea.Terminales;

namespace LogicaTarea
{
    public class Autobus
    {
        public int Identificacion { get; set; }
        public string IdPlaca { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Capacidad { get; set; }
        public bool Estado { get; set; }

        public Autobus(int identificacion, string idPlaca, string marca, string modelo, int capacidad, bool estado)
        {
            this.Identificacion = identificacion;
            this.IdPlaca = idPlaca;
            this.Marca = marca;
            this.Modelo = modelo;
            this.Capacidad = capacidad;
            this.Estado = estado;
        }

        public override string ToString()
        {
            return Identificacion.ToString();
        }
    }
}
