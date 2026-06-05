using CRM.Application.Common.Interfaces;
using CRM.Persistence.Context;

namespace CRM.Persistence.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public ICustomerRepository Customers { get; }

        public UnitOfWork(
            AppDbContext context,
            ICustomerRepository customerRepository)
        {
            _context = context;
            Customers = customerRepository;
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
