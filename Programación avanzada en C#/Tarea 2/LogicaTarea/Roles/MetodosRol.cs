using LogicaTarea.Autobuses;
using LogicaTarea.Conductores;
using LogicaTarea.Rutas;
using LogicaTarea.Terminales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaTarea.Roles
{
    public class MetodosRol
    {
        public int posicion { get; set; }
        public Rol[] roles;

        MetodosRuta metodosRuta { get; set; }
        MetodosAutobus MetodosAutobus { get; set; }
        MetodosConductor MetodosConductor { get; set; }
        public MetodosRol(MetodosRuta metodosRuta, MetodosAutobus metodosAutobus, MetodosConductor metodosConductor)
        {
            //inicializacion de clases
            this.metodosRuta = metodosRuta;
            this.MetodosAutobus = metodosAutobus;
            this.MetodosConductor = metodosConductor;
            roles = new Rol[20];
            posicion = 0;

        }
       public void RegistrarRoles(DateTime FechaRol,DateTime horaSalida,Ruta ruta,Autobus autobus,Conductor conductor)//metodo para registrar los roles
       {
                                   
                                   roles[posicion] = new Rol(FechaRol, horaSalida, ruta, autobus, conductor);
                                   posicion++;                              
       }


    }
}
