using System.Collections.Generic;

namespace E5
{
    public class Humano : SerPensante
    {
        public Humano()
        {

        }
        public override void estudiar(string tema)
        {
            conocimientos.Add(tema);
            if(intereses.Contains(tema))
            {
                inteligencia++;
            }
        }

        public override void pensar(string tema)
        {
            int i = 0;
            
            List<string> conocimientosReverse = new List<string>();

            conocimientosReverse = conocimientos;
            
            conocimientosReverse.Reverse();
            
            while(i<5 && conocimientos.Count > 5)
            {
                if(conocimientos[i] == tema)
                {
                    inteligencia += 5;
                }
            }
        }

    }
}