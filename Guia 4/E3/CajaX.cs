namespace E3
{
    public class CajaX : Consola
    {

        protected string nombre = "PC";

        public CajaX(int puntaje) : base(puntaje)
        {

        }

        public override string Nombre()
        {
            return nombre;
        }

        public override void AgregarJuego(string nombre, int anioDeLanzamiento, string nombreDeConsolaJugable)
        {
            juegosDeConsola.Add(new Juego(nombre, anioDeLanzamiento, nombreDeConsolaJugable));

            puntaje += 25;
        }
        public override void Jugar(int horas)
        {
            puntaje += 4 * horas;
        }

    }
}