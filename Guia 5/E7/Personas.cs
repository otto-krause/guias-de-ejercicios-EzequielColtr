using System;
using System.Collections.Generic;
using System.Linq;

namespace E7
{
    public class Persona
    {

        List<string> amigos;
        List<Fotos> fotos;

        List<string> publicaciones;

        public Persona(List<string> amigos, List<Fotos> fotos, List<string> publicaciones)
        {
            this.amigos = amigos;
            this.fotos = fotos;
            this.publicaciones = publicaciones;
        }

        public void FotosUltimoAño()
        {
           fotos.Where(Fotos => Fotos.Fecha%10 == 2019)
           .toList()
           .ForEach(Fotos => Console.WriteLine(Fotos.Directorio)) 
        }
    }
}