﻿using System;

namespace LogicaTarea
{
    public class Conductor
    {
        //propiedades,gets y sets
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public char Genero { get; set; }
        public bool ConductorSupervisor { get; set; }

        public Conductor(string identificacion, string nombre, string primerApellido,
            string segundoApellido, DateTime fechaNacimiento, char genero, bool conductorSupervisor)
        {
            Identificacion = identificacion;
            Nombre = nombre;
            PrimerApellido = primerApellido;
            SegundoApellido = segundoApellido;
            FechaNacimiento = fechaNacimiento;
            Genero = genero;
            ConductorSupervisor = conductorSupervisor;
        }
        //este metodo es para mostrar los datos en la funcion de consultar roles en donde me piden que muestre solamente el nombre y numero de identificacion
        //el metodo para mostrar los todos los datos se encuentra en la clase de metodos conductor
        public string ImprimirDatos()
        {
            return $"Identificación:{Identificacion}\n" +
                $"Nombre:{Nombre+" "+PrimerApellido+" "+SegundoApellido}\n";
        }
    }
}
