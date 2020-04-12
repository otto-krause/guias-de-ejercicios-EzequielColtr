namespace E7
{
    public class Celular
    {
        bool nfc;
        bool bluethoot;
        int almacenamiento;
        int cantAplic;


        public Celular(bool nfc, bool bluethoot, int almacenamiento, int cantAplic)
        {
            this.nfc = nfc;
            this.bluethoot = bluethoot;
            this.almacenamiento = almacenamiento;
            this.cantAplic = cantAplic;

        } 

        public int MemoriaDisponible(int pesoTotalFrontal, int pesoTotalTrasera)
        {
            return almacenamiento - ((cantAplic * 70) + pesoTotalFrontal + pesoTotalTrasera);
        }

        public bool TeCargaLaSUBE()
        {
            return nfc;
        }


    }
}