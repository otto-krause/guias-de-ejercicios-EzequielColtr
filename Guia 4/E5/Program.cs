using System;

namespace E5
{
    class Program
    {
        static void Main(string[] args)
        {
            Humano humano = new Humano();
            Robot robot = new Robot();
            Cyborg cyborg = new Cyborg();

            int id = 1;
            string tema = "";

            Console.WriteLine("[0]Salir\n"+
            "[1]Hacer estudiar a Humano\n"+
            "[2]Hacer pensar a Humano\n"+
            "[3]Hacer estudiar a Robot\n"+
            "[4]Hacer pensar a Robot\n"+
            "[5]Hacer estudiar a Cyborg\n"+
            "[6]Hacer pensar a Cyborg"+
            "[7]Ver inteligencia de Todos");
            
            while(id != 0)
            {
                
                id = Int32.Parse(Console.ReadLine());

                switch(id)
                {
                    case 1:
                        Console.WriteLine("Ingrese el tema");
                        tema = Console.ReadLine();

                        humano.estudiar(tema);
                        break;
                    case 2:
                        Console.WriteLine("Ingrese el tema");
                        tema = Console.ReadLine();

                        humano.pensar(tema);
                        break;
                    case 3:
                        Console.WriteLine("Ingrese el tema");
                        tema = Console.ReadLine();

                        robot.estudiar(tema);
                        break;
                    case 4:
                        robot.pensar("");
                        break;
                    case 5:
                        Console.WriteLine("Ingrese el tema");
                        tema = Console.ReadLine();

                        cyborg.estudiar(tema);
                        break;
                    case 6:
                        cyborg.pensar("");
                        break;
                    case 7:
                        Console.WriteLine("Inteligencia de Humano "+ humano.Inteligencia +
                        "\nInteligencia de Robot "+ robot.Inteligencia +
                        "\nInteligencia de Cyborg " + cyborg.Inteligencia);
                        break;
                }
            }
        }
    }
}
