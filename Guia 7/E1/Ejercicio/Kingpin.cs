namespace Ejercicio
{
    public class Kingpin
    {
        int hp = 0;

        public Kingpin()
        {
            hp = 800;
        }

        public bool fueVencido()
        {
            return hp < 0;
        }

        public void sacarleVida(int poder)
        {
            hp -= poder;
        }
    }
}