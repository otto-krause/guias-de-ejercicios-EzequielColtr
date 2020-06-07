namespace E4
{
    public class Administrativo : Empleado
    {
        public Administrativo(int cajaBancaria) : base(cajaBancaria)
        {
        }

        public override void depositar(int personas, string clase)
        {
            cajaBancaria += 35000;
        }

        
    }
}