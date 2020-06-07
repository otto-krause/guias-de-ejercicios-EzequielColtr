namespace E5
{
    public class Cyborg : SerPensante
    {
        public Cyborg()
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
            inteligencia += conocimientos.Count;
        }
    }
}