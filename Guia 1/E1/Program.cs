using System;

namespace E1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vector = new int[10];
            int suma = 0;
            int promedio = 0;
            int menor = 0;
            int aux = 0;
            int j;
            
            for (int i = 0 ; i < 10 ; i++)
            {
                Console.WriteLine("Ingrese un numero: ");
                vector[i] = Int32.Parse(Console.ReadLine());
                suma += vector[i];
            }
            
            menor = vector[0];

            for (int i = 0 ; i < 10 ; i++)
            {
                if(menor > vector[i])
                {
                    menor = vector[i];
                }
            }

            for (int i=0 ; i<(10-1) ; i++)
            {
                for (j=i+1 ; j<10 ; j++)
                {
                    if (vector[i] < vector[j])
                    {
                        aux=vector[i];
                        vector[i]=vector[j];
                        vector[j]=aux;
                    }
                }
            }

            promedio = suma/10;

            Console.WriteLine("La suma de todos los numeros es: " + suma);
            Console.WriteLine("El promedio de todos los numeros es: " + promedio);
            Console.WriteLine("El menor numero es: " + menor);
            Console.Write("Vector ordenado de mayor a menor:");

            for (int i = 0 ; i < 10 ; i++)
            {
                Console.Write(" " + vector[i] + " ");
            }

        }
    }
}
