using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesServidor
{
    public class Paquete
    {
        public string Comando { get; set; }
        public string Contenido { get; set; }

        public Paquete()
        {

        }
        public Paquete(string comando, string contenido)
        {
            Comando = comando;
            Contenido = contenido;

        }
        public Paquete(string fatos)
        {

        }
    }
}
