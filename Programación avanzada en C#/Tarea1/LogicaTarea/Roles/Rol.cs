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
        public string ImprimirDatos()
        {
            return $"Fecha: {fecha.ToString("dd/MM/yyyy")}\n" +
                $"Hora de salida: {horaSalida.ToString("HH:mm")}\n" + 
                $"Ruta\n{idRuta.ImprimirDatos()}"+"\n" +
                $"Autobus\n{idAutoBus.ImprimirDatos()}"+"\n" +
                $"Conductor\n{conductor.ImprimirDatos()}";
        }
    }
}
