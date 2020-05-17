using System;
using System.Collections.Generic;

namespace E4
{
    public class Tragalibros
    {
        List<Libro> LibrosLeidos = new List<Libro>();

        public Tragalibros()
        {
            LibrosLeidos.Add(new Libro("Harry Potter","J.K Rowling"));
            LibrosLeidos.Add(new Libro("Harry Potter 2","J.K Rowling"));
        }

        public void Leer(Libro libroNuevo)
        {
            bool EsRepetido = false;


            foreach (var i in LibrosLeidos)
            {
                if(i.PedirTitulo == libroNuevo.PedirTitulo)
                {
                    EsRepetido = true;
                }

                if(!EsRepetido)
                {
                    LibrosLeidos.Add(libroNuevo);
                }
            }
        }

        public int CalcularCI()
        {
            int CI = 1;
            
            return CI * LibrosLeidos.Count;
            
        }
    
    }
}