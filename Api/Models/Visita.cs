namespace BoraAli.Api.Models
{
    public class Visita : Base
    {
        public DateTime DataVisita { get; private set; }
        public Usuario Usuario { get; set; } = new Usuario();
        public PontoTuristico PontoTuristico { get; set; } = new PontoTuristico();

        public Visita(Usuario usuario, PontoTuristico pontoTuristico)
        {
            PontoTuristico = pontoTuristico;
            Usuario = usuario;
        }
        public Visita(){}
    }
}
