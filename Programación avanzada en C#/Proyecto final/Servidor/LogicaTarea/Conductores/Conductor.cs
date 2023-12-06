using System;

namespace LogicaTarea
{
    public class Conductor
    {
        //propiedades,gets y sets
        public string NUM_CEDULA { get; set; }
        public string NOM_NOMBRE { get; set; }
        public string NOM_APELLIDO_1 { get; set; }
        public string NOM_APELLIDO_2 { get; set; }
        public DateTime FEC_NACIMIENTO { get; set; }
        public char TIP_GENERO { get; set; }
        public bool BIT_SUPERVISOR { get; set; }
      
        public Conductor()
        {
        }
    }
}
