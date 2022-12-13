using System;




namespace LogicaTarea.Roles
{
    public class Rol
    {
        public DateTime fecha { get; set; }
        public DateTime horaSalida { get; set; }
        public Ruta idRuta { get; set; }
        public Autobus idAutoBus { get; set; }
        public Conductor conductor { get; set; }

        public Rol(DateTime fecha, DateTime horaSalida, Ruta idRuta, Autobus idAutoBus, Conductor conductor)
        {
            this.fecha = fecha;
            this.horaSalida = horaSalida;
            this.idRuta = idRuta;
            this.idAutoBus = idAutoBus;
            this.conductor = conductor;
        }
       

        
    }
}
