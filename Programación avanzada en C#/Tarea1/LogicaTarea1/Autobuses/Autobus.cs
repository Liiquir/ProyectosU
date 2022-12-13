using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
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
    }
}
