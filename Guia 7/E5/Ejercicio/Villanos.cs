
namespace Ejercicio
{
    public class Villano
    {
        Quirk quirkDelVillano;
        bool roboEnOnce;
        bool trabajoAlgunaVez;
        bool gustaPizzaConPiña;

        public Villano(Quirk quirkDelVillano, bool roboEnOnce, bool trabajoAlgunaVez, bool gustaPizzaConPiña)
        {
            this.quirkDelVillano = quirkDelVillano;
            this.roboEnOnce = roboEnOnce;
            this.trabajoAlgunaVez = trabajoAlgunaVez;
            this.gustaPizzaConPiña = gustaPizzaConPiña;
        }
    
        public bool esMuyMalo()
        {
            return roboEnOnce && trabajoAlgunaVez && gustaPizzaConPiña;
        }

        public bool siFueBueno(Quirk quirkDelVillano)
        {
            return quirkDelVillano.esPeligroso() && trabajoAlgunaVez;
        }
    
    
    }

    
}