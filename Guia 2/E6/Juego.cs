using System.Collections.Generic;
using System;

namespace E6
{
    public class Juego
    {
        public string titulo;
        public string genero;
        public List<int> calificaciones = new List<int>();
        public List<string> comentarios = new List<string>();

        public Juego(string titulo, string genero, List<int> calificaciones, List<string> comentarios)
        {
            this.titulo = titulo;
            this.genero = genero;
            this.calificaciones = calificaciones;
            this.comentarios = comentarios;
        }
    }
}