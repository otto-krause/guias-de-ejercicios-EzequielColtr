using System.Collections.Generic;
using System;
using System.Linq;


namespace E4
{
    public class Clinica
    {
        List<Medico> medicos = new List<Medico>();

        public Clinica()
        {
            medicos.Add(new Medico("Juan","Gonzales","Nutricionista",20));
            medicos.Add(new Medico("Nahuel","Medina","Dermatologo",60));
            medicos.Add(new Medico("Manuel","Gomez","Traumatologo",10));
        }

        public void PidiendoTurno(string EspecialidadPedida)
        {   

            medicos.Where(Medico => Medico.especialidad == EspecialidadPedida)
            .Where(Medico => Medico.EstaDisponible() == true)
            .ToList()
            .ForEach(Medico => Console.WriteLine("El medico " + Medico.nombre + " lo atendera"));
            /*
            foreach(var i in medicos)
            {
                
                if(i.especialidad == EspecialidadPedida)
                {
                    if(i.EstaDisponible())
                    {
                        return "El medico "+ i.nombre + " lo atendera";
                        
                    }
                    
                }
            }

            return "Intentelo mas tarde";
            */
        }
        
    }
}