using AutoMapper;
using CRM.Application.Common.Interfaces;
using CRM.Application.Features.Customers.DTOs;
using CRM.Domain.Common;
using MediatR;

namespace CRM.Application.Features.Customers.Queries
{
    public class GetCustomerByIdHandler
    : IRequestHandler<GetCustomerByIdQuery,
        Result<CustomerDto>>
    {
        private readonly IUnitOfWork _unitOfWork;

        private readonly IMapper _mapper;

        public GetCustomerByIdHandler(
            IUnitOfWork unitOfWork,
            IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Result<CustomerDto>> Handle(
            GetCustomerByIdQuery request,
            CancellationToken cancellationToken)
        {
            var customer =
                await _unitOfWork.Customers
                    .GetByIdAsync(request.Id);

            if (customer is null)
            {
                return Result<CustomerDto>
                    .Failure("Customer not found");
            }

            var dto = _mapper.Map<CustomerDto>(customer);

            return Result<CustomerDto>.Succeed(dto);
        }
    }
}