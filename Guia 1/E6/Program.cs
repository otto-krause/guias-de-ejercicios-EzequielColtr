using System;

namespace E6
{
    class Program
    {
        static void Main(string[] args)
        {
            int id = 0;
            int num = 0;
            int num1 = 0;

            Console.WriteLine("[1] Fibonacci\n[2] Factorial\n[3] Mayor\n[4] Menor\n[5] Cubo");
            id = Int32.Parse(Console.ReadLine());

            Matematica usuario = new Matematica();

            switch(id)
            {
                case 1:
                {
                    Console.WriteLine("Ingrese un numero");
                    num = Int32.Parse(Console.ReadLine());

                    usuario.fibonacci(num);
                    
                    break;   
                }
                case 2:
                {
                    Console.WriteLine("Ingrese un numero");
    	            num = Int32.Parse(Console.ReadLine());

                    usuario.factorial(num);

                    break;   
                }
                case 3:
                {
                    Console.WriteLine("Ingrese dos numeros");
    	            num = Int32.Parse(Console.ReadLine());
                    num1 = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("El mayor numero es: " + usuario.mayor(num, num1));

                    break;   
                }
                case 4:
                {
                    Console.WriteLine("Ingrese dos numeros");
    	            num = Int32.Parse(Console.ReadLine());
                    num1 = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("El menor numero es: " + usuario.menor(num, num1));

                    break;   
                }
                case 5:
                {
                    Console.WriteLine("Ingrese dos numeros");
    	            num = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("El numero al cubo es " + usuario.cubo(num));


                    break;   
                }
            }
        }
    }
}
