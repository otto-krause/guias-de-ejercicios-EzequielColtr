using System.Collections.Generic;
using System;

namespace E6
{
    public class Steam
    {
        List<Juego> juegos = new List<Juego>();

        int promCalif = 0;

        List<int> califLoL = new List<int>() {1,5,3};
        List<string> comenLoL = new List<string>() {"Malardo","Guenardo","Masome"};
        List<int> califDota2 = new List<int>() {4,5,4};
        List<string> comenDota2 = new List<string>() {"Mejor que el LoL","Guenardo","Esta Wenardo"};
        List<int> califSC2 = new List<int>() {4,5,4};
        List<string> comenSC2 = new List<string>() {"Chinitos reflejos rapidos","Los zergs la mejor raza lejos","Wang chin chonn"};

        public Steam()
        {
            juegos.Add(new Juego("LoL","MOBA",califLoL,comenLoL));
            juegos.Add(new Juego("Dota2","MOBA",califDota2,comenDota2));
            juegos.Add(new Juego("SC2","RTS",califSC2,comenSC2));
        }
    
        public void JuegoPorCalificacion(int calif)
        {
            

            foreach (var i in juegos)
            {
                foreach (var j in i.calificaciones)
                {
                    promCalif += j;
                }
                
                promCalif = promCalif/i.calificaciones.Count;

                if(calif == 1)
                {
                    if(promCalif >= 4)
                    {
                        Console.WriteLine("\n");
                        
                        Console.WriteLine(i.titulo);
                        Console.WriteLine(i.genero);
                        Console.WriteLine(promCalif);

                        foreach (var k in i.comentarios)
                        {
                            Console.WriteLine(k);
                        }

                        Console.WriteLine("\n");
                    }
                }
                else if(calif == 2)
                {
                    if(promCalif == 3)
                    {
                        Console.WriteLine("\n");
                        
                        Console.WriteLine(i.titulo);
                        Console.WriteLine(i.genero);
                        Console.WriteLine(promCalif);
                        
                        foreach (var k in i.comentarios)
                        {
                            Console.WriteLine(k);
                        }

                        Console.WriteLine("\n");
                    }
                }
                else if(calif == 3)
                {
                    if(promCalif <= 2)
                    {
                        Console.WriteLine("\n");
                        
                        Console.WriteLine(i.titulo);
                        Console.WriteLine(i.genero);
                        Console.WriteLine(promCalif);
                        
                        foreach (var k in i.comentarios)
                        {
                            Console.WriteLine(k);
                        }

                        Console.WriteLine("\n");
                    }
                }

                promCalif = 0;

            }
        }

        public void JuegoPorGenero(string gener)
        {
            
            foreach (var i in juegos)
            {
               if(gener == i.genero)
               {
                  foreach (var j in i.calificaciones)
                  {
                    promCalif += j;
                  }

                  Console.WriteLine("\n");
                  
                  Console.WriteLine(i.titulo," ",i.genero," ",promCalif);
                        
                  foreach (var k in i.comentarios)
                  {
                    Console.WriteLine(k);
                  } 

                  Console.WriteLine("\n");
               } 
            }
        }
    
    
    }
}