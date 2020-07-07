  
using System.Collections.Generic;
using System;

namespace E6
{
    public class Pelicula
    {
        protected string nombre;
        protected string genero;
        protected int anio;
        protected string director;

        public string Genero { get => genero;}
        public string Nombre { get => nombre;}
        public int Anio { get => anio;}
        public string Director { get => director;}

        public Pelicula(string nombre, string genero, int anio, string director)
        {
            this.nombre = nombre;
            this.genero = genero;
            this.anio = anio;
            this.director = director;

        }

    }
}