namespace Ejercicio
{
    public abstract class SpiderMan
    {
        protected int poder;

        protected int fuerza;

        public void Atacar(Kingpin kinpin)
        {
            kinpin.sacarleVida(poder);
        }
    }
}