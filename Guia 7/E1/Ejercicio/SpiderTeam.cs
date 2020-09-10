using System.Collections.Generic;
using System.Linq;
using System;

namespace Ejercicio
{
    public class SpiderTeam
    {

        List<SpiderMan> spidermans;
        Kingpin kinpin = new Kingpin();
        
        public SpiderTeam(PeterParker peter, MilesMorales miles, SpiderGwen gwen, SpidermanNoir noir)
        {
            spidermans = new List<SpiderMan>{peter, miles, gwen, noir};
        }

        public void PelearConKingpin()
        {
            spidermans.ForEach(SpiderMan => SpiderMan.Atacar(kinpin));
        }

        public void VolverAcasa()
        {

            if(kinpin.fueVencido())
                spidermans.OrderByDescending(SpiderMan => SpiderMan.Poder)
                .ToList()
                .RemoveAt(3);
            else
                Console.WriteLine("error");
            
        }

        public int FuerzaSpiderTeam()
        {
            return spidermans.Sum(SpiderMan => SpiderMan.Fuerza);
        }

    }
}