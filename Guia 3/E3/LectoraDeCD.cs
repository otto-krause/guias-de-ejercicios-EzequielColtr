namespace E3
{
    public class LectoraDeCD : Componentes
    {
        int precio;

        string Sata;

        public LectoraDeCD(int precio, string sata)
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