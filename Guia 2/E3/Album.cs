using System.Collections.Generic;
using System;

namespace E3
{
    public class Album
    {
        public List<Figurita> album = new List<Figurita>();
    
        public Album()
        {
            album.Add(new Figurita("Juan","Delantero","Argentina",20));
            album.Add(new Figurita("Nahuel","Mediocampista","Rusia",60));
            album.Add(new Figurita("Manuel","Defensa","Nigeria",10));
        }

        public void IngresarFigurita(string nombre, string posicion, string pais, int idNum)
        {
            
            foreach (var i in album)
            {
                while(i.nombre == nombre && i.posicion == posicion && i.pais == pais && i.idNum == idNum)
                {
                    
                    Console.WriteLine("Ingrese otro nombre, ese ya esta ocupado");
                    nombre = Console.ReadLine();

                    Console.WriteLine("Ingrese otra posicion, esa ya esta ocupada");
                    posicion = Console.ReadLine();

                    Console.WriteLine("Ingrese otro pais, ese ya esta ocupado");
                    pais = Console.ReadLine();

                    Console.WriteLine("Ingrese otro numero de figurita, ese ya esta ocupado");
                    idNum = Int32.Parse(Console.ReadLine());
                }

            }
            
            album.Add(new Figurita(nombre,posicion,pais,idNum));  
        }

        public void CuantasPosicionesHay()
        {
            int delanteros = 0;
            int mediocampistas = 0;
            int defensa = 0;
        
            foreach (var i in album)
            {
                
                if(i.posicion == "Delantero")
                {
                    delanteros++;
                }
                else if(i.posicion == "Mediocampista")
                {
                    mediocampistas++;
                }
                else if(i.posicion == "Defensa")
                {
                    defensa++;
                }
            }

            Console.WriteLine("Hay " + delanteros + " delanteros\n" + "Hay " + mediocampistas + " mediocampistas\n" + "Hay " + defensa + " defensas\n");
        }

        public void EstaCompleto()
        {
            if(album.Count == 352)
            {
                Console.WriteLine("El album esta completo");
            }
            else
            {
                Console.WriteLine("El album no esta completo");
            }
        }
    
    }
}