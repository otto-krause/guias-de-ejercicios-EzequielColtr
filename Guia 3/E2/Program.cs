using System;

namespace E2
{
    class Program
    {
        static void Main(string[] args)
        {
            int horas = 0;

            Console.WriteLine("Ingrese la cantidad que desea que cada constructor trabaje:");
            horas = Int32.Parse(Console.ReadLine());

            contrastistas.trabajar(horas);

        }
    }
}
