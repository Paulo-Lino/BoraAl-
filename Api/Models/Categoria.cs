namespace BoraAli.Api.Models
{
    public class Categoria : Base
    {
        public string Nome { get; private set; } = string.Empty;
        public List<PontoTuristico> PontosTuristicos {get; set;} = new List<PontoTuristico>();

        public Categoria(string nome, List<PontoTuristico> pontoTuristicos)
        {
            Nome = nome;
            PontosTuristicos = pontoTuristicos;

        }
        public Categoria(){}
    }
}
