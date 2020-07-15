using System;
using System.Collections.Generic;
using System.Linq;

namespace E9
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();

            int num = 1;

            Console.WriteLine("Ingrese un numero hasta ingresar un 0");

            while (num != 0)
            {
                num = Int32.Parse(Console.ReadLine());

                

                if(num != 0)
                {
                    numeros.Add(num);
                }
            }

            Console.WriteLine("Todos los numeros");
            numeros.ForEach(x => Console.WriteLine(x));

            Console.WriteLine("\nCuantos numeros pares hay");
            Console.WriteLine(Matematica.Pares(numeros).Count);

            Console.WriteLine("\nEl primer numero par");
            Console.WriteLine(Matematica.Pares(numeros).Min()); 


            Console.WriteLine("\nTodos los numeros mayores a 50");
            numeros.Where(x => x > 50)
            .ToList()
            .ForEach(x => Console.WriteLine(x));

            Console.WriteLine("\nCuantos numeros mayores a 50 hay");
            Console.WriteLine(numeros.Where(x => x > 50).ToList().Count);           

        }
    }
}
