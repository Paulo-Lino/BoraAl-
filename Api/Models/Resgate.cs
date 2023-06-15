namespace BoraAli.Api.Models
{
    public class Resgate : Base
    {
        #region Propriedades
        public int QtdItensResgatados { get; private set; }
        public DateTime DataResgate  { get; private set; }
        public List<Premio> Premios { get; set; } = new List<Premio>();
        public Usuario Usuario { get; private set; } = new Usuario();
        #endregion

        #region Construtores
        public Resgate(int qtditensResgatados, DateTime dataResgate, List<Premio> premio, Usuario usuario)
        {
            QtdItensResgatados = qtditensResgatados;
            DataResgate = dataResgate;
            Premios = premio;
            Usuario = usuario;

        }
        public Resgate(){}
        #endregion
    }
}
