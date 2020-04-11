using System;

namespace E5
{
    class Program
    {
        static void Main(string[] args)
        {
            int la1 = 0;
            int la2 = 0;
            int la3 = 0;
            int id = 0;

            Console.WriteLine("Ingrese los 3 lados del triangulo");
            la1 = Int32.Parse(Console.ReadLine());
            la2 = Int32.Parse(Console.ReadLine());
            la3 = Int32.Parse(Console.ReadLine());

            triangulo triangulo1 = new triangulo(la1,la2,la3);
            
            Console.WriteLine("\nIngrese:\n[1] Para ver si es escaleno\n[2] Para ver si es isosceles\n[3] Para ver si es equilatero\n[4] Para ver si es rectangulo");

            id = Int32.Parse(Console.ReadLine());

            switch(id)
            {
                case 1:
                {
                    if(triangulo1.esEscaleno())
                    {
                        Console.WriteLine("Es escaleno");
                    }
                    else
                    {
                        Console.WriteLine("No es escaleno");
                    }

                    break;
                }
                case 2:
                {
                    if(triangulo1.esIsosceles())
                    {
                        Console.WriteLine("Es isosceles");
                    }
                    else
                    {
                        Console.WriteLine("No es isosceles");
                    } 

                    break;
                }
                case 3:
                {
                    if(triangulo1.esEquilatero())
                    {
                        Console.WriteLine("Es equilatero");
                    }
                    else
                    {
                        Console.WriteLine("No es equilatero");
                    }

                    break;
                }
                case 4:
                {
                    if(triangulo1.esRectangulo())
                    {
                        Console.WriteLine("Es rectangulo");
                    }
                    else
                    {
                        Console.WriteLine("No es rectangulo");
                    }


                    break;
                }
            }
        }
    }
}
