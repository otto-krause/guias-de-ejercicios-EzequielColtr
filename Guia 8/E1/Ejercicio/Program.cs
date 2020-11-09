using System;
using System.IO;

namespace Ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            string pelicula;
            
            Console.WriteLine("Escribir una pelicula");
            pelicula = Console.ReadLine();

            ComandosPeliculas.ingresarPeliculas(pelicula);
            //ComandosPeliculas.verTodasLasPeliculas();
            ComandosPeliculas.verTodasLasPeliculasSinRepetidos();

        }
    }
}
