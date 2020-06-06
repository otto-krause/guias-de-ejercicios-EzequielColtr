namespace E3
{
    public class Juego
    {
        protected string nombre;
        protected int anioLanzamiento;
        protected string nombreDeConsolaJugable;

        public int AnioLanzamiento { get => anioLanzamiento;}
        public string Nombre { get => nombre;}
        public string NombreDeConsolaJugable { get => nombreDeConsolaJugable;}

        public Juego(string nombre, int anioLanzamiento, string nombreDeConsolaJugable)
        {
            this.nombre = nombre;
            this.anioLanzamiento = anioLanzamiento;
            this.nombreDeConsolaJugable = nombreDeConsolaJugable;
        }
    }
}