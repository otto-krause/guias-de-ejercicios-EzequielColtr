using System.Collections.Generic;
using System;

namespace E4
{
    public class Peliteca
    {
        List<Pelicula> peliteca = new List<Pelicula>();

        public Peliteca()
        {
            peliteca.Add(new Pelicula("VolverAlFuturo","CienciaFiccion",1985,"Robert Zemeckis"));
            peliteca.Add(new Pelicula("IT","Miedo",2018,"Andrés Muschietti"));
            peliteca.Add(new Pelicula("ShaolinSoccer","Humor",2001,"Stephen Chow"));
        }

        
        public List<Pelicula> RetornarLista()
        {
            return peliteca;
        }

        public int CuantasPelisGenero(string genero)
        {
            int contMismoGenero = 0;
            
            foreach (var i in peliteca)
            {
               if(i.genero == genero)
               {
                   contMismoGenero++;
               }
            }

            return contMismoGenero;
        }

        public int PelisTotales()
        {
            return peliteca.Count;
        }
    }
}