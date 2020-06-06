using System;

namespace E3
{
    class Program
    {
        static void Main(string[] args)
        {
            int id = 1;

            string NombreConsolaJugable;

            string Nombre;

            int anioLanzamiento = 0;

            int horas = 0;

            Jugador yo = new Jugador("yo");

            ;

            Console.WriteLine("[0]Salir\n"+
            "[1]Agregar un Juego\n"+
            "[2]Saber cual es el juego mas nuevo\n"+
            "[3]Saber cual es el juego mas viejo\n"+
            "[4]Consola mas usada\n"+
            "[5]Jugar con la CajaX\n"+
            "[6]Jugar con la PC"+
            "[7]Jugar con la Ponystation4"+
            "[8]Jugar con la Ponystation4ProSaladaEdition"+
            "[9]Puntaje de la CajaX"+
            "[10]Puntaje de la PC"+
            "[11]Puntaje de la Ponystation4"+
            "[12]Puntaje de la Ponystation4ProSaladaEdition");

            while(id != 0)
            {
                
                id = Int32.Parse(Console.ReadLine());

                switch(id)
                {
                    case 1:

                        Console.WriteLine("Ingresar Nombre de la consola(CajaX, PC, Ponystation4, Ponystation4ProSaladaEdition");
                        NombreConsolaJugable = Console.ReadLine();

                        Console.WriteLine("Ingresar nombre del juego");
                        Nombre = Console.ReadLine();

                        Console.WriteLine("Ingresar año de lanzamiento");
                        anioLanzamiento = Int32.Parse(Console.ReadLine());

                        yo.adquirirJuego(NombreConsolaJugable, Nombre, anioLanzamiento);
                        break;
                    case 2:
                        Console.WriteLine("Ingresar Nombre de la consola(CajaX, PC, Ponystation4, Ponystation4ProSaladaEdition");
                        NombreConsolaJugable = Console.ReadLine();

                        Console.WriteLine("El juego mas nuevo de la consola elegida es: " + yo.elMasNuevo(NombreConsolaJugable));

                        break;
                    case 3:
                        Console.WriteLine("Ingresar Nombre de la consola(CajaX, PC, Ponystation4, Ponystation4ProSaladaEdition");
                        NombreConsolaJugable = Console.ReadLine();

                        Console.WriteLine("El juego mas nuevo de la consola elegida es: " + yo.elMasViejo(NombreConsolaJugable));

                        break;
                    case 4:
                        Console.WriteLine("Ingresar año de lanzamiento");
                        horas = Int32.Parse(Console.ReadLine());

                        yo.Jugar("CajaX",horas);

                        break;
                    case 5:
                        Console.WriteLine("Ingresar año de lanzamiento");
                        horas = Int32.Parse(Console.ReadLine());

                        yo.Jugar("CajaX",horas);

                        break;
                    case 6:
                        Console.WriteLine("Ingresar año de lanzamiento");
                        horas = Int32.Parse(Console.ReadLine());

                        yo.Jugar("PC",horas);

                        break;
                    case 7:
                        Console.WriteLine("Ingresar año de lanzamiento");
                        horas = Int32.Parse(Console.ReadLine());

                        yo.Jugar("Ponystation4",horas);

                        break;
                    case 8:
                        Console.WriteLine("Ingresar año de lanzamiento");
                        horas = Int32.Parse(Console.ReadLine());

                        yo.Jugar("Ponystation4ProSaladaEdition",horas);

                        break;
                    case 9:
                        Console.WriteLine("Puntaje: " + yo.DevolverPuntaje("CajaX"));
                        break;
                    case 10:
                        Console.WriteLine("Puntaje: " + yo.DevolverPuntaje("PC"));
                        break;
                    case 11:
                        Console.WriteLine("Puntaje: " + yo.DevolverPuntaje("Ponystation4"));
                        break;
                    case 12:
                        Console.WriteLine("Puntaje: " + yo.DevolverPuntaje("Ponystation4ProSaladaEdition"));
                        break;
                }
            }
        }
    }
}
