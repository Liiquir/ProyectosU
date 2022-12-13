using LogicaTarea.Terminales;
using System;

namespace LogicaTarea.Rutas
{
    public class MetodosRuta
    {
        public int posicion { get; set; }
        public Ruta[] rutas;
        MetodosTerminal metodosTerminal { get; set; }
        public MetodosRuta(MetodosTerminal metodosTerminal)
        {
            this.metodosTerminal = metodosTerminal;
            rutas = new Ruta[20];
            posicion = 0;

        }
        public void RegistrarRutas(int ID,Terminal salida,Terminal llegada,double tarifa,string descripcionRuta,int tipoRuta,bool estado)//metodo para registrar las rutas
        {                        
            
                            rutas[posicion] = new Ruta(ID, salida, llegada, tarifa, descripcionRuta, tipoRuta, estado);
                            posicion++;                        
        }     
        public Ruta ExisteRuta(int idRuta)
        {
            int id = 0;
            while (rutas[id] != null)
            {
                if (rutas[id].id == idRuta)
                {
                    return rutas[id];
                }
                id++;
            }
            return null;
        }
        public int Tipo(string idruta)
        {
            int id = 0;
            while (rutas[id] != null)
            {
                if (rutas[id].id == int.Parse(idruta))
                {
                    return rutas[id].tipoRuta;
                }
                id++;
            }
            return 0;
        }
        public double Tarifa(string idruta)
        {
            int id = 0;
            while (rutas[id] != null)
            {
                if (rutas[id].id == int.Parse(idruta))
                {
                    return rutas[id].tarifa;
                }
                id++;
            }
            return 0;
        }
        public string TerminalDestino(string idruta)
        {
            int id = 0;
            while (rutas[id] != null)
            {
                if (rutas[id].id == int.Parse(idruta))
                {
                    return rutas[id].Llegada.NombreTerminal;
                }
                id++;
            }
            return null;
        }
        public string TerminalOrigen(string idruta)

        {
            int id = 0;
            while (rutas[id] != null)
            {
                if (rutas[id].id == int.Parse(idruta))
                {
                    return rutas[id].Salida.NombreTerminal;
                }
                id++;
            }
            return null;
        }

    }

}
