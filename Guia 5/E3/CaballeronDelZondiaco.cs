using System.Collections.Generic;

namespace E3
{
    public class CaballeronDelZodiaco
    {
        string nombre;
        string dios;
        Armadura armadura = new Armadura("","");
        string signo;

        public string Dios { get => dios;}
        public string Signo { get => signo;}

        public CaballeronDelZodiaco(string nombre, string dios, Armadura armadura, string signo)
        {
            this.nombre = nombre;
            this.dios = dios;
            this.armadura = armadura;
            this.signo = signo;
        }

        

        public string llamarArmadura()
        {
            return armadura.Mostrarse();
        }
    }
}