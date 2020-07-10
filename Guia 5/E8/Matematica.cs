using System.Collections.Generic;
using System.Linq;

namespace E8
{
    public static class Matematica
    {
        public static List<int> Primos(List<int> numeros)
        {
            List<int> NumerosPrimos = new List<int>();

            NumerosPrimos = numeros.Where(x => x % x == 0 && x % 1 == 0)
            .ToList();

            return NumerosPrimos;
        }

        public static List<int> Pares(List<int> numeros)
        {
            List<int> NumerosPares = new List<int>();

            NumerosPares = numeros.Where(x => x % 2 == 0)
            .ToList();

            return NumerosPares;
        }

        public static List<int> Aplanar(List<int> numeros)
        {
            List<int> NumerosNoRepetidos = new List<int>();

            NumerosNoRepetidos = numeros.Distinct().ToList();

            return NumerosNoRepetidos;
        }

        public static int Suma(List<int> numeros)
        {
            int Suma = 0;

            numeros.ForEach(x => Suma += x);

            return Suma;
        }

        public static int SumaPrimos(List<int> numeros)
        {
            int Suma = 0;
            List<int> NumerosPrimos = new List<int>();

            NumerosPrimos = Matematica.Primos(numeros);

            NumerosPrimos.ForEach(x => Suma += x);

            return Suma;
        }

        public static int Mayor(List<int> numeros)
        {
            List<int> NumerosOrdenadosAscendente = new List<int>();

            NumerosOrdenadosAscendente = numeros.OrderByDescending(x => x).ToList();

            return NumerosOrdenadosAscendente[0];
        }

        public static int Menor(List<int> numeros)
        {
            List<int> NumerosOrdenadosDescendiente = new List<int>();

            NumerosOrdenadosDescendiente = numeros.OrderByDescending(x => x).ToList();

            return NumerosOrdenadosDescendiente[(NumerosOrdenadosDescendiente.Count)-1];
        }


    }
}