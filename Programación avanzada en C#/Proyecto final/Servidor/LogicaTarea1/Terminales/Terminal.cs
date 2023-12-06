using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaTarea1.Terminales
{
    public class Terminal
    {
        //propiedades,gets y sets
        public int IdTerminal { get; set; }
        public string NombreTerminal { get; set; }
        public string DireccionTerminal { get; set; }
        public string TelefonoTerminal { get; set; }
        public DateTime HoraApertura { get; set; }
        public DateTime HoraCierre { get; set; }
        public bool Estado { get; set; }

        //constructor
        public Terminal(int idTerminal, string nombreTerminal, string direccionTerminal,
            string telefonoTerminal, DateTime horaApertura, DateTime horaCierre, bool estado)
        {
            IdTerminal = idTerminal;
            NombreTerminal = nombreTerminal;
            DireccionTerminal = direccionTerminal;
            TelefonoTerminal = telefonoTerminal;
            HoraApertura = horaApertura;
            HoraCierre = horaCierre;
            Estado = estado;
        }
        private string GetEstado()
        {
            return Estado ? "Activo" : "Inactivo";
        }
        public string ImprimirDatos()
        {
            //string interpolation
            return $"ID: {IdTerminal}, Nombre:{NombreTerminal},Direccion:{DireccionTerminal},Telefono:{TelefonoTerminal}," +
                $"Hora apertura:{HoraApertura.ToString("HH:mm")},Hora cierre:{HoraCierre.ToString("HH:mm")}estado:{GetEstado}";
        }
    }
}
