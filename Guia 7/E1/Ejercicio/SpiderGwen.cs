

namespace Ejercicio
{
    public class SpiderGwen : SpiderMan
    {
        int glamour;

        public SpiderGwen(int glamour, int fuerza)
        {
            this.glamour = glamour;
            this.fuerza = fuerza;

            poder = fuerza + glamour;
        }
    }
}