using System;

namespace Ejercicio
{
    public class Recuerdo
    {
        string descripcion;
        int fecha;
        string emocionDominanteActual;

        public Recuerdo(string descripcion, int fecha, string emocionDominante)
        {
            this.descripcion = descripcion;
            this.fecha = fecha;
            this.emocionDominanteActual = emocionDominante;
        }

        public string EmocionDominanteActual { get => emocionDominanteActual;}
        public string Descripcion { get => descripcion;}
    }
}
