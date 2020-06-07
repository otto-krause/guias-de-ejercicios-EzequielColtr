namespace E5
{
    public class Robot : SerPensante
    {
        public Robot()
        {

        }
        public override void estudiar(string tema)
        {
            conocimientos.Add(tema);
        }

        public override void pensar(string tema)
        {
            inteligencia += conocimientos.Count;
        }

    }
}