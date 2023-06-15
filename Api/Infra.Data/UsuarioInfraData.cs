using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoraAli.Api.Context;
using BoraAli.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace BoraAli.Api.Infra.Data
{
    public class UsuarioInfraData : BaseInfraData, IUsuarioInfraData
    {
        private readonly BoraAliContext _context;
        public UsuarioInfraData(BoraAliContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Usuario>> GetUsuarios()
        {
            return await _context.Usuario.ToListAsync();
        }
        public async Task<Usuario> GetUsuarioById(int id)
        {
            return await _context.Usuario.Where(x => x.Id == id).FirstAsync();
        }

    }
}