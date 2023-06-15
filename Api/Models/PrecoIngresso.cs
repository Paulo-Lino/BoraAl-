namespace BoraAli.Api.Models
{
    public class PrecoIngresso : Base
    {
        #region Propriedades
        public string Tipo { get; set; } = string.Empty;
        public Double Valor { get; private set; }
        public PontoTuristico PontoTuristico { get; set; } = new PontoTuristico();
        #endregion

        #region Construtores
        public PrecoIngresso(string tipo, Double valor, PontoTuristico pontoTuristico) 
        {
            Tipo = tipo;
            Valor = valor;
            PontoTuristico = pontoTuristico;
        }
        public PrecoIngresso(){}
        #endregion

    }
}
