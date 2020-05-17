using System;

namespace E4
{
    class Program
    {
        static void Main(string[] args)
        {
            string titulo;

            string autor;

            Tragalibros Juanito = new Tragalibros();

            Console.WriteLine("Ingrese el titulo y autor de un libro");

            titulo = Console.ReadLine();
            autor = Console.ReadLine();

            Libro libro = new Libro(titulo,autor);

            Juanito.Leer(libro);

            Console.WriteLine("El CI de Juanito es " + Juanito.CalcularCI()); 
        }
    }
}
