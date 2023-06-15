using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoraAli.Api.Models;

namespace BoraAli.Api.Infra.Data
{
    public interface IUsuarioInfraData : IBaseInfraData
    {
       Task<IEnumerable<Usuario>> GetUsuarios();
       Task<Usuario> GetUsuarioById(int id);

    }
}