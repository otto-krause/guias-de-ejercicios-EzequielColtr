namespace Ejercicio
{
    public class PeterParker : SpiderMan
    {

        int resistenciaTraje = 0;

        public PeterParker(int resistenciaTraje, int fuerza)
        {
            this.resistenciaTraje = resistenciaTraje;
            this.fuerza = fuerza;

            poder = fuerza + resistenciaTraje;
        }

    }
}