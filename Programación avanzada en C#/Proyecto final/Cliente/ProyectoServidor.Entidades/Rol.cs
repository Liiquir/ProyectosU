using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoServidor.Entidades
{
    public class Rol
    {
        public DateTime fecha { get; set; }
        public DateTime horaSalida { get; set; }
        public int idRuta { get; set; }
        public int idAutoBus { get; set; }
        public string conductor { get; set; }
    }
}
