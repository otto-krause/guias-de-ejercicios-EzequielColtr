using System;
using System.Collections.Generic;

namespace E2
{
    public class Empresa
    {
        List<contrastistas> contrastistas = new List<contrastistas>();

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
    }
}