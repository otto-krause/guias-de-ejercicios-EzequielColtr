namespace E3
{
    public class PlacaDeVideo : Componentes
    {

        int precio;

        string PCIE;

        public PlacaDeVideo(int precio, string pCIE)
        {
            this.precio = precio;
            this.PCIE = pCIE;
        }

        public bool EsCompatible(Motherboard motherboard)
        {
            return PCIE == motherboard.PedirPCIE;
        }

        public int Precio()
        {
            return precio;  
        }
    }
}