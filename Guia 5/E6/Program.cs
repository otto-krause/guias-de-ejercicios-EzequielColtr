using System.Collections.Generic;
using System;
using System.Linq;

namespace E6
{
    class Program
    {
        static void Main(string[] args)
        {
            int referencia = 0;
            string genero;
            string nombre;
            int anio;
            string director;
            
            Peliteca PelisPiolas = new Peliteca();

            Console.WriteLine("[1] Genero [2] Nombre [3] año [4] Director");
            referencia = Int32.Parse(Console.ReadLine());

            switch(referencia)
            {
                case 1:
                {
                    Console.WriteLine("Que genero quiere buscar(CienciaFiccion, Miedo, Humor)");
                    genero = Console.ReadLine();

                    PelisPiolas.Pelitecas.Where(Pelicula => Pelicula.Genero == genero)
                    .ToList()
                    .ForEach(Pelicula => Console.WriteLine("Titulo: " + Pelicula.Nombre + " Genero: " + Pelicula.Genero + " Director: " + Pelicula.Director + " Año: " + Pelicula.Anio));

                    break;
                }

                case 2:
                {
                    Console.WriteLine("Que Nombre quiere buscar(VolverAlFuturo, IT, ShaolinSoccer)");
                    nombre = Console.ReadLine();

                    PelisPiolas.Pelitecas.Where(Pelicula => Pelicula.Nombre == nombre)
                    .ToList()
                    .ForEach(Pelicula => Console.WriteLine(Pelicula.Nombre));

                    break;
                }
                case 3:
                {
                    Console.WriteLine("Que Año quiere buscar(1985, 2018, 2001)");
                    anio = Int32.Parse(Console.ReadLine());

                    PelisPiolas.Pelitecas.Where(Pelicula => Pelicula.Anio == anio)
                    .ToList()
                    .ForEach(Pelicula => Console.WriteLine(Pelicula.Nombre));
 
                    break;
                }
                case 4:
                {
                    Console.WriteLine("Que Director quiere buscar(Robert Zemeckis, Andrés Muschietti, Stephen Chow)");
                    director = Console.ReadLine();

                    PelisPiolas.Pelitecas.Where(Pelicula => Pelicula.Director == director)
                    .ToList()
                    .ForEach(Pelicula => Console.WriteLine(Pelicula.Nombre));
         
                    break;
                }
                
            }
            
            

            Console.WriteLine("Ingrese un genero");
            genero = Console.ReadLine();
            Console.WriteLine("Existen " + PelisPiolas.CuantasPelisGenero(genero) + " del mismo genero");
            Console.WriteLine("Existen " + PelisPiolas.PelisTotales() + " Peliculas en total");

            

        }
    }
}