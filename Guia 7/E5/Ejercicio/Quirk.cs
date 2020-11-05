using System.Collections.Generic;

namespace Ejercicio
{
    public class Quirk
    {
        int tiempoDeUso;
        bool tieneConsecuencias;
        string nombre;
        int poder;

        public Quirk(int tiempoDeUso, bool tieneConsecuencias, string nombre)
        {
            this.tiempoDeUso = tiempoDeUso;
            this.tieneConsecuencias = tieneConsecuencias;
            this.nombre = nombre;
            
            poder = tiempoDeUso * nombre.Length;
        }

        public bool esPeligroso()
        {
            
            return poder > 1000 && tiempoDeUso > 60 || tieneConsecuencias;
            
        }
    }
}