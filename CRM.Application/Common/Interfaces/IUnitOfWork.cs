
namespace CRM.Application.Common.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        ICustomerRepository Customers { get; }
        Task<int> SaveChangesAsync();
    }
}
