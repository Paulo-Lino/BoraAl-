namespace BoraAli.Api.Models
{
    public class Avaliacao : Base
    {
        #region Propriedades
        public int Nota { get; set; }
        public string? Comentario { get; set; }
        public Usuario Usuario { get; set; } = new Usuario();
        public PontoTuristico PontoTuristico { get; set; } = new PontoTuristico();
        public Roteiro Roteiro { get; set; } = new Roteiro();
        #endregion

        #region Construtores
        public Avaliacao(int nota, string comentario, Usuario usuario, PontoTuristico pontoTuristico)
        {
            Nota = nota;
            Comentario = comentario;
            Usuario = usuario;
            PontoTuristico = pontoTuristico;
        }
        public Avaliacao(int nota, string comentario, Usuario usuario, Roteiro roteiro)
        {
            Nota = nota;
            Comentario = comentario;
            Usuario = usuario;
            Roteiro = roteiro;
        }


        public Avaliacao() { }
        #endregion
    }
}
