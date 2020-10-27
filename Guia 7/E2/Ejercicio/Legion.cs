using System.Collections.Generic;
using System.Linq;

namespace Ejercicio
{
    public class Legion
    {
        int capacidadAsustar;
        int caramelos;

        Niño Lider;

        List<Niño> legion;

        public Legion(Niño niño, Niño niño1)
        {
            capacidadAsustar = niño.CapacidadAsustar + niño1.CapacidadAsustar;
            caramelos = niño.Caramelos + niño1.Caramelos;
            legion = new List<Niño>{niño,niño1};
            Niño Lider = legion.OrderByDescending(p => p.CapacidadAsustar).First();
        }

        public void AgregarNiño(Niño niño)
        {
            legion.Add(niño);
        }

        public void asustar(Adulto adulto)
        {
            if(adulto.Tipo == "Comun")
            {
                if(adulto.Tolerancia < capacidadAsustar)
                {
                    caramelos = adulto.Tolerancia/2;
                }
            }
            else if(adulto.Tipo == "Abuelo")
            {
                caramelos = adulto.Tolerancia/2;
            }
        
        }
    }
}