namespace E4
{
    public class RRHH : Empleado
    {
        public RRHH(int cajaBancaria) : base(cajaBancaria)
        {

        }

        public override void depositar(int personas, string clase)
        {
            cajaBancaria += 5000 + (5000 * personas);
        }
    }
}