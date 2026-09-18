namespace CodeFirstMovies.Models
{
    public class Filme
    {
        public int Id { get; set; }

        public int IdDiretor { get; set; }

        public Diretor? Diretor { get; set; }

        public ICollection<Genero> Generos { get; set; } = new List<Genero>();

        public string Titulo { get; set; }

        public string Sinopse { get; set; }

        public int DuracaoMin {  get; set; }
    }
}
