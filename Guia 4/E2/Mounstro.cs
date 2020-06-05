namespace E2
{
    public abstract class Mounstro
    {
        protected int respeto;

        protected string nombre;

        public Mounstro(int respeto, string nombre)
        {
            this.respeto = respeto;
            this.nombre = nombre;
        }

        public int Respeto { get => respeto;}
        public string Nombre { get => nombre;}

        public abstract void Asustar();
        
        public abstract void Reir();

        public bool Respetable()
        {
            return respeto > 70;
        }
    }
}