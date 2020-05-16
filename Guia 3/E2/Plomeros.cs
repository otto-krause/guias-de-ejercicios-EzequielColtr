namespace E2
{
    public class Plomeros : Contrastistas
    {
        int horasTrabajadas = 0;

        public void trabajar(int horas)
        {
            horasTrabajadas = horas;
        }
        
        public int cobrar()
        {
            int PlataTotal = 0;

            for (int i = 0; i < horasTrabajadas; i++)
            {
                PlataTotal += 80;
            }

            return PlataTotal;
        }

        
    }
}