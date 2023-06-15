namespace BoraAli.Api.Models
{
    public class Roteiro : Base
    {
        #region Propriedades
        public string Nome { get; set; } = string.Empty;
        public double TamanhoRota { get; private set; }
        public int QtdPontosVisitados { get; private set; }
        public Usuario Usuario { get; private set; } = new Usuario();
        public List<Avaliacao> Avaliacao { get; set; } = new List<Avaliacao>();
        public List<PontoTuristico> PontoTuristico { get; set; } = new List<PontoTuristico>();
        #endregion

        #region Construtor
        public Roteiro(int qtdPontosVisitados, double tamanhoRota, Usuario usuario, List<PontoTuristico> pontoTuristicos)
        {
            QtdPontosVisitados = qtdPontosVisitados;
            Usuario = usuario;
            TamanhoRota = tamanhoRota;
            PontoTuristico = pontoTuristicos;
        }
        public Roteiro(){ }
        #endregion
    }
}
