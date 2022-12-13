using LogicaTarea.Terminales;


namespace LogicaTarea
{
    public class Ruta
    {

        public int id { get; set; }
        public Terminal Salida { get; set; }
        public Terminal Llegada { get; set; }
        public double tarifa { get; set; }
        public string descripcionRuta { get; set; }
        public int tipoRuta { get; set; }
        public bool estado { get; set; }

        public Ruta(int id, Terminal salida, Terminal llegada, double tarifa, string descripcionRuta, int tipoRuta, bool estado)
        {
            this.id = id;
            Salida = salida;
            Llegada = llegada;
            this.tarifa = tarifa;
            this.descripcionRuta = descripcionRuta;
            this.tipoRuta = tipoRuta;
            this.estado = estado;
        }
        
            

        public override string ToString()
        {
            return id.ToString();
        }
    }
}
