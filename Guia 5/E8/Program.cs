using System;
using System.Collections.Generic;
using System.Linq;

namespace E8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>() {1,2,3,3,4,5,6,7,8,9};

            Console.WriteLine("Numeros Primos");
            Matematica.Primos(numeros).ForEach(x => Console.WriteLine(x));

            Console.WriteLine("\nNumeros Pares");
            Matematica.Pares(numeros).ForEach(x => Console.WriteLine(x));

            Console.WriteLine("\nNumeros Aplanados");
            Matematica.Aplanar(numeros).ForEach(x => Console.WriteLine(x));

            Console.WriteLine("\nSuma");
            Console.WriteLine(Matematica.Suma(numeros));

            Console.WriteLine("\nSuma Primos");
            Console.WriteLine(Matematica.SumaPrimos(numeros));
        
            Console.WriteLine("\nNumero Mayor");
            Console.WriteLine(Matematica.Mayor(numeros));

            Console.WriteLine("\nNumero Menor");
            Console.WriteLine(Matematica.Menor(numeros));
        }
    }
}
