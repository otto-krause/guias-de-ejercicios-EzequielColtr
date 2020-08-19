using System.Collections.Generic;
using System.Linq;

namespace Ejercicio
{
    public class Receta
    {
        List<Ingrediente> ingredientes;
        List<string> pasos;

        public Receta(List<Ingrediente> ingredientes, List<string> pasos)
        {
            this.ingredientes = ingredientes;
            this.pasos = pasos;
        }

        public bool esDeGordo()
        {
            return ingredientes.Sum(Ingrediente => Ingrediente.Calorias) > 2000;
        }

        public bool esRapida()
        {
            return ingredientes.Count / pasos.Count > 1;
        }

        public int Tiempo(VaritaMagica varita)
        {
            if(varita.Tipo == "Acebo")
                return ingredientes.Count + varita.Potencia;
            else
                return pasos.Count / varita.Potencia;

            
        }
    }
}