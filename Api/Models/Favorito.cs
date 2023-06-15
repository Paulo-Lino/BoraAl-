
using System.ComponentModel.DataAnnotations.Schema;

namespace BoraAli.Api.Models
{
    public class Favorito : Base
    {
        #region Propriedades
        public int QtdFavoritos { get; private set; }

        
        public int PontosTuristicoId { get; set; }
        public PontoTuristico PontoTuristico { get; set; } = new PontoTuristico();
        public Usuario Usuario { get; set; } = new Usuario();
        #endregion

        #region Construtores
        public Favorito(PontoTuristico pontoTuristico, Usuario usuario)
        {
            PontoTuristico = pontoTuristico;
            Usuario = usuario;
        }

        public Favorito() { }
        #endregion
    }
}
