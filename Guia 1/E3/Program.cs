using System;

namespace E3
{
    class Program
    {

        static bool es_par(int num)
        {
            if(num%2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool es_primo(int num)
        {
            for(int i = 2; i < num ; i++)
            {
                if(num % i == 0 && i != num)
                {
                    return false;
                }
            }

            return true;
        }

        static void Main(string[] args)
        {
            int num = 0;

            Console.WriteLine("Ingrese un numero");
            num = Int32.Parse(Console.ReadLine());

            if(es_par(num))
            {
                Console.WriteLine("El numero es par");
            }

            if(es_primo(num))
            {
                Console.WriteLine("El numero es primo");
            }

        }
    }
}
