namespace E7
{
    public class CamTrasera
    {
        int resolucion;
        int cantFotos;

        public CamTrasera(int resolucion, int cantFotos)
        {
            this.resolucion = resolucion;
            this.cantFotos = cantFotos;
        }
    
        public int PesoPorFoto()
        {
            return resolucion * 3; /*devuelve en mb*/
        }

        public int PesoTotalDeFotos()
        {
            return (resolucion * 3) * cantFotos; /*devuelve en mb*/
        }
    
    }

    



}