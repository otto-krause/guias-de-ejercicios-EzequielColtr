using System;

namespace Ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Comandos co = new Comandos();
            double longitud = 0;
            double latitud = 0;
            
            Console.WriteLine("Ingrese longitud y latitud");
            longitud = Convert.ToDouble(Console.ReadLine());
            latitud = Convert.ToDouble(Console.ReadLine());

            co.cargarJSON();
            Console.WriteLine(co.Buscar(longitud,latitud));
            Console.WriteLine(co.BuscarTrabajo(longitud,latitud));
        }
    }
}