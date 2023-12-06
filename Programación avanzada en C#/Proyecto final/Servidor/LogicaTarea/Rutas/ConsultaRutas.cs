using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LogicaTarea.Rutas
{   // esta clase es para poder recibir todos los datos que se deben mostrar en la consulta de las rutas
    public class ConsultaRutas
    {
        public int NUM_RUTA_SALIDA { get; set; }
        public int COD_TERMINAL_SALIDA { get; set; }
        public string NOM_TERMINAL_SALIDA { get; set; }
        public string DIR_TERMINAL_SALIDA { get; set; }
        public string NUM_TELEFONO_SALIDA { get; set; }
        public TimeSpan TIM_HORA_APERTURA_SALIDA { get; set; }
        public TimeSpan TIM_HORA_CIERRE_SALIDA { get; set; }
        public bool BOL_ESTADO_SALIDA { get; set; }
        public int COD_TERMINAL_LLEGADA { get; set; }
        public string NOM_TERMINAL_LLEGADA { get; set; }
        public string DIR_TERMINAL_LLEGADA { get; set; }
        public string NUM_TELEFONO_LLEGADA { get; set; }
        public TimeSpan TIM_HORA_APERTURA_LLEGADA { get; set; }
        public TimeSpan TIM_HORA_CIERRE_LLEGADA { get; set; }
        public bool BOL_ESTADO_LLEGADA { get; set; }
        public double NUM_TARIFA { get; set; }
        public string DSC_RUTA { get; set; }
        public int NUM_TIPO_RUTA { get; set; }
        public bool BOL_ESTADO { get; set; }

        public ConsultaRutas(int nUM_RUTA_SALIDA, int cOD_TERMINAL_SALIDA, string nOM_TERMINAL_SALIDA, string dIR_TERMINAL_SALIDA, string nUM_TELEFONO_SALIDA, TimeSpan tIM_HORA_APERTURA_SALIDA, TimeSpan tIM_HORA_CIERRE_SALIDA, bool bOL_ESTADO_SALIDA, int cOD_TERMINAL_LLEGADA, string nOM_TERMINAL_LLEGADA, string dIR_TERMINAL_LLEGADA, string nUM_TELEFONO_LLEGADA, TimeSpan tIM_HORA_APERTURA_LLEGADA, TimeSpan tIM_HORA_CIERRE_LLEGADA, bool bOL_ESTADO_LLEGADA, double nUM_TARIFA, string dSC_RUTA, int nUM_TIPO_RUTA, bool bOL_ESTADO)
        {
            NUM_RUTA_SALIDA = nUM_RUTA_SALIDA;
            COD_TERMINAL_SALIDA = cOD_TERMINAL_SALIDA;
            NOM_TERMINAL_SALIDA = nOM_TERMINAL_SALIDA;
            DIR_TERMINAL_SALIDA = dIR_TERMINAL_SALIDA;
            NUM_TELEFONO_SALIDA = nUM_TELEFONO_SALIDA;
            TIM_HORA_APERTURA_SALIDA = tIM_HORA_APERTURA_SALIDA;
            TIM_HORA_CIERRE_SALIDA = tIM_HORA_CIERRE_SALIDA;
            BOL_ESTADO_SALIDA = bOL_ESTADO_SALIDA;
            COD_TERMINAL_LLEGADA = cOD_TERMINAL_LLEGADA;
            NOM_TERMINAL_LLEGADA = nOM_TERMINAL_LLEGADA;
            DIR_TERMINAL_LLEGADA = dIR_TERMINAL_LLEGADA;
            NUM_TELEFONO_LLEGADA = nUM_TELEFONO_LLEGADA;
            TIM_HORA_APERTURA_LLEGADA = tIM_HORA_APERTURA_LLEGADA;
            TIM_HORA_CIERRE_LLEGADA = tIM_HORA_CIERRE_LLEGADA;
            BOL_ESTADO_LLEGADA = bOL_ESTADO_LLEGADA;
            NUM_TARIFA = nUM_TARIFA;
            DSC_RUTA = dSC_RUTA;
            NUM_TIPO_RUTA = nUM_TIPO_RUTA;
            BOL_ESTADO = bOL_ESTADO;
        }

        public ConsultaRutas()
        {
        }
    }

}
