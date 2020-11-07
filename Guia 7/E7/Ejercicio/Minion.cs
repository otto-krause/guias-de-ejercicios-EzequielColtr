using System;
using System.Collections.Generic;
using System.Linq;

namespace Ejercicio
{
    public class Minion
    {
        List<Arma> armas = new List<Arma>();
        int bananas;
        string estado;
        int concentracion;

        int maldadesHechas;

        public Minion(List<Arma> armas, int bananas, string estado)
        {
            this.bananas = bananas;
            this.estado = estado;

            this.armas = armas;  
        }

        public List<Arma> Armas { get => armas; set => armas = value; }
        public int Bananas { get => bananas; set => bananas = value; }
        public int Concentracion { get => concentracion;}
        public string Estado { get => estado;}
        public int MaldadesHechas { get => maldadesHechas; set => maldadesHechas = value; }

        public void tomarSuero()
        {
            if(estado == "Amarillo")
            {
                armas.Clear();
                bananas -= 1;

                estado = "Violeta";
                concentracion = bananas;
                
            }
            else
            {
                bananas -= 1;
                
                estado = "Amarillo";
                concentracion = armas.Max(arma => arma.Potencia) + bananas;
            }
        }
    }
}
