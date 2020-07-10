using System.Collections.Generic;

namespace E7
{
    public class Fotos
    {
        string directorio;
        string fecha;
        List<Persona> PersonasEtiquetadas;

        public Fotos(string directorio, string fecha, List<Persona> personasEtiquetadas)
        {
            this.directorio = directorio;
            this.fecha = fecha;
            PersonasEtiquetadas = personasEtiquetadas;
        }
    }
}