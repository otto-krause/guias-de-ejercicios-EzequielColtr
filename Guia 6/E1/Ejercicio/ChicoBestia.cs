namespace Ejercicio
{
    public class ChicoBestia : Titan
    {

        private string color = "";

        public ChicoBestia(string color, int tristeza)
        {
            this.color = color;
            this.tristeza = tristeza;
        }

        public override void comePizza(int porciones)
        {
            color = "Amarillo patito fluorescente de las montañas del himalaya amazónico";
        }

        public override bool estaTriste()
        {
            return tristeza > 9999;
        }

        public override void llorarPorRobocop()
        {
            tristeza -= 8;
            if(tristeza < 0)
                tristeza = 0;
        }

        public override int poder()
        {
            return color.Length * 13;
        }

        public void CambiarDeColor(string colorNuevo)
        {
            color = colorNuevo;
            tristeza += 4;
        }

    }
}