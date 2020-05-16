using System;

namespace E3
{
    class Program
    {
        static void Main(string[] args)
        {

            Pc PCdeEscritorio = new Pc();

            PCdeEscritorio.IngresarComponentes();

            Console.WriteLine("El precio total es " + PCdeEscritorio.PrecioTotal());

            if(PCdeEscritorio.SePuedeArmar())
            {
                Console.WriteLine("Se puede armar");
            }
            else
            {
                Console.WriteLine("No se puede armar");
            }
        }
    }
}
