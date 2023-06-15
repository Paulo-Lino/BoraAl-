namespace BoraAli.Api.Models
{
    public class Usuario : Base
    {
        #region Propriedades
        public string Nome { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public int Idade { get; set; }
        public string Genero { get; set; } = string.Empty;
        public List<Visita> Visitas { get; set; } = new List<Visita>();
        public List<Favorito> Favoritos { get; set; } = new List<Favorito>();
        public List<Premio> Premio { get; private set; } = new List<Premio>();
        public List<Resgate> Resgates { get; private set; } = new List<Resgate>();
        public List<Roteiro> Roteiros { get; private set; } = new List<Roteiro>();
        public List<Avaliacao> Avaliacoes { get; private set; } = new List<Avaliacao>();
        #endregion

         #region Construtores
        public Usuario(string nome, string email, int idade, string genero)
        {
            Nome = nome;
            Email = email;
            Idade = idade;
            Genero = genero;
        }
        public Usuario() { }
        #endregion
    }
}
