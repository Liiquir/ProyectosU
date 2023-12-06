using System;

namespace LogicaTarea.Terminales
{
    public class Terminal
    {
        //propiedades,gets y sets
        public int COD_TERMINAL { get; set; }
        public string NOM_TERMINAL { get; set; }
        public string DIR_TERMINAL { get; set; }
        public string NUM_TELEFONO { get; set; }
        public TimeSpan TIM_HORA_APERTURA { get; set; }
        public TimeSpan TIM_HORA_CIERRE { get; set; }
        public bool BOL_ESTADO { get; set; }

        //constructor
        

        public Terminal()
        {
        }


        public override string ToString() //metodo que me sobreescribe para poder devolver el nombre de la terminal
                                          //https://learn.microsoft.com/en-us/dotnet/api/system.object.tostring?view=net-7.0
        {
            return NOM_TERMINAL;
        }

    }
}
