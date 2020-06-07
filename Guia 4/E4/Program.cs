using System;

namespace E4
{
    class Program
    {
        static void Main(string[] args)
        {
            int id = 1;

            int personas = 0;

            string clase = "";

            RRHH rrhh = new RRHH(5000);
            Programador programador = new Programador(5000);
            Administrativo administrativo = new Administrativo(5000);

            Console.WriteLine("[0]Salir\n"+
            "[1]Depositar al RRHH\n"+
            "[2]Depositar al Programador\n"+
            "[3]Depositar al Administrativo\n"+
            "[4]Mostrar Cajabancaria de los 3");
            
            while(id != 0)
            {
                
                id = Int32.Parse(Console.ReadLine());

                switch(id)
                {
                    case 1:

                        Console.WriteLine("Cuantas Personas?");

                        personas = Int32.Parse(Console.ReadLine());

                        rrhh.depositar(personas,"");
                        break;
                    case 2:
                        Console.WriteLine("Que clase? (junior, semiJunior, senior");

                        clase = Console.ReadLine();

                        programador.depositar(0,clase);
                        break;
                    case 3:
                        administrativo.depositar(0,"");
                        break;
                    case 4:
                        Console.WriteLine("CajaBancaria del RRHH "+ rrhh.CajaBancaria +
                        "\nCajaBancaria del Programador "+ programador.CajaBancaria +
                        "\nCajaBancaria del Administrativo "+ administrativo.CajaBancaria);
                        break;
                }
            }
        }
    }
}
