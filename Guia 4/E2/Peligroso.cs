namespace E2
{
    public class Peligroso : Mounstro
    {
        public Peligroso(int respeto, string nombre) : base(respeto,nombre)
        {
        }

        public override void Asustar()
        {
            respeto += 5;
        }

        public override void Reir()
        {
            respeto -= 2;
        }
    }
}