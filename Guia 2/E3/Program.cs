using System;

namespace E3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string nombre;
            string posicion;
            string pais;
            int idNum;


            Album FutbolArgentino = new Album();
            

            Console.WriteLine("Ingrese un nombre");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese una posicion(Delantero, Mediocampista, Defensa)");
            posicion = Console.ReadLine();

            Console.WriteLine("Ingrese un pais");
            pais = Console.ReadLine();

            Console.WriteLine("Ingrese el numero de la figurita");
            idNum = Int32.Parse(Console.ReadLine());



            FutbolArgentino.IngresarFigurita(nombre,posicion,pais,idNum);

            FutbolArgentino.CuantasPosicionesHay();

            FutbolArgentino.EstaCompleto();
        }
    }
}
