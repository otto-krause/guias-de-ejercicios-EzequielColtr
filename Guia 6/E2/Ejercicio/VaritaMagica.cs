namespace Ejercicio
{
    public class VaritaMagica
    {
        string tipo;
        int potencia;

        public VaritaMagica(string tipo, int potencia)
        {
            this.tipo = tipo;
            this.potencia = potencia;
        }

        public int Potencia { get => potencia;}
        public string Tipo { get => tipo;}
    }
}