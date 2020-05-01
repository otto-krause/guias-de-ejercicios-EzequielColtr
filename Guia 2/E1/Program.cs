using System;
using System.Collections.Generic;

namespace E1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>{};

            int num = 1;
            int cont = 0;

            Console.WriteLine("Ingrese numeres hasta ingresar un 0");

            while(num != 0)
            {
                num = Int32.Parse(Console.ReadLine());
                
                if(num > 50)
                {
                    cont++;
                }

                if(num != 0)
                {
                    numeros.Add(num);
                }

            }
            
            Console.WriteLine("Numeros");

            foreach (int i in numeros)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("La lista tiene "+ numeros.Count + " numeros");
            Console.WriteLine("El primer numero es "+ numeros[0]);
            Console.WriteLine("El ultimo numero es "+ numeros[(numeros.Count) - 1]);
            Console.WriteLine("La cantidad de numeros mayor a 50 es "+ cont);


        }
    }
}
