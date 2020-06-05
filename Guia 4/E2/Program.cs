using System;
using System.Collections.Generic;

namespace E2
{
    class Program
    {
        static void Main(string[] args)
        {
            int id = 1;

            int RespetoEmpresa = 0;
            
            List<Mounstro> mounstros = new List<Mounstro>();

            mounstros.Add(new Peligroso(71,"Sulivan"));
            mounstros.Add(new Peligroso(71,"Wasowsky"));

            Console.WriteLine("[0]Salir\n"+
            "[1]NocheDeSusto\n"+
            "[2]NocheDeRisa\n"+
            "[3]Enlistar Respetables\n"+
            "[4]Ver Energia\n");
            
            while(id != 0)
            {
                
                id = Int32.Parse(Console.ReadLine());

                switch(id)
                {
                    case 1:
                        foreach (var i in mounstros)
                        {
                            i.Asustar();
                        }
                        break;
                    case 2:
                        foreach (var i in mounstros)
                        {
                            i.Reir();
                        }
                        break;
                    case 3:
                        foreach (var i in mounstros)
                        {
                            if(i.Respetable())
                            {
                                Console.WriteLine(i.Nombre + "Es respetable");
                            }
                        }
                        break;
                    case 4:
                        foreach (var i in mounstros)
                        {
                           RespetoEmpresa += i.Respeto; 
                        }

                        Console.WriteLine("La energia de la empresa: " + RespetoEmpresa);
                        break;   
                }
            }
        }
    }
}
