namespace E3
{
    public class Ponystation4ProSaladaEdition : Consola
    {

        protected string nombre = "Ponystation4ProSaladaEdition";

        public Ponystation4ProSaladaEdition(int puntaje) : base(puntaje)
        {

        }

        public override string Nombre()
        {
            return nombre;
        }

        public override void AgregarJuego(string nombre, int anioDeLanzamiento, string nombreDeConsolaJugable)
        {
            juegosDeConsola.Add(new Juego(nombre, anioDeLanzamiento, nombreDeConsolaJugable));

            juegosDeConsola.RemoveAt(0);

            puntaje += 29;
        }

        public override void Jugar(int horas)
        {
            puntaje += 3 * horas;
        }

        public override int devolverPuntaje()
        {
            return puntaje/2;
        }

    }
}