namespace E3
{
    public class Ponystation4 : Consola
    {

        protected string nombre = "Ponystation4";

        public Ponystation4(int puntaje) : base(puntaje)
        {

        }

        public override string Nombre()
        {
            return nombre;
        }

        public override void AgregarJuego(string nombre, int anioDeLanzamiento, string nombreDeConsolaJugable)
        {
            juegosDeConsola.Add(new Juego(nombre, anioDeLanzamiento, nombreDeConsolaJugable));

            puntaje += 29;
        }

        public override void Jugar(int horas)
        {
            puntaje += 3 * horas;
        }

    }
}