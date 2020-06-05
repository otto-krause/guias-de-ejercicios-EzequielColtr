namespace E1
{
    public class Pajaro : Animales
    {
        public Pajaro(int energia) : base(energia)
        {

        }

        public override void Comer()
        {
            energia += 10;
        }

        public override void Jugar()
        {
            energia -= 5;
        }
    }
}