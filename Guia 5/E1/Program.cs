using System;
using System.Collections.Generic;
using System.Linq;

namespace E1
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;
            
            List<Persona> personas = new List<Persona>();

            personas.Add(new Persona(18,"Pepe","Ortega"));
            personas.Add(new Persona(20,"Juan","Ortega"));
            personas.Add(new Persona(8,"Nahuel","Perez"));

            Console.WriteLine("Mayores de edad:");
            personas.Where(persona => persona.Edad >= 18)
            .ToList()
            .ForEach(persona => Console.WriteLine(persona.Nombre));

            Console.WriteLine("Personas que se llaman Juan:");
            personas.Where(persona => persona.Nombre == "Juan")
            .ToList()
            .ForEach(persona => Console.WriteLine(persona.Nombre + " " + persona.Apellido));

            Console.WriteLine("Cantidad de personas que se apellidan Perez:");
            foreach (var i in personas)
            {
                if(i.Apellido == "Perez")
                {
                    cont++;
                }
            }
            Console.WriteLine(cont);
            
        }
    }
}
