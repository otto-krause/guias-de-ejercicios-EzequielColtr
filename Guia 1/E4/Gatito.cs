namespace E4
{
    public class Gatito
    {
        string nombre;
        bool vacunas;
        int energia; 

        public Gatito(string nombre, bool vacunas, int energia)
        {
            this.nombre = nombre;
            this.energia = energia;
            this.vacunas = vacunas;
        }

        public string nombreGato()
        {
            return nombre;
        }

        public bool estaVacunado()
        {
            return vacunas;
        }

        public int jugar(int minutosDeJuego)
        {
            return energia - (minutosDeJuego / 2);
        }

        public int comer(int vecesQueComio)
        {
            return energia + (vecesQueComio * 50);
        }

        public bool estaSaludable()
        {
            return vacunas && energia > 30;
        }


    }
}