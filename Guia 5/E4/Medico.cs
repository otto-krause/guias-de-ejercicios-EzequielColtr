using System.Collections.Generic;
using System;

namespace E4
{
    public class Medico
    {
        public string nombre;
        public string apellido;
        public string especialidad;
        public int cantTurnos;
        

        public Medico(string nombre, string apellido, string especialidad, int cantTurnos)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.especialidad = especialidad;
            this.cantTurnos = cantTurnos;
            
        }

        public bool EstaDisponible()
        {
            return cantTurnos < 50;
        }

    }
}