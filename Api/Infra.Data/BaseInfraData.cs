using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoraAli.Api.Context;
using Microsoft.EntityFrameworkCore;

namespace BoraAli.Api.Infra.Data
{
    public class BaseInfraData : IBaseInfraData
    {
        private readonly BoraAliContext _context;
        public BaseInfraData(BoraAliContext context)
        {
            _context = context;
            
        }
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
           _context.Remove(entity);
        }

        public async Task<bool> SaveChangesAsync()
        {
           return await _context.SaveChangesAsync() > 0;
        }

        public void Update<T>(T entity) where T : class
        {
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}