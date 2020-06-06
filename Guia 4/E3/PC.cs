namespace E3
{
    public class PC : Consola
    {

        protected string nombre = "PC";

        public PC(int puntaje) : base(puntaje)
        {

        }

        public override string Nombre()
        {
            return nombre;
        }

        public override void AgregarJuego(string nombre, int anioDeLanzamiento, string nombreDeConsolaJugable)
        {
            juegosDeConsola.Add(new Juego(nombre, anioDeLanzamiento, nombreDeConsolaJugable));
        }

        public override void Jugar(int horas)
        {
            puntaje += 10 * horas;
        }
    }
}