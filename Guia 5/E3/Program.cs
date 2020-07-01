using System;
using System.Collections.Generic;
using System.Linq;

namespace E3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> DiosesNoRepetido = new List<string>(){""};




            Armadura ArmaduraSeiya = new Armadura("Juan","Plata");
            CaballeronDelZodiaco Seiya = new CaballeronDelZodiaco("Seiya","Atena",ArmaduraSeiya,"Pegaso");

            Armadura ArmaduraShakka = new Armadura("Pepe","Oro");
            CaballeronDelZodiaco Shakka = new CaballeronDelZodiaco("Shaka","Zeus",ArmaduraShakka,"Geminis");

            Armadura ArmaduraShun = new Armadura("Omar","Bronce");
            CaballeronDelZodiaco Shun = new CaballeronDelZodiaco("Shun","Zeus",ArmaduraShun,"Capricornio");


            List<CaballeronDelZodiaco> ListaCaballeros = new List<CaballeronDelZodiaco>(){Seiya,Shakka,Shun};

            ListaCaballeros.Where(CaballeronDelZodiaco => CaballeronDelZodiaco.Dios == "Atena")
            .ToList()
            .ForEach(armadura => Console.WriteLine(armadura.llamarArmadura()));

            
                /*DiosNoRepetido = ListaCaballeros.Where(CaballeronDelZodiaco => DiosNoRepetido != CaballeronDelZodiaco.Dios)
                .First().Dios;
                Console.WriteLine(DiosNoRepetido);*/

            /*foreach (var i in ListaCaballeros)
            {
                foreach (var j in DiosesNoRepetido)
                {
                    if(i.Dios != j)
                    {
                        Console.WriteLine(i.Dios);
                        DiosesNoRepetido.Add(i.Dios);
                    }
                }
            }*/

            
            ListaCaballeros.OrderBy(CaballeronDelZodiaco => CaballeronDelZodiaco.Signo)
            .ToList()
            .ForEach(CaballeronDelZodiaco => Console.WriteLine(CaballeronDelZodiaco.Signo));

        }
    }
}
