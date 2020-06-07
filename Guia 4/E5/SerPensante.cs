using System.Collections.Generic;   
namespace E5
{
    public abstract class SerPensante
    {
        protected List<string> conocimientos;
        protected List<string> intereses;

        protected int inteligencia;

        public SerPensante()
        {
            conocimientos = new List<string>();
            intereses = new List<string>();
            inteligencia = 0;
        }

        public int Inteligencia { get => inteligencia;}

        public abstract void estudiar(string tema);
        public abstract void pensar(string tema);
    }
}