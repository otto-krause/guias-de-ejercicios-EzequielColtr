using System.Collections.Generic;
using System;

namespace E3
{
    public class Figurita
    {
        public string nombre;
        public string posicion;
        public string pais;
        public int idNum;

        public Figurita(string nombre, string posicion, string pais, int idNum)
        {
            this.nombre = nombre;
            this.posicion = posicion;
            this.pais = pais;
            this.idNum = idNum;
        }
    }
}