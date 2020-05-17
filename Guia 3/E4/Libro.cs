namespace E4
{
    public class Libro
    {
        string titulo;
        string autor;

        public string PedirTitulo { get => titulo;}

        public Libro(string titulo, string autor)
        {
            this.titulo = titulo;
            this.autor = autor;
        }

        
    }
}