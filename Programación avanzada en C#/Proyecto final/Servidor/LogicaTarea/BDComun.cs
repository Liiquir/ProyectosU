using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaTarea
{
    public class BDComun
    {                     //esto es solamente para obtener la cadena de conexion, para no estar agregando una en cada una
                          
        public string  ObtenerConexion()
        {
            string cadenaConexion = "Data source=DESKTOP-PRFEM7G;Initial Catalog=BUSUNED; Integrated Security=True";
            return cadenaConexion;
        }
    }
}
