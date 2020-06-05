using System;

namespace E1
{
    class Program
    {
        static void Main(string[] args)
        {
            int id = 1;

            Animales PerroP = new Perro(20);
            Animales PajaroP = new Pajaro(15);

            Console.WriteLine("[0]Salir\n"+
            "[1]Darle de comer al Perro\n"+
            "[2]Darle de comer al Pajaro\n"+
            "[3]Jugar con el Perro\n"+
            "[4]Jugar con el Pajaro\n"+
            "[5]Dormir a los animales\n"+
            "[6]Ver la energia de los animales");
            
            while(id != 0)
            {
                
                id = Int32.Parse(Console.ReadLine());

                switch(id)
                {
                    case 1:
                        PerroP.Comer();
                        break;
                    case 2:
                        PajaroP.Comer();
                        break;
                    case 3:
                        PerroP.Jugar();
                        break;
                    case 4:
                        PajaroP.Jugar();
                        break;
                    case 5:
                        PajaroP.dormir();
                        PerroP.dormir();
                        break;
                    case 6:
                        Console.WriteLine("Energia del Pajaro " + PajaroP.MostrarEnergia() +
                        "Energia del Perro " + PerroP.MostrarEnergia());
                        break;
                }
            }
            
        }
    }
}
