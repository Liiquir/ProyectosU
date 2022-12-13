using System;

namespace LogicaTarea.Terminales
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
            return $"ID: {IdTerminal} " + "\n" +
                $"Nombre:{NombreTerminal}" + "\n" +
                $"Direccion:{DireccionTerminal}" + "\n" +
                $"Telefono:{TelefonoTerminal}" + "\n" +
                $"Hora apertura:{HoraApertura.ToString("HH:mm")}" + "\n" +
                $"Hora cierre:{HoraCierre.ToString("HH:mm")}" + "\n" +
                $"estado:{GetEstado()}" + "\n";
        }
    }
}
