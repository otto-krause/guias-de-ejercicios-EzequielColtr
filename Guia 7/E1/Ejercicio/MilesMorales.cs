namespace Ejercicio
{
    public class MilesMorales : SpiderMan
    {
        int canto;

        public MilesMorales(int canto, int fuerza)
        {
            this.canto = canto;
            this.fuerza = fuerza;

            poder = fuerza + canto;
        }
    }
}