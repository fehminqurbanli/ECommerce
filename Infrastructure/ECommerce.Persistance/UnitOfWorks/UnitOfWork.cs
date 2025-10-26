using ECommerce.Application.Interfaces.Persistance;
using ECommerce.Application.Interfaces.UnitOfWorks;
using ECommerce.Persistance.Context;
using ECommerce.Persistance.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Persistance.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _dbContext;

        public UnitOfWork(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async ValueTask DisposeAsync()=> await _dbContext.DisposeAsync();

        public int Save() => _dbContext.SaveChanges();

        public Task<int> SaveAsync()=> _dbContext.SaveChangesAsync();

        IReadRepository<T> IUnitOfWork.GetReadRepository<T>() =>
            new ReadRepository<T>(_dbContext);

        IWriteRepository<T> IUnitOfWork.GetWriteRepository<T>()=>
            new WriteRepository<T>(_dbContext);
    }
}
