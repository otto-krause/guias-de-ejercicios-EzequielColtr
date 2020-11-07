using System;

namespace Ejercicio
{
    public class Arma
    {
        string nombre;
        int potencia;

        public Arma(string nombre, int potencia)
        {
            this.nombre = nombre;
            this.potencia = potencia;
        }

        public int Potencia { get => potencia; set => potencia = value; }
        public string Nombre { get => nombre;}
    }
}
