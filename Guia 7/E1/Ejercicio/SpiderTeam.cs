using System.Collections.Generic;
using System.Linq;

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

    }
}