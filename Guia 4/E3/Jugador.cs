using System.Collections.Generic;

namespace E3
{
    public class Jugador
    {
        string nombre;
        List<Consola> ConsolasDeJugador = new List<Consola>();

        public Jugador(string nombre)
        {
            this.nombre = nombre;

            ConsolasDeJugador.Add(new CajaX(20));
            ConsolasDeJugador.Add(new PC(20));
            ConsolasDeJugador.Add(new Ponystation4(20));
            ConsolasDeJugador.Add(new Ponystation4ProSaladaEdition(20));
        }
    
        
        public void adquirirJuego(string NombreDeConsolaJugable, string Nombre, int AnioLanzamiento)
        {
            foreach (var i in ConsolasDeJugador)
            {
                if(NombreDeConsolaJugable == i.Nombre())
                {
                    i.AgregarJuego(Nombre, AnioLanzamiento, NombreDeConsolaJugable);
                    break;
                }
            }
        }
        

        public string LaMasUsada()
        {
            int mayorPuntaje = 0;

            

            foreach (var i in ConsolasDeJugador)
            {
                if(mayorPuntaje < i.Puntaje)
                {
                    mayorPuntaje = i.Puntaje;
                }
            }

            foreach (var i in ConsolasDeJugador)
            {
                if(mayorPuntaje == i.Puntaje)
                {
                    return i.Nombre();
                }
            }

            return "error";

            
        }

        public string elMasNuevo(string NombreDeConsolaJugable)
        {
            foreach (var i in ConsolasDeJugador)
            {
                if(NombreDeConsolaJugable == i.Nombre())
                {
                    return i.elMasNuevo();
                }
            }

            return "error";
        }

        public string elMasViejo(string NombreDeConsolaJugable)
        {
            foreach (var i in ConsolasDeJugador)
            {
                if(NombreDeConsolaJugable == i.Nombre())
                {
                    return i.elMasViejo();
                }
            }

            return "error";
        }

    }
}