namespace E3
{
    public class DiscoSSD : Componentes
    {

        int precio;

        string Sata;

        public DiscoSSD(int precio, string sata)
        {
            this.precio = precio;
            this.Sata = sata;
        }

        public bool EsCompatible(Motherboard motherboard)
        {
            return (Sata == motherboard.PedirSata);
        }

        public int Precio()
        {
            return precio;
        }
    }
}