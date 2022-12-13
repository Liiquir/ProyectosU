using LogicaTarea.Roles;
using Microsoft.SqlServer.Server;
using System;



namespace LogicaTarea.Terminales
{
    public class MetodosTerminal
    {
        
        public int posicion { get; set; }
        
        public Terminal[] terminales;
        public MetodosTerminal()
        {   //creo el arreglo de 20 posiciones como se pide
            terminales = new Terminal[20];
            posicion = 0;
        }
        public void RegistrarTerminal(int id,string terminal,string direccion,string telefono,DateTime apertura,DateTime cierre, bool estado)//metodo para registrar las terminales
        {
                      
                this.terminales[posicion] = new Terminal(id, terminal,direccion, telefono, apertura, cierre, estado);
                this.posicion++;                
        }
        public int IDterminal(string nombreTerminal)
                                                     
        {
            int id = 0;
            while (terminales[id] != null)
            {
                if (terminales[id].NombreTerminal == nombreTerminal)
                {
                    return terminales[id].IdTerminal;
                }
                id++;
            }
            return 0;
        }
        public Terminal ExisteTerminal(int idTerminal)
        {
            int id = 0;
            while (terminales[id] != null)
            {
                if (terminales[id].IdTerminal == idTerminal)
                {
                    return terminales[id];
                }
                id++;
            }
            return null;
        }

    }

}
