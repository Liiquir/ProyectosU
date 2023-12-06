using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    public class RegistroRoles
    {
        public DateTime fecha { get; set; }
        public DateTime horaSalida { get; set; }
        public RegistroRutas idRuta { get; set; }
        public RegistroAutobuses idAutoBus { get; set; }
        public RegistroConductores conductor { get; set; }

        public RegistroRoles(DateTime fecha, DateTime horaSalida, RegistroRutas idRuta, RegistroAutobuses idAutoBus, RegistroConductores conductor)
        {
            this.fecha = fecha;
            this.horaSalida = horaSalida;
            this.idRuta = idRuta;
            this.idAutoBus = idAutoBus;
            this.conductor = conductor;
        }
    }
}
