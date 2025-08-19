using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using PizzaPort.Domain.Interfaces;
using PizzaPort.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPort.Infrastructure.Repositories
{
    public class GenericRepository<TDomain,TEntity> : IGenericRepository<TDomain> where
        TDomain : class
        where TEntity : class
    {
        protected readonly PizzaPortDBContext _dbContext;
        protected readonly IMapper _mapper;

        public GenericRepository(PizzaPortDBContext dbContext,IMapper mapper) {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task AddAsyn(TDomain DomainEntity)
        {
            TEntity result=_mapper.Map<TEntity>(DomainEntity);
          await _dbContext.Set<TEntity>().AddAsync(result);
           
        }

        public async Task<int> CommitAsync()
        {
          return await _dbContext.SaveChangesAsync();
           
        }

        public async Task<IEnumerable<TDomain>> GetAllAsync()
        {
            //IQueryable<TEntity> query= _dbContext.Set<TEntity>();
            //var result=_mapper.Map<IQueryable<TDomain>>(query);
            // return await result.ToListAsync();
            return await _dbContext.Set<TEntity>()
             .ProjectTo<TDomain>(_mapper.ConfigurationProvider)
             .ToListAsync();
        }

        public async Task<TDomain?> GetByIdAsync(object id)
        {        
                TEntity? obj = await _dbContext.Set<TEntity>().FindAsync(id);
               return obj==null ? null : _mapper.Map<TDomain>(obj);         

        }
    }
}
