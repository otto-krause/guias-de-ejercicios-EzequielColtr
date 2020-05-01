using System;

namespace E4
{
    class Program
    {
        static void Main(string[] args)
        {
            int id = 0;
            int min = 0;
            int comida = 0;

            Gatito Ciro = new Gatito("Ciro",true,30);

            Console.WriteLine(" [1] Nombre\n [2] EstaVacunado\n [3] Jugar\n [4] Comer\n [5] EstaSaludable");

            id = Int32.Parse(Console.ReadLine());

            switch(id)
            {
                case 1:
                {
                    Console.WriteLine("El nombre del gato es: " + Ciro.nombreGato());
                    break;
                }
                case 2:
                {
                    if(Ciro.estaVacunado())
                    {
                        Console.WriteLine("El gato esta vacunado");
                    }
                    else
                    {
                        Console.WriteLine("El gato no esta vacunado");
                    }
                    break;
                }
                case 3:
                {
                    Console.WriteLine("Cuantos minutos juega el gato?");
                    min = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Jugó " + min + " minutos y le quedan " + Ciro.jugar(min) + " puntos de energia");

                    break;
                }
                case 4:
                {
                    Console.WriteLine("Cuantos veces come el gato?");
                    comida = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Comio " + comida + " veces y ahora tiene " + Ciro.comer(comida) + " puntos de energia");

                    break;
                }
                case 5:
                {
                    if(Ciro.estaSaludable())
                    {
                        Console.WriteLine("El gato no esta saludable");
                    }
                    else
                    {
                        Console.WriteLine("El gato no esta saludable");
                    }

                    break;
                }
                
            }
        }
    }
}
