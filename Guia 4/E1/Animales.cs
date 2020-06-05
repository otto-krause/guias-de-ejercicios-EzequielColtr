namespace E1
{
    public abstract class Animales
    {
        protected int energia;

        private int energiaInicial;

        public Animales(int energia)
        {
            this.energia = energia;

            energiaInicial = energia;
        }


        public abstract void Comer();

        public abstract void Jugar();

        public void dormir()
        {
            energia = energiaInicial;
        }

        public int MostrarEnergia()
        {
            return energia;
        }
    
    }
}