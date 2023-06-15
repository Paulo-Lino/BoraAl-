namespace BoraAli.Api.Models
{
    public class Premio : Base
    {
        #region Propriedades
        public string Nome { get; set; } = string.Empty;
        public int QtdPontos { get; private set; }
        public string DescricaoPremio { get; set; } = string.Empty;
        public PontoTuristico PontoTuristico { get; set; } = new PontoTuristico();
        public Usuario Usuario { get; set; } = new Usuario();
        public Resgate Resgate { get; set; } = new Resgate();
        #endregion

        #region Construtores
        public Premio(string nome, string descricao, PontoTuristico pontoTuristico, Usuario usuario)
        {
            Nome = nome;
            DescricaoPremio = descricao;
            PontoTuristico = pontoTuristico;
            Usuario = usuario;

        }
        public Premio(){}
        #endregion
    }
}
