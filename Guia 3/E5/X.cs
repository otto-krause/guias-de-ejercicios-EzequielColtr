namespace E5
{
    static class X
    {
        
        
        static int fuerza = 0;
    
        static int Xbuster = 10;

        public static int PedirXbuster { get => Xbuster; }

        public static int SaberFuerza(string Armadura)
        {
            if(Armadura == "Falcon")
            {
                return fuerza += Xbuster + FalconArmor.BonificacionDeDaño();
            }
            else
            {
                return fuerza += Xbuster + ShadowArmor.BonificacionDeDaño();
            }
            
        }

        public static void entrenar(int minutos, string Armadura)
        {
            if(Armadura == "Falcon")
            {
                Xbuster += 2 * minutos;

                FalconArmor.entrenamiento(minutos);
            }
            else
            {
                ShadowArmor.entrenamiento();
            }
        }
    
    
    }

    
}