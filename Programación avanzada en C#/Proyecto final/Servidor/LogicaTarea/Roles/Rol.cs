using System;




namespace LogicaTarea.Roles
{
    public class Rol
    {
        public DateTime FEC_ROL { get; set; }
        public TimeSpan TIM_HORA_SALIDA { get; set; }
        public int NUM_RUTA { get; set; }
        public int NUM_IDENTIFICACION_BUS { get; set; }
        public string NUM_CEDULA_CONDUCTOR { get; set; }

        public Rol()
        {
        }
    }
}
