namespace Ejercicio
{
    public class Heroe
    {
        Quirk quirkDeHeroe;
        int victorias;
        int derrotas;
        bool licenciaOactaDifuncion;

        public Heroe(Quirk quirkDeHeroe, int victorias, int derrotas, bool licenciaOactaDifuncion)
        {
            this.quirkDeHeroe = quirkDeHeroe;
            this.victorias = victorias;
            this.derrotas = derrotas;
            this.licenciaOactaDifuncion = licenciaOactaDifuncion;
        }
    }
}