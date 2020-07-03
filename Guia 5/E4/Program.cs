  
using System;
using System.Collections.Generic;


namespace E4
{
    class Program
    {
        static void Main(string[] args)
        {
            Clinica Mitre = new Clinica();

            string especialidad;
        
            Console.WriteLine("Elija una especialidad(Nutricionista, Dermatologo, Traumatologo)");

            especialidad = Console.ReadLine();

            Mitre.PidiendoTurno(especialidad);
        }
    }
}