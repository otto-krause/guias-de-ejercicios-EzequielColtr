namespace E2
{
    public class Amigable : Mounstro
    {
        public Amigable(int respeto, string nombre) : base(respeto,nombre)
        {
        }

        public override void Asustar()
        {
            respeto += 1;
        }

        public override void Reir()
        {
            respeto += 7;
        }

        
    }
}