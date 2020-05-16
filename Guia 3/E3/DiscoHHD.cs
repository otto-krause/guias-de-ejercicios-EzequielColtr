namespace E3
{
    public class DiscoHHD : Componentes
    {

        int precio;

        string Sata;

        public DiscoHHD(int precio, string sata)
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