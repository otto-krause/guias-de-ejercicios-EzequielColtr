namespace E3
{
    public class MemoriaRam : Componentes
    {
        int precio;
        
        string DDR4oDDR3;

        public MemoriaRam(string dDR4oDDR3, int Precio)
        {
            this.DDR4oDDR3 = dDR4oDDR3;
            this.precio = Precio;   
        }

        public bool EsCompatible(Motherboard motherboard)
        {
            return (DDR4oDDR3 == motherboard.PedirDDR4oDDR3);
        }

        public int Precio()
        {
            return precio;
        }
    }
}