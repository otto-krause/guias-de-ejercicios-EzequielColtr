using System;
using System.Collections.Generic;

namespace E2
{
    public class Empresa
    {
        List<Contrastistas> contrastistas = new List<Contrastistas>();

        public Empresa()
        {
            contrastistas.Add(new Pintores(50));
            contrastistas.Add(new Pintores(40));
            contrastistas.Add(new Pintores(30));
            contrastistas.Add(new Pintores(20));
            contrastistas.Add(new Pintores(10));

            contrastistas.Add(new Plomeros());
            contrastistas.Add(new Plomeros());
            contrastistas.Add(new Plomeros());
            contrastistas.Add(new Plomeros());
            contrastistas.Add(new Plomeros());

            contrastistas.Add(new Albañiles(25,false));
            contrastistas.Add(new Albañiles(35,true));
            contrastistas.Add(new Albañiles(45,false));
            contrastistas.Add(new Albañiles(55,false));
            contrastistas.Add(new Albañiles(65,true));
        }

        public bool SePuedeHacerElTrabajo(int horas, int presupuesto)
        {
            int presupuestoNecesario = 0;
            
            foreach (var i in contrastistas)
            {
                i.trabajar(horas);

                presupuestoNecesario += i.cobrar();
            }

            return presupuestoNecesario < presupuesto;
            
                
            
        }
    }
}