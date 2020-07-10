using System;
using System.Collections.Generic;

namespace E7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> amigosPepe = new List<string>() {"Bartolito","Juanito","Alejandro"};

            List<Fotos> fotosPepe = new List<Fotos>();
            List<Persona> personasEtiquetadasPepe = new List<Persona>(){};
            fotosPepe.Add(new Fotos("D:","10/02/2010",personasEtiquetadasPepe));

            List<string> publicacionesPepe = new List<string>(){"blablabla","malardo el LoL","aeiou"};

            Persona Pepe = new Persona(amigosPepe,fotosPepe,publicacionesPepe);


            List<string> amigosJuan = new List<string>() {"Bartolito","Pepito","Alejandro"};

            List<Fotos> fotosJuan = new List<Fotos>();
            List<Persona> personasEtiquetadasJuan = new List<Persona>(){Pepe};
            fotosPepe.Add(new Fotos("D:","10/02/2010",personasEtiquetadasJuan));

            List<string> publicacionesJuan = new List<string>(){"blablabla","malardo el LoL","aeiou"};

            Persona Juan = new Persona(amigosJuan,fotosJuan,publicacionesJuan);


            List<string> amigosBartolo = new List<string>() {"Bartolito","Pepito","Juanito"};

            List<Fotos> fotosBartolo = new List<Fotos>();
            List<Persona> personasEtiquetadasBartolo = new List<Persona>(){Juan,Pepe};
            fotosPepe.Add(new Fotos("D:","10/02/2010",personasEtiquetadasBartolo));

            List<string> publicacionesBartolo = new List<string>(){"blablabla","malardo el LoL","aeiou"};

            Persona Bartolo = new Persona(amigosJuan,fotosJuan,publicacionesJuan);
        }
    }
}
