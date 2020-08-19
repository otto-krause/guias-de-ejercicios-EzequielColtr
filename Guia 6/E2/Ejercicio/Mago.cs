using System.Collections.Generic;
using System.Linq;

namespace Ejercicio
{
    public class Mago
    {
        VaritaMagica varita;

        List<Receta> recetas;

        public Mago(VaritaMagica varita, List<Receta> recetas)
        {
            this.varita = varita;
            this.recetas = recetas;
        }

        public bool esUnLento()
        {
            int i = 0;
            bool noEncuentreRecetaRapida = true;

            while (noEncuentreRecetaRapida || i < recetas.Count)
            {
                if(recetas[i].esRapida())
                    noEncuentreRecetaRapida = false;
                else
                    i++;
            }

            return recetas[i].Tiempo(varita) > 30;
        }

        public bool noSeCuida()
        {
            List<Receta> RecetasDeGordo = recetas.Where(Receta => Receta.esDeGordo() == true).ToList();

            return RecetasDeGordo.Count > (recetas.Count/2);
        }
    
    }
}