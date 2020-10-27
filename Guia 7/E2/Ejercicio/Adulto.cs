namespace Ejercicio
{
    public class Adulto
    {
        int caramelos;
        int tolerancia;

        int vecesQueIntentaronAsustarlo;

        string tipo;

        public Adulto(int caramelos, int vecesQueIntentaronAsustarlo, string tipo)
        {
            this.caramelos = caramelos;
            this.vecesQueIntentaronAsustarlo = vecesQueIntentaronAsustarlo;
            this.tipo = tipo;

            tolerancia = 10 * vecesQueIntentaronAsustarlo;
        }

        public string Tipo { get => tipo;}
        public int Tolerancia { get => tolerancia;}
    }
}