namespace E2
{
    public class Pintores : Contrastistas
    {
        int horasTrabajadas = 0;
        int litrosDePintura = 0;

        public Pintores(int litrosDePintura)
        {
            this.horasTrabajadas = 0;
            this.litrosDePintura = litrosDePintura;
        }

        public void trabajar(int horas)
        {
            horasTrabajadas = horas;
        }

        public int cobrar()
        {
            int PlataTotal = 0;
            
            for (int i = 0; i < horasTrabajadas; i++)
            {
               if(litrosDePintura >= 3)
               {
                   litrosDePintura -= 3;
                   PlataTotal += 150;
               } 
            }

            return PlataTotal;
        }
    }
}