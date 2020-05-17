namespace E5
{
    public static class FalconArmor
    {
        static int potencia = 25;

        static int resistencia = 10;

        public static int BonificacionDeDaño()
        {
            return (potencia + resistencia)/2;
        }

        public static void entrenamiento(int minutos)
        {
            if(resistencia - minutos != 0)
            {
                resistencia -= minutos;
            
                potencia += 10;
            }
            
        }

    }
}