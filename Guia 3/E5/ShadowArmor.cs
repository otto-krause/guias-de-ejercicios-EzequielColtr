namespace E5
{
    public static class ShadowArmor
    {
        
        static int desgaste = 1;
    
        public static void entrenamiento()
        {
            desgaste += X.PedirXbuster;
        }

        public static int BonificacionDeDaño()
        {
            return 80/desgaste;
        }


    }
}