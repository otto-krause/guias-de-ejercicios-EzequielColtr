using System.Collections.Generic;

namespace E3
{
    public abstract class Consola
    {
        protected int puntaje;

        public abstract string Nombre();

        protected List<Juego> juegosDeConsola;

        public int Puntaje { get => puntaje;}

        public Consola(int puntaje)
        {
            this.puntaje = puntaje;
            juegosDeConsola = new List<Juego>();
        }



        public abstract void AgregarJuego(string nombre, int anioDeLanzamiento, string nombreDeConsolaJugable);
        
        public abstract void Jugar(int horas);

        public string elMasNuevo()
        {
            int AnioJuegoMasNuevo = 0;

            string JuegoNuevo = "";

            foreach (var i in juegosDeConsola)
            {
                if(AnioJuegoMasNuevo < i.AnioLanzamiento)
                {
                    AnioJuegoMasNuevo = i.AnioLanzamiento;
                }
            }

            foreach (var i in juegosDeConsola)
            {
                if(AnioJuegoMasNuevo == i.AnioLanzamiento)
                {
                    JuegoNuevo = i.Nombre;
                }
            }

            return JuegoNuevo;
        }

        public string elMasViejo()
        {
            int AnioJuegoMasViejo = 0;

            string JuegoViejo = "";

            foreach (var i in juegosDeConsola)
            {
                if(AnioJuegoMasViejo < i.AnioLanzamiento)
                {
                    AnioJuegoMasViejo = i.AnioLanzamiento;
                }
            }

            foreach (var i in juegosDeConsola)
            {
                if(AnioJuegoMasViejo == i.AnioLanzamiento)
                {
                    JuegoViejo = i.Nombre;
                }
            }

            return JuegoViejo;
        }

        public virtual int devolverPuntaje()
        {
            return puntaje;
        }
    }
}