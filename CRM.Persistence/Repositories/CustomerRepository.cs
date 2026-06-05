using CRM.Application.Common.Interfaces;
using CRM.Domain.Entities;
using CRM.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace CRM.Persistence.Repositories
{
    public class CustomerRepository
    : GenericRepository<Customer>,
      ICustomerRepository
    {
        public CustomerRepository(AppDbContext context)
        : base(context)
        {
        }
        public async Task<Customer?> GetByEmailAsync(string email)
        {
            return await Context.Customers
                .FirstOrDefaultAsync(x => x.Email == email);
        }
    }
}
