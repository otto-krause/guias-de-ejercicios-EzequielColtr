namespace E3
{
    public class Armadura
    {
        string nombre;
        string material;

        public Armadura(string nombre, string material)
        {
            this.nombre = nombre;
            this.material = material;
        }

        public string Mostrarse()
        {
            return nombre + " " + material;
        }
    }
}