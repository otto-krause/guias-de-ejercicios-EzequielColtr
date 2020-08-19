using System.Collections.Generic;
using System.Linq;
using System;

namespace Ejercicio
{
    public class Raven : Titan
    {

        private int felicidad = 0;

        private List<string> pensamientos;

        public Raven(int felicidad, List<string> pensamientos, int tristeza)
        {
            this.felicidad = felicidad;
            this.pensamientos = pensamientos;
            this.tristeza = tristeza;
        }

        public override void comePizza(int porciones)
        {
            felicidad += 2 * porciones;
        }

        public override bool estaTriste()
        {
            int pensamientosNegativos = 0;
            
            foreach (var i in pensamientos)
            {
                if(i.Contains("Papi") || i.Contains("perrito") || i.Contains("Robocop") || i.Contains("Pipo") || i.Contains("MANTECA"))
                {
                    pensamientosNegativos += 1;
                }
            }


            return pensamientosNegativos >= 5 && felicidad == 10;
        }

        public override void llorarPorRobocop()
        {
            pensamientos.RemoveAt(0);
        }

        public override int poder()
        {
            return pensamientos.Where(pensamiento => pensamiento == "Papi" || pensamiento == "perrito" || pensamiento == "Robocop" || pensamiento == "Pipo" || pensamiento == "MANTECA").ToList().Count;
        }

    }
}