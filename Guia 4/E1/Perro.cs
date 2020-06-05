namespace E1
{
    public class Perro : Animales
    {
        public Perro(int energia) : base(energia)
        {

        }

        public override void Comer()
        {
            energia += 15;
        }

        public override void Jugar()
        {
            energia -= 20;
        }
    }
}