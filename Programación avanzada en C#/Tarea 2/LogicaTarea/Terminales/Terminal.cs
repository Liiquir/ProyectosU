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

        public override string ToString() //metodo que me sobreescribe para poder devolver el nombre de la terminal
                                          //https://learn.microsoft.com/en-us/dotnet/api/system.object.tostring?view=net-7.0
        {
            return NombreTerminal;
        }
    }
}
