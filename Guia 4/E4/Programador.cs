namespace E4
{
    public class Programador : Empleado
    {
        public Programador(int cajaBancaria) : base(cajaBancaria)
        {
            
        }

        public override void depositar(int personas, string clase)
        {
            switch(clase)
            {
                case "junior":
                {
                    cajaBancaria += 20000 + 10000;
                    break;
                }
                case "semiSenior":
                {
                    cajaBancaria += 20000 + 20000;
                    break;
                }
                case "senior":
                {
                    cajaBancaria += 20000 + 40000;
                    break;
                }
            }
        }

        
    }
}