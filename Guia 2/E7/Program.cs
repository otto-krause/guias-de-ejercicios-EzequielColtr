using System.Collections.Generic;
using System;

namespace E7
{
    class Program
    {
        static void Main(string[] args)
        {
            Argentina Pais = new Argentina();

            Console.WriteLine("El estado de la inflacion: "+ Pais.EstadoDeInflacion());

            if(Pais.EstadoDefault())
            {
                Console.WriteLine("Hay estado de default");
            }
            else
            {
                Console.WriteLine("No hay estado de default");
            }
        }
    }
}
