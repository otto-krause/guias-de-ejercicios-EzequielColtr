using System.Collections.Generic;
using System.Linq;

namespace Ejercicio
{
    public class Robin : Titan
    {

        List<Arma> arsenal;

        public Robin(List<Arma> arsenal, int tristeza)
        {
            this.arsenal = arsenal;
            this.tristeza = tristeza;
        }

        public override void comePizza(int porciones)
        {
            tristeza -= 1 * porciones;
        }
        public override bool estaTriste()
        {
            return arsenal.Max(Arma => Arma.Fuerza()) < 100 && tristeza > 25;
        }
        public override void llorarPorRobocop()
        {
            tristeza += 6;
        }

        public override int poder()
        {
            return arsenal.Max(Arma => Arma.Fuerza()) - tristeza;
        }
    }
}