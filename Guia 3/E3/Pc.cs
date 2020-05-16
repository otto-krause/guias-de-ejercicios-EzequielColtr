using System;
using System.Collections.Generic;

namespace E3
{
    public class Pc
    {
        List<Componentes> Componentes = new List<Componentes>();
    
        Motherboard MotherboardASUS = new Motherboard("DDR4","Si","Si");

        public int PrecioTotal()
        {
            int precioTotal = 0;

            foreach(var i in Componentes)
            {
                precioTotal += i.Precio();
            }

            


            return precioTotal;
        }
        
        public bool SePuedeArmar()
        {
            foreach (var i in Componentes)
            {
                return (!i.EsCompatible(MotherboardASUS));
                
            }

            return true;
        }

        public void IngresarComponentes()
        {
            string tipoRAM;

            string tipoSSD;

            string tipoHHD;

            string tipoPlacaDeVideo;

            string tipoLectoraCD;

            int precioAux;
            
            Console.WriteLine("Ingrese el tipo de su MemoriaRam(DDR3, DDR4)\nY tambien su precio");
            tipoRAM = Console.ReadLine();
            precioAux = Int32.Parse(Console.ReadLine());
            
            MemoriaRam memoriaRam = new MemoriaRam(tipoRAM,precioAux);



            Console.WriteLine("Su SSD es por Sata? (Si,No)\nY tambien su precio");
            tipoSSD = Console.ReadLine();
            precioAux = Int32.Parse(Console.ReadLine());
            Componentes.Add(new DiscoSSD(precioAux,tipoSSD));



            Console.WriteLine("Su HHD es por Sata? (Si,No)\nY tambien su precio");
            tipoHHD = Console.ReadLine();
            precioAux = Int32.Parse(Console.ReadLine());
            Componentes.Add(new DiscoHHD(precioAux,tipoHHD));



            Console.WriteLine("Su Placa de video es por PCIE? (Si,No)\nY tambien su precio");
            tipoPlacaDeVideo = Console.ReadLine();
            precioAux = Int32.Parse(Console.ReadLine());
            Componentes.Add(new PlacaDeVideo(precioAux,tipoPlacaDeVideo));



            Console.WriteLine("Su Lectora de CD es por Sata? (Si,No)\nY tambien su precio");
            tipoLectoraCD = Console.ReadLine();
            precioAux = Int32.Parse(Console.ReadLine());
            Componentes.Add(new LectoraDeCD(precioAux,tipoLectoraCD)); 
        }


    
    }

    
}