namespace E4
{
    public abstract class Empleado
    {
        protected int cajaBancaria;

        public Empleado(int cajaBancaria)
        {
            this.cajaBancaria = cajaBancaria;
        }

        public int CajaBancaria { get => cajaBancaria;}

        public abstract void depositar(int personas, string clase);
    }
}