using CRM.Application.Features.Customers.DTOs;
using CRM.Domain.Common;
using MediatR;

namespace CRM.Application.Features.Customers.Queries
{
    public record GetCustomerByIdQuery(Guid Id)
      : IRequest<Result<CustomerDto>>;
}
