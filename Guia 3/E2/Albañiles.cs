namespace E2
{
    public class Albañiles : contrastistas
    {

        int edad = 0;

        int horasTrabajadas = 0;

        bool MMO;

        public Albañiles(int edad, bool mMO)
        {
            this.edad = edad;
            this.MMO = mMO;
        }

        public void trabajar(int horas)
        {
            horasTrabajadas = horas;
        }
        
        public int cobrar()
        {
            int PlataTotal = 0;
            
            if(edad > 19 && edad < 31)
            {
                for (int i = 0; i < horasTrabajadas; i++)
                {
                    PlataTotal += 50;
                }
            }
            else if(edad > 29 && edad < 51)
            {
                for (int i = 0; i < horasTrabajadas; i++)
                {
                    PlataTotal += 90;
                }
            }
            else if(edad > 49)
            {
                for (int i = 0; i < horasTrabajadas; i++)
                {
                    PlataTotal += 120;
                }
            }

            if(MMO)
            {
                PlataTotal += 50;
            }

            return PlataTotal;
        }

        
    }
}