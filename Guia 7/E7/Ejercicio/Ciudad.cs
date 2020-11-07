using System;

namespace Ejercicio
{
    public class Ciudad
    {
        int temperatura;
        int alturaPiramide;

        bool existePiramide;
        bool existeSueroMutante;
        bool ExisteLuna;

        public Ciudad(int temperatura, int alturaPiramide, bool existePiramide, bool existeSueroMutante, bool existeLuna)
        {
            this.temperatura = temperatura;
            this.alturaPiramide = alturaPiramide;
            this.existePiramide = existePiramide;
            this.existeSueroMutante = existeSueroMutante;
            ExisteLuna = existeLuna;
        }

        public int AlturaPiramide { get => alturaPiramide;}
        
        public bool ExistePiramide { get => existePiramide; set => existePiramide = value; }
        public bool ExisteSueroMutante { get => existeSueroMutante; set => existeSueroMutante = value; }
        public bool ExisteLuna1 { get => ExisteLuna; set => ExisteLuna = value; }
        public int Temperatura { get => temperatura; set => temperatura = value; }
    }
}
