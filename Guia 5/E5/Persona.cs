using System.Collections.Generic;
using System.Linq;

namespace E5
{
    public class Persona
    {
        List<string> conocimientos;

        public Persona(List<string> conocimientos)
        {
            this.conocimientos = conocimientos;
        }
    
        public string Ultimos5()
        {
            List<string> conocimientosAlrevez = new List<string>();
            
            conocimientosAlrevez = conocimientos.Reverse();

            return conocimientosAlrevez[0] + " " + conocimientosAlrevez[1] + " " + conocimientosAlrevez[2] + " " + conocimientosAlrevez[3] + " " + conocimientosAlrevez[4];
        }

        public string Primeros4()
        {
            List<string> conocimientosOrdenados = new List<string>();

            conocimientosOrdenados = conocimientos.OrderBy(Persona => conocimientos).ToList();
            
            return conocimientosOrdenados[0] + " " + conocimientosOrdenados[1] + " " + conocimientosOrdenados[2] + " " + conocimientosOrdenados[3];
            
        }
    
    }

    
}