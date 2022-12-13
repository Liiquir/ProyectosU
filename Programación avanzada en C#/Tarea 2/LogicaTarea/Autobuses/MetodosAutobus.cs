using LogicaTarea.Roles;
using LogicaTarea.Terminales;
using System;

namespace LogicaTarea.Autobuses
{
    public class MetodosAutobus
    {
        public int posicion { get; set; }
        public Autobus[] autobuses;
        public MetodosAutobus()
        {
            autobuses = new Autobus[20];
            posicion = 0;

        }
        public void RegistrarAutobus(int identificacion, string IDplaca,string Marca,string Modelo,int Capacidad,bool estado) //metodo para registrar los autobuses
        {           
                this.autobuses[posicion] = new Autobus(identificacion, IDplaca, Marca, Modelo, Capacidad, estado);               
                posicion++;         
        }


        public string Placa(string identificacion)
        {
            int id = 0;
            while (autobuses[id] != null)
            {
                if (autobuses[id].Identificacion == int.Parse(identificacion))
                {
                    return autobuses[id].IdPlaca;
                }
                id++;
            }
            return null;
        }
        public string Marca(string identificacion)
        {
            int id = 0;
            while (autobuses[id] != null)
            {
                if (autobuses[id].Identificacion==int.Parse(identificacion))
                {
                    return autobuses[id].Marca;
                }
                id++;
            }
            return null;
        }
        public string Capacidad(string identificacion)
        {
            int id = 0;
            while (autobuses[id] != null)
            {
                if (autobuses[id].Identificacion == int.Parse(identificacion))
                {
                    return autobuses[id].Capacidad.ToString();
                }
                id++;
            }
            return null;
        }
        public Autobus ExisteAutobus(int idAutobus)
        {
            int id = 0;
            while (autobuses[id] != null)
            {
                if (autobuses[id].Identificacion == idAutobus)
                {
                    return autobuses[id];
                }
                id++;
            }
            return null;
        }
        public Boolean ExistePlaca(string idPlaca)
        {
            int placa = 0;
            while (autobuses[placa]!=null)
            {
                if (autobuses[placa].IdPlaca.Equals(idPlaca))
                {
                    return false;
                }

            }
            return true;
        }

    }
}
