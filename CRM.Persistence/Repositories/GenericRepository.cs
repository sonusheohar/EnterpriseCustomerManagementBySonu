using CRM.Application.Common.Interfaces;
using CRM.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace CRM.Persistence.Repositories
{
    public class GenericRepository<T> : IRepository<T>
    where T : class
    {
        protected readonly AppDbContext Context;
        public GenericRepository(AppDbContext context)
        {
            Context = context;
        }

        public async Task<T?> GetByIdAsync(Guid id)
        {
            return await Context.Set<T>().FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await Context.Set<T>().ToListAsync();
        }

        public async Task AddAsync(T entity)
        {
            await Context.Set<T>().AddAsync(entity);
        }

        public void Update(T entity)
        {
            Context.Set<T>().Update(entity);
        }

        public void Delete(T entity)
        {
            Context.Set<T>().Remove(entity);
        }
    }
}
