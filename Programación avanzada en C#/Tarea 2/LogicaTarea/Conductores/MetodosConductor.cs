using System;

namespace LogicaTarea.Conductores
{
    public class MetodosConductor
    {
        private int posicion { get; set; }
        public Conductor[] conductores;
        public MetodosConductor()
        {
            conductores = new Conductor[20];
            posicion = 0;

        }


        public void RegistrarConductor(string identificacion, string nombre,string primerApellido,
                string segundoApellido,DateTime fechaNacimiento,char genero, bool conductorSupervisor) //metodo para registrar los conductores que recibe los parametros

        {
            
                this.conductores[posicion] = new Conductor(identificacion, nombre, primerApellido,
                 segundoApellido, fechaNacimiento, genero, conductorSupervisor);
                
                this.posicion++;
               

            

        }
      
        public Conductor Conductor(string idConductor)
        {
            int id = 0;
            while (conductores[id] != null)
            {
                if (conductores[id].Identificacion == idConductor)
                {
                    return conductores[id];
                }
                id++;
            }
            return null;
        }
        public Boolean ExisteConductor(string idConductor)
        {
            int id = 0;
            while (conductores[id] != null)
            {
                if (conductores[id].Identificacion.Equals(idConductor))
                {
                    return false;
                }
                id++;
            }
            return true;
        }


    }
}
