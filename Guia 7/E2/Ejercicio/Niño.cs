namespace Ejercicio
{
    public class Niño
    {
        int caramelos;
        int actitud;
        int capacidadAsustar;
        string tipoTraje;

        public int CapacidadAsustar { get => capacidadAsustar;}
        public int Caramelos { get => caramelos;}

        public Niño(int actitud, string tipoTraje)
        {
            this.actitud = actitud;
            this.tipoTraje = tipoTraje;

            capacidadAsustar = (puntuacionDeTraje(tipoTraje) + 3) * actitud;
        }
    
        private int puntuacionDeTraje(string tipoTraje)
        {
            if(tipoTraje == "Tierno")
                return 2;
            else   
                return 5;
        }

        public void asustar(Adulto adulto)
        {
            if(adulto.Tipo == "Comun")
            {
                if(adulto.Tolerancia < capacidadAsustar)
                {
                    caramelos = adulto.Tolerancia/2;
                }
            }
            else if(adulto.Tipo == "Abuelo")
            {
                caramelos = adulto.Tolerancia/2;
            }
        
        }
   
   
    }
}