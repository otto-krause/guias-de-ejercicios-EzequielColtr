using System;
using System.Collections.Generic;

namespace E5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> ConocimientosJuan = new List<string>(){"Actuacion","Cocinar","Pintar"};
            Persona Juan = new Persona(ConocimientosJuan);

            Console.WriteLine("Ultimos 5 conocimientos " + Juan.Ultimos5());
        
            Console.WriteLine("Primeros 4 conocimientos ordenados alfabeticamente" + Juan.Primeros4());
        }
    }
}