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
        private string GetEstado()
        {   //idea de if corto obtenida de 
            //https://es.stackoverflow.com/questions/70929/para-que-sirve-el-operador-operador-condicional-en-c
            return estado ? "Activo" : "Inactivo";
        }
        private string GetTipoRuta()
        {
            if (tipoRuta==1)
            {
                return "Directo";
            }
            else
            {
                return "Regular";
            }
        }
        public string ImprimirDatos()
        {
            return $"ID:{id}\n" +
                $"\nTerminal salida\n{Salida.ImprimirDatos()}\n" +
                $"Terminal llegada\n{Llegada.ImprimirDatos()}" +
                $"Tarifa:{tarifa}\n" +
                $"\nDescripción ruta:{descripcionRuta}\n" +
                $"Tipo ruta:{GetTipoRuta()}\n" +
                $"Estado:{GetEstado()}\n";
        }
    }
}
