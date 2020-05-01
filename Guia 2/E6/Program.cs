using System.Collections.Generic;
using System;

namespace E6
{
    class Program
    {
        static void Main(string[] args)
        {
            int id = 0;
            int calif = 0;
            string gener;
            Steam SteamStore = new Steam();

            Console.WriteLine("[1]Calificacion\n[2]Genero");
            id = Int32.Parse(Console.ReadLine());

            if(id == 1)
            {
                Console.WriteLine("[1]Alta\n[2]Media\n[3]Baja");
                calif = Int32.Parse(Console.ReadLine());

                SteamStore.JuegoPorCalificacion(calif);
            }
            else if(id == 2)
            {
                Console.WriteLine("Ingrese su genero(MOBA,RTS)");
                gener = Console.ReadLine();

                SteamStore.JuegoPorGenero(gener);
            }

            
        }
    }
}
