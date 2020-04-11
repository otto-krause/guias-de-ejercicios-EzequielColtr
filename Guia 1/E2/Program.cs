using System;

namespace E2
{
    class Program
    {
        static void Main(string[] args)
        {
            int id = 0;
            int num = 0;
            int num1 = 0;
            int resultado = 0;
            int i = 0;
            int cociente = 0;

            Console.WriteLine("Ingrese [1] para Multiplicar o [2] para Dividir");
            id = Int32.Parse(Console.ReadLine());

            if (id == 1)
            {
                Console.WriteLine("Ingrese 2 numeros");
                num = Int32.Parse(Console.ReadLine());
                num1 = Int32.Parse(Console.ReadLine());

                for (i = 0 ; i < num1 ; i++)
                {
                    resultado += num;
                }

                Console.WriteLine("El resultado de la multiplicacion es " + resultado);

            }
            else if (id == 2)
            {
                Console.WriteLine("Ingrese 2 numeros");
                num = Int32.Parse(Console.ReadLine());
                num1 = Int32.Parse(Console.ReadLine());

                while(num >= num1)
                {
                    if((num - num1) < 0)
                    {
                        break; 
                    }

                    num = num - num1;
                    cociente++;
                }
                
                Console.WriteLine("El cociente de la divison es " + cociente);
                Console.WriteLine("El resto es " + num);

            }

        }
    }
}
