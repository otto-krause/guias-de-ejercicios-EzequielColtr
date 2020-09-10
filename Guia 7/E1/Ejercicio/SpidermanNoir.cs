namespace Ejercicio
{
    public class SpidermanNoir : SpiderMan
    {
        int cantArmas;
        int resistenciaTraje;

        public SpidermanNoir(int cantArmas, int fuerza, int resistenciaTraje)
        {
            this.cantArmas = cantArmas;
            this.fuerza = fuerza;

            poder = cantArmas + fuerza + resistenciaTraje;
        }

    }
}