using CRM.Domain.Entities;

namespace CRM.Application.Common.Interfaces
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        Task<Customer?> GetByEmailAsync(string email);
    }
}
