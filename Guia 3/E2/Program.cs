using System;

namespace E2
{
    class Program
    {
        static void Main(string[] args)
        {
            int horas = 0;

            int presupuesto = 0;

            Empresa ConstruccionesPiolas = new Empresa();

            Console.WriteLine("Ingrese la cantidad que desea que cada constructor trabaje:");
            horas = Int32.Parse(Console.ReadLine());

            
            Console.WriteLine("Ingrese el presupuesto");
            presupuesto = Int32.Parse(Console.ReadLine());

            if(ConstruccionesPiolas.SePuedeHacerElTrabajo(horas,presupuesto))
            {
                Console.WriteLine("Se puede hacer el trabajo");
            }
            else
            {
                Console.WriteLine("No se puede hacer el trabajo");
            }

        }
    }
}
