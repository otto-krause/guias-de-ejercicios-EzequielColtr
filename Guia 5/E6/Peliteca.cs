using System.Collections.Generic;
using System;
using System.Linq;

namespace E6
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

        public List<Pelicula> Pelitecas { get => peliteca;}

        public int CuantasPelisGenero(string genero)
        {
            int contMismoGenero = 0;
            
            List<Pelicula> pelisMismoGenero = new List<Pelicula>();

            pelisMismoGenero = peliteca.Where(Pelicula => Pelicula.Genero == genero)
            .ToList();

            contMismoGenero = pelisMismoGenero.Count;

            return contMismoGenero;
        }

        public int PelisTotales()
        {
            return peliteca.Count;
        }
    }
}