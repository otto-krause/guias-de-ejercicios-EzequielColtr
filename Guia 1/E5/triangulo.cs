namespace E5
{
    public class triangulo
    {
        int l1 = 0;
        int l2 = 0;
        int l3 = 0;
        
        public triangulo(int l1, int l2, int l3)
        {
            this.l1 = l1;
            this.l2 = l2;
            this.l3 = l3;
        }

        public bool esEscaleno()
        {
            return (l1 != l2 && l1 != l3 && l2 != l3);
        }

        public bool esIsosceles()
        {
            return (l1 == l2 || l1 == l3 || l2 == l3);
        }

        public bool esEquilatero()
        {
            return (l1 == l2 && l1 == l3);
        }

        public bool esRectangulo()
        {
            return ((l1 * l1) + (l2 * l2) == (l3 * l3));
        }



    }
}