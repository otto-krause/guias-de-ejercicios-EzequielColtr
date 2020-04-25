using System.Collections.Generic;
using System;

namespace E4
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

                    foreach (var i in PelisPiolas.RetornarLista())
                    {
                        if(i.genero == genero)
                        {
                            Console.WriteLine("Titulo: " + i.nombre + " Genero: " + i.genero + " Director: " + i.director + " Año: " + i.anio);
                        }
                    }

                    break;
                }

                case 2:
                {
                    Console.WriteLine("Que Nombre quiere buscar(VolverAlFuturo, IT, ShaolinSoccer)");
                    nombre = Console.ReadLine();

                    foreach (var i in PelisPiolas.RetornarLista())
                    {
                        if(i.nombre == nombre)
                        {
                            Console.WriteLine(i.nombre);
                        }
                    }
                       
                    break;
                }
                case 3:
                {
                    Console.WriteLine("Que Año quiere buscar(1985, 2018, 2001)");
                    anio = Int32.Parse(Console.ReadLine());

                    foreach (var i in PelisPiolas.RetornarLista())
                    {
                        if(i.anio == anio)
                        {
                            Console.WriteLine(i.nombre);
                        }
                    }
                       
                    break;
                }
                case 4:
                {
                    Console.WriteLine("Que Director quiere buscar(Robert Zemeckis, Andrés Muschietti, Stephen Chow)");
                    director = Console.ReadLine();

                    foreach (var i in PelisPiolas.RetornarLista())
                    {
                        if(i.director == director)
                        {
                            Console.WriteLine(i.nombre);
                        }
                    }
                       
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
