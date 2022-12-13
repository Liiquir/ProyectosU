using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    public class Conductor
    {
        //propiedades,gets y sets
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public DateTime FechaNacimiento  { get; set; }
        public char Genero { get; set; }
        public bool ConductorSupervisor { get; set; }

        public Conductor()
        {
        }

        public Conductor(string identificacion, string nombre, string primerApellido, 
            string segundoApellido, DateTime fechaNacimiento, char genero, bool conductorSupervisor)
        {
            Identificacion = identificacion;
            Nombre = nombre;
            PrimerApellido = primerApellido;
            SegundoApellido = segundoApellido;
            FechaNacimiento = fechaNacimiento;
            Genero = genero;
            ConductorSupervisor = conductorSupervisor;
        }

        //constructor

    }

}
