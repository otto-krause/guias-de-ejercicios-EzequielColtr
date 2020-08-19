namespace Ejercicio
{
    public class Arma
    {
        private int potencia;

        private int dureza;

        public Arma(int potencia, int dureza)
        {
            this.potencia = potencia;
            this.dureza = dureza;
        }

        public int Fuerza()
        {
           return potencia + Fibonacci();
        }

        public int Fibonacci()
        {
            int a = 0;
            int b = 1;
            
            for (int i = 0; i < dureza; i++)
            {
                int c = a;
                a = b;
                b = c + b;
            }
            return a;
        }
    }
}