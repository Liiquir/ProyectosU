using LogicaTarea.Terminales;


namespace LogicaTarea
{
    public class Ruta
    {

        public int NUM_RUTA { get; set; }
        public int COD_TERMINAL_SALIDA { get; set; }
        public int COD_TERMINAL_LLEGADA { get; set; }
        public double NUM_TARIFA { get; set; }
        public string DSC_RUTA { get; set; }
        public int NUM_TIPO_RUTA { get; set; }
        public bool BOL_ESTADO { get; set; }

        

        public Ruta()
        {
        }        
    }
}
