namespace BoraAli.Api.Models
{
    public class PontoTuristico : Base
    {
        #region Propriedades
        public string Nome { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public string Logradouro { get; set; } = string.Empty;
        public string Latitude { get; set; } = string.Empty;
        public string Longitude { get; set; } = string.Empty;
        public List<Visita> Visitas { get; set; } = new List<Visita>();
        public Categoria Categoria { get; set; } = new Categoria();
        public List<HorarioFunc> HorarioFuncs { get; set; } = new List<HorarioFunc>();
        public List<PrecoIngresso> PrecoIngressos { get; set; } = new List<PrecoIngresso>();
        public List<Premio> Premios { get; set; } = new List<Premio>();
        public List<Roteiro> Roteiros { get; set; } = new List<Roteiro>();
        public Favorito Favorito { get; set; } = new Favorito();
        public List<Avaliacao> Avaliacoes { get; set; } = new List<Avaliacao>();
        #endregion

        public PontoTuristico() { }


    }
}
