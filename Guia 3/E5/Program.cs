using System;

namespace E5
{
    class Program
    {
        static void Main(string[] args)
        {
        
            string armaduraActual = "Falcon";

            string EntrenarSiNo = "";

            int minutos = 0;

            
            Console.WriteLine("Que armadura desea utilizar(Shadow,Falcon)");
            armaduraActual = Console.ReadLine();

            Console.WriteLine("Entrenar? (Si,No)");
            EntrenarSiNo = Console.ReadLine();

            if(EntrenarSiNo == "Si")
            {
                Console.WriteLine("Cuantos minutos");
                minutos = Int32.Parse(Console.ReadLine());
            
                X.entrenar(minutos,armaduraActual);            

            }

            Console.WriteLine("La fuerza de X es: " + X.SaberFuerza(armaduraActual));

            

            


            
        }
    }
}
